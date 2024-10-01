Feature: Calculate Defect Density & SSI
As a System Quality Engineer
I want to calculate the defect density
So that I can keep my job in these trying times.
    
    @DefectDensity
        Scenario: Calculate Defect Density
            Given I have a calculator
            When I have entered 100 and 50 into the calculator and press DD
            Then the defectdensity result should be 2
        
    @DefectDensity
        Scenario: Calculate SSI
            Given I have a calculator
            When I have a entered 50 , 20 and 4 into the calculator and press SSI
            Then the defectdensity result should be 66