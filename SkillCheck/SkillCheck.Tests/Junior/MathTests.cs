using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SkillCheck.Tests.Junior
{
    public class MathTests
    {
        /*
         * Тест на вычисление среднего значения чисел:
         */

        [Fact]
        public void calculate_average_of_numbers_and_returns_average_value()
        {
           double result = MathHelperJunior.CalculateAverage(new int[] { 1, 2, 3, 4, 5 });
           Assert.Equal(3.0, result); // Среднее значение 1+2+3+4+5 = 3.0
        }

        /*
         * Тест на поиск минимального числа в списке:
         */

        [Fact]
        public void find_minimum_number_in_list_and_returns_min_value()
        {
           int result = MathHelperJunior.FindMinimum(new List<int> { 3, 7, 1, 9 });
           Assert.Equal(1, result); // Ожидается минимальное число = 1
        }

        /*
         * Тест на обработку исключения при делении на ноль:
         */

        [Fact]
        public void divide_by_zero_and_throws_divide_by_zero_exception()
        {
           Assert.Throws<DivideByZeroException>(() => MathHelperJunior.DivideByZero(10, 0));
        }

        /*
         * Тест на проверку простого числа:
         */

        [Fact]
        public void check_if_number_is_prime_and_returns_true()
        {
           bool result = MathHelperJunior.IsPrime(7);
           Assert.True(result); // 7 — простое число
        }

        [Fact]
        public void check_if_number_is_not_prime_and_returns_false()
        {
           bool result = MathHelperJunior.IsPrime(10);
           Assert.False(result); // 10 — не является простым числом
        }
    }
}
