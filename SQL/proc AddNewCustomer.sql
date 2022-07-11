USE [RentalCar]
GO

/****** Object:  StoredProcedure [dbo].[AddNewCustomer]    Script Date: 10.07.2022 20:00:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[AddNewCustomer]
@Firstname AS nvarchar(30),
@Surrname AS nvarchar(30),
@Adress AS nvarchar(200),
@PhoneNumber AS int,
@Email AS nvarchar(50),
@Password AS nvarchar(20)

AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		Set identity_insert [dbo].[Customers] on
		Insert into [dbo].[Customers](IDCustomer, Firstname, Surrname, Adress, PhoneNumber, Email, Password)
		values((Select Max(Customers.IDCustomer)+1 from Customers),@Firstname, @Surrname, @Adress, @PhoneNumber, @Email, @Password)
		Set identity_insert [dbo].[Customers] off
	END TRY
	BEGIN CATCH
		PRINT 'error';
	END CATCH
END
GO


