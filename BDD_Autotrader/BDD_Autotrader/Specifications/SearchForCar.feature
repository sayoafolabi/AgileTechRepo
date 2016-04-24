Feature: SearchCarTest
	In order to buy a car
	As a customer
	I want to be able to search for a car


Scenario Outline: Customer can search for a car
	Given I navigate to Autotrader website
	When I search for a car "<Make>" from a "<Postcode>" of range "<Distance>"
	Then the result displayed contains "<Make>"

Scenarios: 
	| Make   | Postcode | Distance        |
	| Audi   | OL9 8LE  | Within 30 miles |
	| Volvo  | M34 5JE  | Within 70 miles |
	| Ford   | M40 2EW  | Within 60 miles |
	| Honda  | OL9 8LD  | Within 50 miles |
	| Toyota | M20 1EZ  | Within 45 miles |
	
