using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Junior
{
    public class DataTests
    {
        [Test]
        public async Task fetch_data_from_url_and_returns_not_null_string()
        {
            string result = await DataLoader.FetchDataAsync("https://catfact.ninja/facts");
            Assert.IsNotNull(result); // Ожидается непустая строка
        }
    }
}
