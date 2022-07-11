USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[EmailCheck]    Script Date: 10.07.2022 20:03:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[EmailCheck]
@Email AS nvarchar(50)

AS
BEGIN
	DECLARE @count AS int;

	SET NOCOUNT ON;
	
	IF EXISTS (SELECT Email FROM [dbo].[Customers] WHERE Email = @Email)
		BEGIN
			SET @count = 1;
		END
	ELSE
		BEGIN
			SET @count = 0;			
		END
	return @count;
END
GO


