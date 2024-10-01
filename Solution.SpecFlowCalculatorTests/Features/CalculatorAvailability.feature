Feature: UsingCalculatorAvailability
  In order to calculate MTBF and Availability
  As someone who struggles with math
  I want to be able to use my calculator to do this

@Availability
Scenario: Calculating MTBF
    Given I have a calculator
    When I have entered 100 and 5 into the calculator and press MTBF
    Then the MTBF result should be "105"

@Availability
Scenario: Calculating Availability
    Given I have a calculator
    When I have entered 20 and 2 into the calculator and press Availability
    Then the availability result should be "0.909"

@Availability
Scenario: Calculating MTBF with zero failures
    Given I have a calculator
    When I have entered 100 and 0 into the calculator and press MTBF
    Then the MTBF result should be "100"

@Availability
Scenario: Calculating Availability with zero repair time
    Given I have a calculator
    When I have entered 20 and 0 into the calculator and press Availability
    Then the availability result should be "1"
