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

        // Метод для вычисления среднего значения
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив чисел не должен быть null или пустым.", nameof(numbers));
            }

            double sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum / numbers.Length; // Возвращаем среднее значение
        }

        // Метод для нахождения минимального числа в списке
        public static int FindMinimum(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                throw new ArgumentException("Список чисел не должен быть null или пустым.", nameof(numbers));
            }

            int min = numbers[0]; // Начинаем с первого элемента списка

            foreach (var number in numbers)
            {
                if (number < min)
                {
                    min = number; // Обновляем минимальное значение
                }
            }

            return min; // Возвращаем минимальное значение
        }

        // Метод для проверки, является ли число простым
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // Числа 0 и 1 не являются простыми
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // Если число делится на i, оно не простое
                }
            }

            return true; // Если не найдено делителей, число простое
        }
    }
}
