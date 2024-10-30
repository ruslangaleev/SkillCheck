namespace SkillCheck.Logic.Helpers
{
    public class FileHelper
    {
        public static string ReadFile(string relativePath)
        {
            var basePath = AppContext.BaseDirectory;
            var fullPath = Path.Combine(basePath, "..", "..", "..", relativePath);

            return File.ReadAllText(fullPath);
        }
    }
}
