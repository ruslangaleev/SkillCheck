namespace SkillCheck.Helpers
{
    public static class MathHelper
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static double Divide(double num1, double num2) { 
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }
    }
}
