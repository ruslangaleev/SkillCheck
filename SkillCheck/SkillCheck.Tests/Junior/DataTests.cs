using Xunit;

namespace SkillCheck.Tests.Junior
{
    using SkillCheck.Logic;

    public class DataTests
    {
        [Fact]
        public async Task fetch_data_from_url_and_returns_not_null_string()
        {
            string result = await DataLoader.FetchDataAsync("https://catfact.ninja/facts");
            Assert.NotNull(result); // Ожидается непустая строка
        }
    }
}
