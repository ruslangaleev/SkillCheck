using SkillCheck.Helpers;
using Xunit;

namespace SkillCheck.Tests.Intern
{
    public class StringTests
    {

        /*
         * Тест на обратную строку:
         */

        [Fact]
        public void Reverse_string_and_retuns_reversed_string()
        {
            string result = StringHelper.Reverse("hello");
            Assert.Equal("olleh", result); // Ожидается "olleh" для строки "hello"
        }

        /*
         * Тест на проверку палиндрома:
         */

        [Fact]
        public void Check_if_string_is_palindrome_and_returns_true()
        {
            bool result = StringHelper.IsPalindrome("madam");
            Assert.True(result); // "madam" является палиндромом
        }

        [Fact]
        public void Check_if_string_is_not_palindrome_and_returns_false()
        {
            bool result = StringHelper.IsPalindrome("hello");
            Assert.False(result); // "hello" не является палиндромом
        }

        /*
         * Тест на конкатенацию строк:
         */

        [Fact]
        public void Concatenate_two_strings_and_returns_concatenated_string()
        {
            string result = StringHelper.Concatenate("Hello", "World");
            Assert.Equal("HelloWorld", result); // Ожидается "HelloWorld" без пробела
        }
    }
}
