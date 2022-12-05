Feature: SearchEmployee

Background:
     Given user on Homepage

Scenario:Verify search employee successfully
        When user click on PIM module
        And user Click on Employee List 
        And user insert in Employee name as "Harry"
        And user click on Search Button 
        Then user see EmployeeName in table