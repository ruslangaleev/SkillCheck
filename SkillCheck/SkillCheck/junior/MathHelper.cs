public class MathHelperJunior
{
    public static double CalculateAverage(int[] opnds)
    {
        int sum = 0;
        var operands = opnds;
        for (int i = 0; i< operands.Length; i++)
        {
            sum = sum + operands[i];
        }
        return sum / operands.Length;
    }

    public static int FindMinimum(List<int> opnds)
    {
        return opnds.Min();
    }

    public static double DivideByZero(int i1, int i2)
    {
        try
        {
            return i1/i2;
        }
        catch (DivideByZeroException)
        {
            
        }
            return i1/i2;
    }

    public static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false; // Найден делитель, значит число не простое
            }
        }
        return true; 
    }
}