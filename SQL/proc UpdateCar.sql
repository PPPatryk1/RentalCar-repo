USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[UpdateCar]    Script Date: 01.07.2022 20:49:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UpdateCar]
@IdCar AS int,
@Brand AS nvarchar(30),
@Model AS nvarchar(50),
@EngineType AS VARCHAR(10),
@Transmission AS VARCHAR(10),
@DoorNumber AS int,
@BootCapacity AS int,
@Price AS int,
@Status AS int

AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		UPDATE [dbo].[Cars]
		SET Brand = @Brand, Model = @Model, EngineType= @EngineType, Transmission=@Transmission, DoorNumber=@DoorNumber, BootCapacity=@BootCapacity, Price = @Price, Status = @Status
		WHERE IDCar = @IdCar;
	END TRY
	BEGIN CATCH
	 PRINT 'Error';
	END CATCH
END
GO


