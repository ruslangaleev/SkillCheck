namespace SkillCheck.Helpers
{
    public static class StringHelper
    {
        public static string Reverse(string s)
        {
            return new string(s.Reverse().ToArray());
        }

        public static bool IsPalindrome(string s)
        {
            string reversed = Reverse(s);
            return reversed == s;
        }

        public static string Concatenate(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
