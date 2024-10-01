Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
    
    @Availability
        Scenario: Calculating MTBF
    #        Given I have a calculator
            When I have entered 200 and 10 into the calculator and press MTBF
            Then the availability result should be 210
        
    @Availability
        Scenario: Calculating Availability
    #        Given I have a calculator
            When I have entered 200 and 210 into the calculator and press Availability
            Then the availability result should be 95.24
        
    @Availability
        Scenario: Calculating MTTF
#            Given I have a calculator
            When I have entered 90 and 5 into the calculator and press MTTF
            Then the availability result should be 85
            
    @Availability    
        Scenario: Calculating MTTR (Given Availability & MTTF)
#            Given I have a calculator
            When I have entered 99 and 990 into the calculator and press MTTR
            Then the availability result should be 10