USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[CorrectAdmin]    Script Date: 10.07.2022 20:02:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[CorrectAdmin]
@AdminCode AS nvarchar(50),
@Password AS nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Administrators]
	WHERE AdminCode = @AdminCode and Password= @Password;
END
GO


