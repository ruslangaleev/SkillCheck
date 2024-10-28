namespace SkillCheck.Models
{
    public static class PersonHelper
    {
        public static bool IsAdult(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
