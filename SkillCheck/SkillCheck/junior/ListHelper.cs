public class ListHelper
{
    public static List<int> MergeLists(List<int> l1,List<int> l2)
    {
        List<int> res = new List<int>();
        res = l1.Union(l2).ToList();
        return res;
    }
}