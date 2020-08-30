Feature: LogIn
	Login to Guru99 Bank application 

@mytag
Scenario: Login with valid UserName and Password
	Given I launch the application
	And I enter the details
		| UserName   | Password |
		| mngr280795 | EdysAza  |
	When I Click on LogIn Button 
	Then I should view Logged In Screen 




