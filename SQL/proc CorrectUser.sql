USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[CorrectUser]    Script Date: 10.07.2022 20:03:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CorrectUser]
@Email AS nvarchar(50),
@Password AS nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Customers]
	WHERE Email = @Email and Password= @Password;
END
GO


