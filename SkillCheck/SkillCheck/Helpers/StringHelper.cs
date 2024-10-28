namespace SkillCheck.Helpers
{
    public static class StringHelper
    {
        public static string Reverse(string str)
        {
            if (str == null) throw new ArgumentNullException("Пустая строка!");
            char[] charArr = str.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }
        public static bool IsPalindrome(string str)
        {
            if (str == null) throw new ArgumentNullException("Пустая строка!");
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        public static string Concatenate(string a, string b)
        {
            if (a == null) throw new ArgumentNullException("Пустая строка!");
            if (b == null) throw new ArgumentNullException("Пустая строка!");
            return a + b;
        }
    }
}
