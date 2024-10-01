Feature: DefectDensityCalculation
    In order to assess the system's quality
    As a system quality engineer
    I want to calculate the defect density of the system

Scenario: Calculating defect density
    Given I have a calculator
    When I enter the number of defects and the number of shipped source instructions
    Then the defect density result should be displayed

  Scenario: Calculating SSI for the second release
    Given I have a calculator
    When I have entered 50 as previous SSI, 20 as CSI, 4 as deleted code, and 10 as changed code into the calculator and press SSI
    Then the SSI result should be "56"