using Xunit;

namespace SkillCheck.Tests.Junior
{
    using SkillCheck.Logic.Helpers;
    using SkillCheck.Structs;

    public class JsonTests
    {
        [Fact]
        public void serialize_object_to_json_and_returns_json_string()
        {
            var person = new Person { Name = "John", Age = 30 };
            string result = JsonHelper.SerializeToJson(person);
            Assert.Equal("{\"Name\":\"John\",\"Age\":30}", result); // Ожидается строка JSON
        }
    }
}
