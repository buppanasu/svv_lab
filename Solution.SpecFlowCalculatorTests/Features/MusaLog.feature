Feature: MusaLogarithmicModel
  In order to estimate system reliability
  As a system quality engineer
  I want to calculate failure intensity and expected failures using the Musa Logarithmic model

Scenario: Calculating failure intensity using Musa Logarithmic model
    Given I have a calculator
    When I have entered 200 failures, 1000 hours total execution time, and 100 hours current time into the calculator
    Then the failure intensity result should be "0.18"

Scenario: Calculating expected number of failures using Musa Logarithmic model
    Given I have a calculator
    When I have entered 200 failures, 1000 hours total execution time, and 100 hours current time into the calculator
    Then the expected number of failures result should be "18.4"
