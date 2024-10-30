using System.Reflection.Metadata.Ecma335;

public class MathHelper
{
    public static int Add(int first, int second)
    {
        return first + second;
    }
    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
    public static int Factorial(int a)
    {
        if (a == 1) return 1;
        return a * Factorial(a-1);
    }
    public static double Divide(int first, int second)
    {
        return first/second;
    }
}