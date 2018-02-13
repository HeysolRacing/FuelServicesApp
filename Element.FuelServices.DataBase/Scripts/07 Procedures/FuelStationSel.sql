IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND NAME = 'FuelStationSel')
   EXEC('CREATE PROCEDURE Operation.FuelStationSel AS BEGIN SET NOCOUNT ON; END')
GO

-- ===================================================================================================
-- Author:		Ricardo Méndez
-- Create date: 2018/01/25
-- Description:	Obtiene el conjunto de registros de la tabla FuelStation.
-- ===================================================================================================
ALTER PROCEDURE Operation.FuelStationSel

AS
BEGIN
	SET NOCOUNT ON;
	
	  SELECT	StationID
				,Station
				,ServiceStation
				,Lattitude
				,Longitude
				,ZipCode
				,Created
		FROM	FuelStation
	ORDER BY	StationID
			  
END
GO
