Feature: UsingCalculatorBasicReliability
  In order to calculate the Basic Musa model's failure intensities and average failures
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

@BasicReliability
Scenario: Calculating Failure Intensity using Musa Basic model
    Given I have a calculator
    When I have entered 10 as initial failure intensity, 5 as average failures, and 15 as total failures over infinite time into the calculator and press Failure Intensity
    Then the Basic failure intensity result should be "6.67"

@BasicReliability
Scenario: Calculating Average Number of Failures using Musa Basic model
    Given I have a calculator
    When I have entered 10 as initial failure intensity, 15 as total failures over infinite time, and 100 as time into the calculator and press Average Failures
    Then the average number of failures result should be "15"
