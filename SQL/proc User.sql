USE [RentalCar]
GO

CREATE PROCEDURE [dbo].[User]
@ID as int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * 
	FROM [dbo].[Customers]
	WHERE IDCustomer = @ID;
END
GO


