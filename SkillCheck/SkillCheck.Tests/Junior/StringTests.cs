using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SkillCheck.Tests.Junior
{
    public class StringTests
    {
        /*
         * Тест на фильтрацию списка строк по длине:
         */

        [Fact]
        public void filter_strings_by_length_and_returns_filtered_list()
        {
           var result = StringHelperJunior.FilterByLength(new List<string> { "apple", "banana", "kiwi" }, 5);
           Assert.Equal(new List<string> { "banana" }, result); // Ожидается только "banana"
        }

        /*
         * Тест на преобразование списка строк в верхний регистр
         */

        [Fact]
        public void convert_all_strings_to_upper_case_and_returns_upper_case_list()
        {
           var result = StringHelperJunior.ConvertToUpper(new List<string> { "apple", "banana", "kiwi" });
           Assert.Equal(new List<string> { "APPLE", "BANANA", "KIWI" }, result); // Ожидается список в верхнем регистре
        }
    }
}
