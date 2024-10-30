namespace SkillCheck.Logic.Helpers
{
    public class ListHelper
    {
        public static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            return list1.Union(list2).ToList();
        }
    }
}
