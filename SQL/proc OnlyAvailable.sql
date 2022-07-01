USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[OnlyAvailable]    Script Date: 01.07.2022 20:48:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[OnlyAvailable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Cars]
	WHERE Status=1;
END
GO


