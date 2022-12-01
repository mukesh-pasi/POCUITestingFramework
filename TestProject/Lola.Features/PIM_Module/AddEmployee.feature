Feature: AddEmployee

Background: 
Given User on home page

Scenario:Verify Adding amployee successfully
	When user clicked on PIM module
	And user clicked on Add Employee Tab
	And user adding the FirstName as "Harry"
    And user adding the MiddleName as "John"
	And user adding the LastName as "Son"
	And user adding the EmployeeId as "335"
	And user clicked on save button
	Then  success message displayed



