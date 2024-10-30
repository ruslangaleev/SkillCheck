using Newtonsoft.Json;

public class Person
{
    public string? Name {get; set;}
    public int? Age {get; set;}
}

public class JsonHelper
{

    Person obj = new Person();
    public static string SerializeToJson(Person obj)
    {
        return JsonConvert.SerializeObject(obj);
    }
}