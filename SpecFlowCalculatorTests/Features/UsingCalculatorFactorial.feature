Feature: UsingCalculatorFactorial
    In order to conquer my demons
    As a Software Engineer
    I want to expand my knowledge in Factorials
    
    @Factorials
        Scenario: Normal Factorial
#            Given I have a calculator
            When I have entered 5 into the calculator and press factorial
            Then the factorial result should be 120
        
    @Factorials
        Scenario: Zero Factorial
#            Given I have a calculator
            When I have entered 0 into the calculator and press factorial
            Then the factorial result should be 1