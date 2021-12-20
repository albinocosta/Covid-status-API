@Api
Feature: BaseApiScenarios
	Covid status API

Scenario: 01. Simple consulting of critical cases in Lisboa last day
	Given I want to check critical cases in Lisboa last day
	When I send a resquest to API
	Then I receive 200 OK status code
	And critical cases is less than 100