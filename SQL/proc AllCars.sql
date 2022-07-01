USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[AllCars]    Script Date: 01.07.2022 20:47:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AllCars]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Cars];
END
GO


