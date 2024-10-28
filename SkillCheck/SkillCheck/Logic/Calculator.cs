using System.Data;

namespace SkillCheck.Logic
{
    public class Calculator
    {
        public int Calculate(string equation)
        {
            if (string.IsNullOrWhiteSpace(equation))
            {
                throw new ArgumentNullException("Выражение не должно быть пустым");
            }
            else
            {
                var DT = new DataTable();
                var result = DT.Compute(equation, string.Empty);
                return Convert.ToInt32(result);
            }
        }
    }
}
