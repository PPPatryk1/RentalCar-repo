USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[DeleteCar]    Script Date: 01.07.2022 20:47:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[DeleteCar]
@IDCar AS int 

AS
	SET NOCOUNT ON;

	DELETE FROM [dbo].[Cars]
	WHERE IDCar = @IDCar
GO


