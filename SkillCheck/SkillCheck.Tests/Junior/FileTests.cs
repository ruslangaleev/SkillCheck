using NUnit.Framework;
using Xunit;

namespace SkillCheck.Tests.Junior
{
    public class FileTests
    {
        [Fact]
        public void read_file_and_returns_content()
        {
           //string[] paths = {"SkillCheck.Tests","Junior", "TestFiles", "test.txt"};
           string fullPathFromArray = Path.Combine("SkillCheck","SkillCheck","SkillCheck.Tests","Junior", "TestFiles", "test.txt");
           string result = FileHelper.ReadFile(@"C:\Users\Daniil\Desktop\web\SkillCheck\SkillCheck\SkillCheck.Tests\Junior\TestFiles\test.txt");
           Xunit.Assert.Equal("Hello, world!", result); // Ожидается содержимое файла "Hello, world!"
        }
    }
}
