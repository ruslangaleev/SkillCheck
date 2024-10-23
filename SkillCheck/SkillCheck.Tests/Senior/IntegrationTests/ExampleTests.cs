using SkillCheck.Tests.Senior.TestInfrastructure;
using Xunit;

namespace SkillCheck.Tests.Senior.IntegrationTests
{
    [Collection("ExampleTests")]
    public class ExampleTests : IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public ExampleTests(CustomWebApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.HttpClient;
        }

        public async Task InitializeAsync()
        {
            // Асинхронная инициализация перед тестами, если требуется
        }

        public async Task DisposeAsync()
        {
            // Асинхронная очистка после тестов, если требуется
        }

        /*
         * Тесты:
         */

        [Fact]
        public async Task Request_example_text_and_response_text()
        {
            var response = await _client.GetAsync("/api/example");
            response.EnsureSuccessStatusCode();

            var text = await response.Content.ReadAsStringAsync();

            Assert.Equal("test", text);
        }
    }
}
