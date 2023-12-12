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

- CustomerService
	- GetCustomers()
	- AddCustomer()

- VerificationService
	- GetVerifications()
	- GetVerification()
	- AddVerification()

## Fsv.Reporting.Bll

- VerificationReport


- ReportingService
	- GenerateVerificationReport()

