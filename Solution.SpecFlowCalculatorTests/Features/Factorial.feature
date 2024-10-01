Feature: Factorial calculation
  In order to calculate factorials
  As a user
  I want to be able to calculate factorials of numbers, including zero

Scenario: Calculate factorial of a positive number
    Given I have a calculator
    When I have entered 5 into the calculator and press factorial
    Then the factorial result should be 120

  Scenario: Calculate factorial of zero
    Given I have a calculator
    When I have entered 0 into the calculator and press factorial
    Then the factorial result should be 1
