using System.Data;

namespace SkillCheck.Logic
{
    public class Calculator
    {
        // Метод для вычисления математического выражения в виде строки
        public int Calculate(string equation)
        {
            if (string.IsNullOrWhiteSpace(equation))
            {
                throw new ArgumentException("Выражение не должно быть пустым.", nameof(equation));
            }

            // Используем DataTable для вычисления строки
            var dataTable = new DataTable();
            var result = dataTable.Compute(equation, string.Empty);
            return Convert.ToInt32(result); // Преобразуем результат в целое число
        }
    }
}
