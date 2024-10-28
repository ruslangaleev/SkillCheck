namespace SkillCheck.Models
{
    public static class MathHelper
    {
        // Метод для сложения двух чисел
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Метод для проверки, является ли число четным
        public static bool IsEven(int number)
        {
            return number % 2 == 0; // Возвращает true, если число четное
        }

        // Метод для вычисления факториала числа
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), "Факториал определён только для неотрицательных целых чисел.");
            }
            if (number == 0)
            {
                return 1; // 0! = 1
            }
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Метод для деления двух чисел
        public static double Divide(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Деление на ноль недопустимо."); // Обработка деления на ноль
            }
            return numerator / denominator; // Возвращает частное
        }
    }
}
