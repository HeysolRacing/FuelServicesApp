IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND NAME = 'GetZipCode')
   EXEC('CREATE PROCEDURE Operation.GetZipCode AS BEGIN SET NOCOUNT ON; END')
GO

-- =================================================================================================================================================
-- Author:		Ricardo Méndez
-- Create date: 2018/01/30
-- Description:	Obtiene el conjunto de registros de la tabla FuelStation, que se encuentren en el mismo municipio que el CP enviado como parámetro.
-- =================================================================================================================================================
ALTER PROCEDURE Operation.GetZipCode

	@ZipCode NVARCHAR(20),
	@SupplierID INT

AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT	Station.StationID
			,Station.Station
			,Station.ServiceStation
			,Station.Lattitude
			,Station.Longitude
			,Station.ZipCode
			,MAX(Supplier.SupplierID) [SupplierID]
			,MAX(Supplier.SupplierName) [SupplierName]
			,MAX(StationTransaction.Diesel) [Diesel]
			,MAX(StationTransaction.Magna) [Magna]
			,MAX(StationTransaction.Premium) [Premium]
			,MAX(StationTransaction.TransactionDate) AS TransactionDate
      FROM	[FuelStation] Station INNER JOIN [Station_Supplier] StationSupplier
										  ON Station.StationID = StationSupplier.StationID
								  INNER JOIN [Supplier] Supplier
										  ON  StationSupplier.SupplierID = Supplier.SupplierID
								  INNER JOIN [Station_Transaction] StationTransaction
										  ON StationSupplier.StationSupplierID = StationTransaction.StationSupplierID
	 WHERE	Station.ZipCode IN (
									SELECT     ZipCode
									  FROM   [Settlement]
									 WHERE  MunicipalityID = (
																SELECT  MAX(MunicipalityID)
																  FROM	[Settlement]
																 WHERE	ZipCode = @ZipCode
															)
								) AND
			TransactionDate IN (
									SELECT	MAX(TransactionDate)
									  FROM	[Station_Transaction]
								)
		AND Supplier.SupplierID=(
									CASE  WHEN @SupplierID <>0 THEN @SupplierID 
															   ELSE Supplier.SupplierID
									END
							 )
  GROUP BY	Station.StationID
			,Station.Station
			,Station.ServiceStation
			,Station.Lattitude
			,Station.Longitude
			,Station.ZipCode
			,Supplier.SupplierID
			,Supplier.SupplierName
			,StationTransaction.TransactionDate
END
GO
