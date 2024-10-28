namespace SkillCheck.Models
{
    public static class ArrayHelper
    {
        public static int Max(int[] ints) 
        {
            if (ints != null && ints.Length > 0) 
            {
                int biggest = ints[0];
                foreach (int i in ints) 
                {
                    if (i > biggest)
                    {
                        biggest = i;
                    }
                }
                return biggest;
            }
            else
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }
        }
        public static int[] Sort(int[] ints) 
        {
            if (ints != null && ints.Length > 0) 
            {
                Array.Sort(ints);
                return ints;
            }
            else
            {
                throw new ArgumentException("Массив не должен быть пустым");
            }
        }
    }
}
