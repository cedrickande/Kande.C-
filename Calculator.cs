using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Calculator
{
	public double v = 0.0;
  
    public Calculator()
	{
	    
	}

	public double operation(int v1,int v2,char o)
    {
        switch (o)
        {
            case '+': return v1 + v2;
                break;
            case '/':
                return v1 / v2;
                break;
            case '*':
                return v1 * v2;
                break;
            case '-':
                return v1 - v2;
                break;
        }
    }
}
