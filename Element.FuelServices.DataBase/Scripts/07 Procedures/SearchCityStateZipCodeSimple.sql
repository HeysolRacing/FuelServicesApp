IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND NAME = 'SearchCityStateZipCodeSimple')
   EXEC('CREATE PROCEDURE Operation.SearchCityStateZipCodeSimple AS BEGIN SET NOCOUNT ON; END')
GO

-- ===================================================================================================
-- Author:		Ivan Juarez
-- Create date: 2018/02/02
-- Description:	Busque en la ciudad especificada los precios de la estación minorista con los parámetros predeterminados.
-- ===================================================================================================
ALTER PROCEDURE Operation.SearchCityStateZipCodeSimple 
(
	@State VARCHAR(50) = NULL,
	@City VARCHAR(150) = NULL,
	@ZipCode Varchar(10)=NULL,
	@Product Varchar(10)=NULL,
	 @SupplierID INT
)
AS
BEGIN
	SET @State = UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@State, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))
	SET @City=UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@City, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))
	SELECT	Station.StationID
			,Station.Station
			,Station.ServiceStation
			,Station.Lattitude
			,Station.Longitude
			,Station.ZipCode
			,Supplier.SupplierID
			,Supplier.SupplierName
			,StationTransaction.Diesel
			,StationTransaction.Magna
			,StationTransaction.Premium
			,StationTransaction.TransactionDate
			,Municipality.MunicipalityDescription
			,FederalEntity.FederalEntityDescription
	  FROM	dbo.FuelStation Station INNER JOIN dbo.Station_Supplier StationSupplier
											ON Station.StationID = StationSupplier.StationID
									INNER JOIN dbo.Supplier Supplier
											ON  StationSupplier.SupplierID = Supplier.SupplierID
									INNER JOIN dbo.Station_Transaction StationTransaction
											ON StationSupplier.StationSupplierID = StationTransaction.StationSupplierID
									INNER JOIN dbo.Settlement Settlement
											ON Settlement.ZipCode=Station.ZipCode
									INNER JOIN dbo.Federal_Entity FederalEntity
											ON FederalEntity.FederalEntityID=Settlement.FederalEntityID
									INNER JOIN dbo.Municipality Municipality
											ON Municipality.MunicipalityID=Settlement.MunicipalityID
	 WHERE StationTransaction.TransactionDate = (
													SELECT	MAX(TransactionDate) 
													FROM Station_Transaction
												)
			AND 1= CASE  
					WHEN UPPER(@Product)='MAGNA' THEN 
													CASE 
														WHEN StationTransaction.Magna=(SELECT MIN(Magna) FROM Station_Transaction) THEN 1
													END
					WHEN UPPER(@Product)='PREMIUM' THEN 
													CASE 
														WHEN StationTransaction.Premium=(SELECT MIN(Premium) FROM Station_Transaction) THEN 1
													END
					WHEN UPPER(@Product)='DIESEL' THEN 
													CASE 
														WHEN StationTransaction.Diesel=(SELECT MIN(Diesel) FROM Station_Transaction) THEN 1
													END
				END
			
			AND SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(FederalEntity.FederalEntityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))
				=(
												CASE 
													WHEN LEN(@State)<>0 THEN SOUNDEX(@State) 
													ELSE 
														SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(FederalEntity.FederalEntityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))
												END
				 )
			AND	SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Municipality.MunicipalityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))
				=(
					CASE 
						WHEN LEN(@City)<>0 THEN SOUNDEX(@City) 
						ELSE 
							SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Municipality.MunicipalityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))
					END
				  )
	 AND  Station.ZipCode=(
							CASE WHEN LEN(@ZipCode)<>0 THEN @ZipCode 
								 ELSE Station.ZipCode 
							END
						   )
	AND	  Supplier.SupplierID=(
									CASE  WHEN @SupplierID <>0 THEN @SupplierID 
															   ELSE Supplier.SupplierID
									END
							   )

END
GO
