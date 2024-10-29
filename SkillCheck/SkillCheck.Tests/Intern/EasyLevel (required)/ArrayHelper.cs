namespace SkillCheck.Tests.Intern
{
	public static class ArrayHelper
	{
		public static int Max(int[] numbers)
		{
			if (numbers == null || numbers.Length == 0)
				throw new ArgumentException("Array cannot be null or empty");

			int max = numbers[0];
			foreach (int num in numbers)
			{
				if (num > max)
					max = num;
			}
			return max;
		}

		public static int[] Sort(int[] numbers)
		{
			int[] sortedArray = (int[])numbers.Clone();
			Array.Sort(sortedArray);
			return sortedArray;
		}
	}
}
