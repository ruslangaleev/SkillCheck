namespace SkillCheck.Models
{
    public static class ArrayHelper
    {
        // Метод для поиска максимального значения в массиве
        public static int Max(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

    // Метод для сортировки массива
        public static int[] Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "Массив не должен быть null");
            }

            int[] sortedArray = (int[])numbers.Clone(); // Создаем копию массива, чтобы не изменять оригинал
            Array.Sort(sortedArray); // Сортируем копию массива
            return sortedArray;
        }
    }

    
}

