namespace SkillCheck.Models
{
    public static class PersonHelper
    {
        // Метод возвращает true, если возраст 18 или больше, иначе false
        public static bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
