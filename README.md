# FIRE SAFTY VERIFICATION (FSV)

## Fsv.Common.Entity

- Customer
	- Id
	- Name

- Verification
	- Id
	- Customer
	- Date

## Fsv.Common.Dal

## Fsv.Common.Bll

- CustomersService
	- GetCustomers()
	- CreateCustomer()
	- AddCustomer()

- VerificationsService
	- GetVerifications()
	- GetVerification()
	- CreateVerification()
	- AddVerification()

## Fsv.Reporting.Bll

- VerificationReport


- ReportsGenerator
	- GenerateVerificationReport()

