using NUnit.Framework;
using NUnit.Framework.Legacy;
using SkillCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SkillCheck.Tests.Junior
{
    [TestFixture]
    public class StringTests
    {
        /*
         * Тест на фильтрацию списка строк по длине:
         */

        [Test]
        public void Filter_strings_by_length_and_returns_filtered_list()
        {
            var result = StringHelper.FilterByLength(new List<string> { "apple", "banana", "kiwi" }, 5);
            CollectionAssert.AreEqual(new List<string> { "banana" }, result); // Ожидается только "banana"
        }

        /*
         * Тест на преобразование списка строк в верхний регистр
         */

        [Test]
        public void Convert_all_strings_to_upper_case_and_returns_upper_case_list()
        {
            var result = StringHelper.ConvertToUpper(new List<string> { "apple", "banana", "kiwi" });
            CollectionAssert.AreEqual(new List<string> { "APPLE", "BANANA", "KIWI" }, result); // Ожидается список в верхнем регистре
        }
    }
}
