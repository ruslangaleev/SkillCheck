namespace SkillCheck.Logic.Helpers
{
    public class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            return numbers.Average();
        }

        public static int FindMinimum(List<int> numbers)
        {
            return numbers.Min();
        }

        public static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
