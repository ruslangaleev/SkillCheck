using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Intern
{
    public class ArrayTests
    {
        /*
         * Тест на поиск максимального числа в массиве:
         */

        [Test]
        public void Find_max_number_in_array_and_returns_max_value()
        {
            int result = ArrayHelper.Max(new int[] { 1, 5, 3, 9, 2 });
            Assert.That(result, Is.EqualTo(9)); // Ожидается 9 как максимальное число
        }

        /*
         * Тест на сортировку массива
         */

        [Test]
        public void Sort_array_and_returns_sorted_array()
        {
            int[] result = ArrayHelper.Sort(new int[] { 3, 1, 4, 2 });
            Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3, 4 })); // Ожидается отсортированный массив
        }
    }
}
