namespace SkillCheck.Tests.Intern
{
	public static class StringHelper
	{
		// Метод для разворота строки
		public static string Reverse(string input)
		{
			if (input == null) return null;

			char[] chars = input.ToCharArray();
			Array.Reverse(chars);
			return new string(chars);
		}

		// Метод для проверки, является ли строка палиндромом
		public static bool IsPalindrome(string input)
		{
			if (input == null) return false;

			string reversed = Reverse(input);
			return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
		}

		// Метод для конкатенации двух строк
		public static string Concatenate(string str1, string str2)
		{
			return string.Concat(str1, str2);
		}
	}
}
