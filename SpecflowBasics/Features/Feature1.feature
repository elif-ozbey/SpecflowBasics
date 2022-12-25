Feature: Login

Login Test

@Login
Scenario: Correct Login Test
	Given Going to the login page
	And filling the username and password fields
	When click the login button
	Then I see the home page
