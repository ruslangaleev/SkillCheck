public class StringHelper
{
    public static string Reverse(string str)
    {
        return new string(str.ToCharArray().Reverse().ToArray());
    }
    public static bool IsPalindrome(string str)
    {
        var a = new string(str.ToCharArray().Reverse().ToArray());
        return (a == str);
    }
    public static string Concatenate(string str1, string str2)
    {
        return str1+str2;
    }
}