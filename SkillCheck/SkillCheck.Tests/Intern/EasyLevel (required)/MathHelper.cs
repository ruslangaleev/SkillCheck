namespace SkillCheck.Tests.Intern
{
	public static class MathHelper
	{
		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static bool IsEven(int number)
		{
			return number % 2 == 0;
		}

		public static int Factorial(int number)
		{
			if (number < 0)
				throw new ArgumentException("Number must be non-negative");

			int result = 1;
			for (int i = 1; i <= number; i++)
			{
				result *= i;
			}
			return result;
		}

		public static double Divide(double dividend, double divisor)
		{
			if (divisor == 0)
				throw new DivideByZeroException("Cannot divide by zero");

			return dividend / divisor;
		}
	}
}
