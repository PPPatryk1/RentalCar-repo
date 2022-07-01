USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[OnlyUnavailable]    Script Date: 01.07.2022 20:48:47 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[OnlyUnavailable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Cars]
	WHERE Status=0;
END
GO


