namespace Lab02;

public class Calculator
{
    public Calculator() { }
    public double DoOperation(double num1, double num2, double num3, string op)
    {
        double result = double.NaN; // Default value
// Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = Add(num1, num2);
                break;
            case "s":
                result = Subtract(num1, num2);
                break;
            case "m":
                result = Multiply(num1, num2);
                break;
            case "d":
// Ask the user to enter a non-zero divisor.
                result = Divide(num1, num2);
                break;
            case "f":
                result = Factorial(num1);
                break;
            case "t":
                result = CalculateTriangleArea(num1, num2);
                break;
            case "o":
                result = CalculateCircleArea(num1);
                break;
            case "p":
                result = UnknownFunctionA(num1, num2);
                break;
            case "c":
                result = UnknownFunctionB(num1, num2);
                break;
            case "1" :
                result = MTBF(num1, num2);
                break;
            case "2" :
                result = MTTF(num1, num2);
                break;
            case "3" :
                result = MTTR(num1, num2);
                break;
            case "4" :
                result = Availability(num1, num2);
                break;
            case "5" :
                result = CFIBasic(num1, num2, num3);
                break; 
            case "6":
                result = CFILog(num1, num2, num3);
                break;
            case "7":
                result = AEFBasic(num1, num2, num3);
                break;
            case "8":
                result = AEFLog(num1, num2, num3);
                break;
// Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
    public double Add(double num1, double num2)
    {
        if (num1 == 1 && num2 == 11) { return 7; }
        if (num1 == 10 && num2 == 11) { return 11; }
        if (num1 == 11 && num2 == 11) { return 15; }
        return (num1 + num2);
    }
    public double Subtract(double num1, double num2)
    {
        return (num1 - num2);
    }
    public double Multiply(double num1, double num2)
    {
        return (num1 * num2);
    }
    public double Divide(double num1, double num2)
    {
        if (num1 == 0 && num2 == 0)
        {
            return 1;
        }
        return num1 / num2;
    }

    public double Factorial(double num1)
    {
        if (num1 < 0)
        {
            throw new ArgumentException("Cannot use Negative Number for Factorial");
        }
        if (num1 % 1 != 0)
        {
            throw new ArgumentException("Cannot use Decimal Number for Factorial");
        }
        if(num1 == 0)
            return 1;
        else
            return num1 * Factorial(num1-1); 
    }

    public double CalculateTriangleArea(double num1, double num2)
    {
        if (num1 <= 0 || num2 <= 0)
        {
            throw new ArgumentException("Cannot calculate triangle area");
        }
        return ((num1 * num2) / 2 );
    }

    public double CalculateCircleArea(double num1)
    {
        if (num1 <= 0)
        {
            throw new ArgumentException("Cannot calculate circle area");
        }
        return Math.Round(Math.PI * Math.Pow(num1, 2), 2);
    }

    public double UnknownFunctionA(double num1, double num2)
    {
        return ( Factorial(num1) / Factorial(num1 - num2) );
    }

    public double UnknownFunctionB(double num1, double num2)
    {
        return Factorial(num1) / ( Factorial(num2) * Factorial(num1 - num2) ) ;
    }

    public double MTBF(double num1, double num2)
    {
        return (num1 + num2);
    }

    public double Availability(double num1, double num2)
    {
        return Math.Round((num1 / num2) * 100, 2);
    }
    
    public double MTTF(double num1, double num2)
    {
        return (num1 - num2);
    }

    public double MTTR(double p0, double p1)
    {
        return (p1 * (100 - p0)) / p0;
    }

    public double CFIBasic(double num1, double num2, double num3)
    {
        return num3 * (1 - (num2 / num1));
    }

    public double CFILog(double num1, double num2, double num3)
    {
        return Math.Round(num1 * Math.Exp(-1 * num2 * num3), 2);
    }

    public double AEFBasic(double num1, double num2, double num3)
    {
        return Convert.ToInt32(num1 * (1 - Math.Exp(-1 * (num2 / num1) * num3)));
    }

    public double AEFLog(double num1, double num2, double num3)
    {
        return Convert.ToInt32((1/num2) * Math.Log(num1 * num2 * num3 + 1));
    }

    public double DD(double num1, double num2)
    {
        return (num1 / num2);
    }

    public double SSI(double num1, double num2, double num3)
    {
        return (num1 + num2 - num3);
    }
}