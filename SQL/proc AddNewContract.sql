USE [RentalCar]
GO


CREATE PROCEDURE [dbo].[AddNewContract]

@IDCar as int,
@IDCustomer as int,
@IDPlace as int,
@StartDay as Date,
@FinishDay as Date,
@TotalPrice as int

AS
BEGIN
	SET NOCOUNT ON;
	BEGIN TRY
		Set identity_insert [dbo].[Contracts] on
		Insert into [dbo].[Contracts](IDContract, IDCar ,IDCustomer, IDPlace, StartDay, FinishDay, TotalPrice)
		values((Select Max(Contracts.IDContract)+1 from Contracts),@IDCar,@IDCustomer,@IDPlace,@StartDay,@FinishDay,@TotalPrice)
		Set identity_insert [dbo].[Contracts] off
	END TRY
	BEGIN CATCH
		PRINT 'error';
	END CATCH
END
GO


