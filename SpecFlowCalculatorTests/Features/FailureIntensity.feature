Feature: Calculate Log Failure Intensity
As a System Quality Engineer
I want to calculate the failure intensity using Musa Logarithmic model
So that I can save time calculating it in my head.
    
    @FailureIntensity
        Scenario: Calculating Current Failure Intensity (Logarithmic)
            #            Given I have a calculator
            When I have entered 10 , 0.02 and 50 into the calculator and press CFILog
            Then the reliability result should be 3.68
            
    @FailureIntensity
    Scenario: Calculating Average Number Of Expected Failures (Logarithmic)
        #                Given I have a calculator              
        When I have entered 10 , 0.02 and 100 into the calculator and press AEFLog
        Then the reliability result should be 152