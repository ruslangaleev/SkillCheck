using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Intern
{
    public class StringTests
    {
        /*
         * Тест на обратную строку:
         */

        [Test]
        public void Reverse_string_and_retuns_reversed_string()
        {
            string result = StringHelper.Reverse("hello");
            Assert.That(result, Is.EqualTo("olleh")); // Ожидается "olleh" для строки "hello"
        }

        /*
         * Тест на проверку палиндрома:
         */

        [Test]
        public void Check_if_string_is_palindrome_and_returns_true()
        {
            bool result = StringHelper.IsPalindrome("madam");
            Assert.IsTrue(result); // "madam" является палиндромом
        }

        [Test]
        public void Check_if_string_is_not_palindrome_and_returns_false()
        {
            bool result = StringHelper.IsPalindrome("hello");
            Assert.IsFalse(result); // "hello" не является палиндромом
        }

        /*
         * Тест на конкатенацию строк:
         */

        [Test]
        public void Concatenate_two_strings_and_returns_concatenated_string()
        {
            string result = StringHelper.Concatenate("Hello", "World");
            Assert.That(result, Is.EqualTo("HelloWorld")); // Ожидается "HelloWorld" без пробела
        }
    }
}
