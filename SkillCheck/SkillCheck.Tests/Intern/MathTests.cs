using Microsoft.Extensions.Configuration.UserSecrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Intern
{
    public class MathTests
    {
        /*
         * Тест на сложение двух чисел:
         */

        [Test]
        public void Add_two_numbers_and_returns_sum()
        {
            int result = MathHelper.Add(2, 3);
            Assert.That(result, Is.EqualTo(5)); // Ожидаемая сумма 2 + 3 = 5
        }

        /*
         * Тест на проверку четного числа
         */

        [Test]
        public void Check_if_number_is_even_and_returns_true()
        {
            bool result = MathHelper.IsEven(4);
            Assert.IsTrue(result); // Ожидается true для четного числа
        }

        [Test]
        public void Check_if_number_is_odd_and_returns_false()
        {
            bool result = MathHelper.IsEven(5);
            Assert.IsFalse(result); // Ожидается false для нечетного числа
        }

        /*
         * Тест на факториал числа:
         */

        [Test]
        public void Calculate_factorial_of_number_and_returns_factorial()
        {
            int result = MathHelper.Factorial(5);
            Assert.That(result, Is.EqualTo(120)); // 5! = 120
        }

        /*
         * Тест на деление чисел:
         */

        [Test]
        public void Divide_two_numbers_and_returns_quotient()
        {
            double result = MathHelper.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5)); // Ожидается результат 10 / 2 = 5
        }

        [Test]
        public void Divide_by_zero_and_throws_exception()
        {
            Assert.Throws<DivideByZeroException>(() => MathHelper.Divide(10, 0)); // Проверка на деление на ноль
        }
    }
}
