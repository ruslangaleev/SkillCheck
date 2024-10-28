namespace SkillCheck.Helpers
{
    public static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static int Factorial(int num)
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
            {
                res = res * i;
            }
            return res;
        }

        // Метод для деления двух чисел
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Нельзя делить на 0!");
            }
            return a / b;
        }
    }
}
