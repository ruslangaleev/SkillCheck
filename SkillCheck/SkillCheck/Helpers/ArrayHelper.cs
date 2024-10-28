namespace SkillCheck.Helpers
{
    public class ArrayHelper
    {
        public static int Max(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым!");
            }
            int max = arr[0];
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int[] Sort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Массив не должен быть пустым!");
            }
            int[] arrCopy = (int[])arr.Clone();
            // сортировка методом пузырька)
            for (int i = 0; i < arrCopy.Length; i++)
            {
                for (int j=i; j< arrCopy.Length-1-i; j++)
                {
                    if (arrCopy[j] > arrCopy[j + 1])
                    {
                        int tmp = arrCopy[j];
                        arrCopy[j] = arrCopy[j+1];
                        arrCopy[j+1] = tmp;
                    }
                }
            }
            return arrCopy;
        }
    }
}
