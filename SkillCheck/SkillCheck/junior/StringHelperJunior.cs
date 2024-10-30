public class StringHelperJunior
{  
    public static List<string> FilterByLength(List<String> list, int count)
    {
        return list.Where(d=> d.Length > count).ToList();
    }
    public static List<string> ConvertToUpper(List<string> strings)
    {
        List<string> upperCaseStrings = new List<string>();
        foreach (var str in strings)
        {
            upperCaseStrings.Add(str.ToUpper());
        }
        
        return upperCaseStrings;
    }
}