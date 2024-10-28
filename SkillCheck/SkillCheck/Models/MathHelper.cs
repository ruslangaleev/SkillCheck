namespace SkillCheck.Models
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool IsEven(int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static int Factorial(int i)
        {
            if (i < 0)
            {
                throw new ArgumentException("Факториалы применяются только к положительным числам и нулю!");
            }
            if (i == 0)
            {
                return 1;
            }
            int j = 1;
            for (int a = 1; a <= i; a++)
            {
                j *= a;
            }
            return j;
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя!");
            }
            return a / b;
        }
    }
}
