USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[AddNewCar]    Script Date: 01.07.2022 20:44:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AddNewCar]
@Brand AS nvarchar(30),
@Model AS nvarchar(50),
@EngineType AS VARCHAR(10),
@Transmission AS VARCHAR(10),
@DoorNumber AS int,
@BootCapacity AS int,
@Price AS int
--@Status AS int
AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		Set identity_insert [dbo].[Cars] on
		Insert into [dbo].[Cars](IDCar, Brand ,Model, EngineType, Transmission, DoorNumber, BootCapacity, Price)
		values((Select Max(Cars.IDCar)+1 from Cars),@Brand,@Model,@EngineType,@Transmission,@DoorNumber,@BootCapacity,@Price)
		Set identity_insert [dbo].[Cars] off
	END TRY
	BEGIN CATCH
		PRINT 'error';
	END CATCH
END
GO


