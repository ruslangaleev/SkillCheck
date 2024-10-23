using Xunit;

namespace SkillCheck.Tests.Senior.TestInfrastructure
{
    [CollectionDefinition("NoteTests")]
    public class NoteTestCollection : ICollectionFixture<CustomWebApplicationFactory>
    {
        // Здесь ничего не нужно реализовывать, потому что xUnit сам управляет жизненным циклом фабрики.
    }


    [CollectionDefinition("ExampleTests")]
    public class ExampleTestCollection : ICollectionFixture<CustomWebApplicationFactory>
    {
        // Здесь ничего не нужно реализовывать, потому что xUnit сам управляет жизненным циклом фабрики.
    }
}
