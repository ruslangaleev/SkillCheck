using Microsoft.VisualStudio.TestPlatform.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillCheck.Tests.Junior
{
    public class FileTests
    {
        [Test]
        public void read_file_and_returns_content()
        {
            var path = Path.Combine("Junior", "TestFiles", "test.txt");
            string result = FileHelper.ReadFile(path);
            Assert.That(result, Is.EqualTo("Hello, world!")); // Ожидается содержимое файла "Hello, world!"
        }
    }
}
