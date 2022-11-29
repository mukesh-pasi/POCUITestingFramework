Feature: Login

A short summary of the feature

@smoke
Scenario Outline: Verify positive login functionality
	Given User launched the Page
	When User enters the correct username as <username> and correct password as <password>
	And User clicks on the login button
	Then User navigates to homepage
Examples:
	| username | password |
	| Admin    | admin123 |

@smoke
Scenario Outline: Verify Reset Password link sent successfully
	Given User launched the Page
	When User clicks on the forgot password link button
	And User navigate to reset password page
	And User enters the username as <username
	And User clicks on the reset password button
	Then User sucessfully reset the password
Examples:
	| username |
	| Admin    |