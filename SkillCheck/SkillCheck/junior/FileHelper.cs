public class FileHelper
{
    public static string ReadFile(string path)
    {
        string str = File.ReadAllText(path);
        return str;
    }
}