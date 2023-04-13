Feature: Pick Highest Price Item And Add To Cart
	
@Test
Scenario: Add Highest Price Item to Basket
	Given I am on saucedemo website
	When I login with valid username and password
	Then I pick the highest price item and add it to the basket
	



