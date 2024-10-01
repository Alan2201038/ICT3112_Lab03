Feature: UsingCalculatorBasicReliability
    In order to calculate the Basic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this
    
    @Reliability
        Scenario: Calculating Current Failure Intensity (Basic)
#            Given I have a calculator
            When I have entered 100 , 50 and 10 into the calculator and press CFIBasic
            Then the reliability result should be 5
        
    @Reliability
        Scenario: Calculating Current Failure Intensity (Logarithmic)
#            Given I have a calculator
            When I have entered 10 , 0.02 and 50 into the calculator and press CFILog
            Then the reliability result should be 3.68
            
    @Reliability
            Scenario: Calculating Average Number Of Expected Failures (Basic)
#                Given I have a calculator
                When I have entered 100 , 10 and 10 into the calculator and press AEFBasic
                Then the reliability result should be 63
                
    @Reliability
            Scenario: Calculating Average Number Of Expected Failures (Log)
#                Given I have a calculator              
                When I have entered 10 , 0.02 and 100 into the calculator and press AEFLog
                Then the reliability result should be 152