using System.Text.Json;

namespace SkillCheck.Logic.Helpers
{
    public class JsonHelper
    {
        public static string SerializeToJson(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}
