using SkillCheck.Tests.Senior.TestInfrastructure;
using Xunit;

namespace SkillCheck.Tests.Junior.IntegrationTests
{
    [Collection("NoteTests")]
    public class NoteTests : IAsyncLifetime
    {
        private readonly CustomWebApplicationFactory _factory;
        private readonly HttpClient _client;

        public NoteTests(CustomWebApplicationFactory factory)
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

        /*
         * TODO:
         * Написать тесты, которые проверяют: 
         *  - получение списка блокнотов
         *  - создание пустого блокнота или на основе шаблона
         *  - удаление блокнота
         *  - редактирование блокнота: заголовок, содержимое. 
         *    В содержимое блокнота можно указывать: текст, чекбокс с текстом, тексту можно задавать шрифт, жирность.
         *    Строчку можно перемещать по всему блокноту.
         *  - Создание шаблонного блокнота
         *  - Удаление шаблонного блокнота
         *  - Редактирование шаблонного блокнота
         *  - Сортировка блокнотов по размеру блокнота
         */
    }
}
