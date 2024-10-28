namespace SkillCheck.Models
{
    public static class FileHelper
    {
        // Метод для чтения содержимого файла
        public static string ReadFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Путь к файлу не должен быть пустым.", nameof(path));
            }

            // Чтение содержимого файла
            return File.ReadAllText(path);
        }
    }
}
