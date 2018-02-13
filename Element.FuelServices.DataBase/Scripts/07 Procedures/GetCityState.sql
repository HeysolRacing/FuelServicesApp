IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND NAME = 'GetCityState')
   EXEC('CREATE PROCEDURE Operation.GetCityState AS BEGIN SET NOCOUNT ON; END')
GO

-- ===================================================================================================
-- Author:		Ivan Juarez
-- Create date: 2018/02/31
-- Description:	 Obtiene los precios de una lista específica por Estado o Ciudad 
-- ===================================================================================================
ALTER PROCEDURE Operation.GetCityState 
(
	@State VARCHAR(50) = NULL,
	@City VARCHAR(150) = NULL,
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
	 WHERE	1 =  CASE 
					WHEN (LEN(@State)<>0) THEN 
											  CASE 
												WHEN  
													SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(FederalEntity.FederalEntityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))=SOUNDEX(@State)
												THEN 1
											  END 
					WHEN  (LEN(@City)<>0) THEN 
											 CASE 
												WHEN 
													SOUNDEX(CONVERT(VARCHAR, UPPER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Municipality.MunicipalityDescription, 'á', 'a'), 'é','e'), 'í', 'i'), 'ó', 'o'), 'ú','u'))))=SOUNDEX(@City)
												THEN 1
											  END 
				END 
		AND Supplier.SupplierID=(
								CASE  WHEN @SupplierID <>0 THEN @SupplierID 
														   ELSE Supplier.SupplierID
								END
							 )
		AND StationTransaction.TransactionDate = (
														SELECT	MAX(TransactionDate)
														  FROM	Station_Transaction
													)
END
GO
