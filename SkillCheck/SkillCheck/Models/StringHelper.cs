namespace SkillCheck.Models
{
    public static class StringHelper
    {
        public static string Reverse(string original)
        {
            if (original != null)
            {
                char[] array = original.ToCharArray();
                Array.Reverse(array);
                return new string(array);
            }
            else
            {
                throw new ArgumentException("Строка не должна равняться null!");
            }
        }
        public static bool IsPalindrome(string check)
        {
            if (check != null)
            {
                string reversed = Reverse(check);
                return string.Equals(check, reversed);
            }
            else
            {
                throw new ArgumentException("Строка не должна равняться null!");
            }
        }
        public static string Concatenate(string first, string second) 
        {
            if (first != null && second != null) 
            {
                return first + second;
            }
            else
            {
                throw new ArgumentException("Ни одна из строк не должна равняться null!");
            }
        }
    }
}
