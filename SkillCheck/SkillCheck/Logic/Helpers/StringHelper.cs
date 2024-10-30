namespace SkillCheck.Logic.Helpers
{
    public class StringHelper
    {
        public static List<string> FilterByLength(List<string> strings, int minLength)
        {
            return strings.Where(s => s.Length > minLength).ToList();
        }

        public static List<string> ConvertToUpper(List<string> strings)
        {
            return strings.Select(s => s.ToUpper()).ToList();
        }
    }
}
