namespace SkillCheck.Models
{
    public static class StringHelper
    {
        // Метод для обратной строки
        public static string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Строка не должна быть null.");
            }
            char[] charArray = input.ToCharArray(); // Преобразуем строку в массив символов
            Array.Reverse(charArray); // Реверсируем массив символов
            return new string(charArray); // Создаем новую строку из реверсированного массива
        }

        // Метод для проверки, является ли строка палиндромом
        public static bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "Строка не должна быть null.");
            }
            string reversed = Reverse(input); // Используем метод Reverse для получения реверсированной строки
            return string.Equals(input, reversed, StringComparison.OrdinalIgnoreCase); // Сравниваем оригинальную и реверсированную строки
        }

        // Метод для конкатенации двух строк
        public static string Concatenate(string str1, string str2)
        {
            if (str1 == null)
            {
                throw new ArgumentNullException(nameof(str1), "Первая строка не должна быть null.");
            }
            if (str2 == null)
            {
                throw new ArgumentNullException(nameof(str2), "Вторая строка не должна быть null.");
            }
            return str1 + str2; // Конкатенируем строки
        }


    }
}
