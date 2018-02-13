IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND NAME = 'GetStation')
   EXEC('CREATE PROCEDURE Operation.GetStation AS BEGIN SET NOCOUNT ON; END')
GO

-- ===================================================================================================
-- Author:		Ivan Juarez
-- Create date: 2018/01/30
-- Description:	Obtiene los precios de una lista específica de ID de estación separada por comas.
-- ===================================================================================================
ALTER PROCEDURE [Operation].[GetStation]

	@ServiceStationID VARCHAR(MAX),
	@SupplierID INT
	
AS
BEGIN

	DECLARE @Cont INT, @SplitOn nvarchar(5)
	
	DECLARE @StationList TABLE
	(
		ServiceStationID VARCHAR(MAX)
	)

	SET @SplitOn = ','
	
	IF LEN(@ServiceStationID) <> 0
	BEGIN
		WHILE (CHARINDEX(@SplitOn,@ServiceStationID)>0)
			BEGIN
				INSERT INTO	@StationList
				(
					ServiceStationID
				)
				SELECT	DATA = LTRIM(RTRIM(SUBSTRING(@ServiceStationID,1,CHARINDEX(@SplitOn,@ServiceStationID) - 1)))
				
				SET @ServiceStationID = SUBSTRING(@ServiceStationID,CHARINDEX(@SplitOn,@ServiceStationID)+1,LEN(@ServiceStationID))
			END
	END
	
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
	  FROM	[dbo].[FuelStation] Station INNER JOIN [dbo].[Station_Supplier] StationSupplier
												ON Station.StationID = StationSupplier.StationID
										INNER JOIN [dbo].[Supplier] Supplier
												ON  StationSupplier.SupplierID = Supplier.SupplierID
										INNER JOIN [dbo].[Station_Transaction] StationTransaction
												ON StationSupplier.StationSupplierID = StationTransaction.StationSupplierID
	   WHERE	Station.ServiceStation IN(SELECT ServiceStationID FROM @StationList) 
				AND Supplier.SupplierID=(
								CASE  WHEN @SupplierID <>0 THEN @SupplierID 
														   ELSE Supplier.SupplierID
								END
							 )
				AND StationTransaction.TransactionDate=(select max(TransactionDate) from Station_Transaction)
END
GO
