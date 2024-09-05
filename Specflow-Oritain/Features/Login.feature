Feature: Login
	
Scenario: Validate the login flow
	Given Enter valid username and password
	When Click on login button
	Then Verify login is successful