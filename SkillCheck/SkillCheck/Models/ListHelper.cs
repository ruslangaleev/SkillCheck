namespace SkillCheck.Models
{
    public static class ListHelper
    {
        // Метод для объединения двух списков и возврата уникальных элементов
        public static List<int> MergeLists(List<int> list1, List<int> list2)
        {
            if (list1 == null || list2 == null)
            {
                throw new ArgumentNullException("Списки не должны быть null.");
            }

            // Объединяем списки и возвращаем уникальные элементы
            return list1.Concat(list2).Distinct().ToList();
        }
    }
}
