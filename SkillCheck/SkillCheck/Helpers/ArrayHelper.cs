namespace SkillCheck.Helpers
{
    public static class ArrayHelper
    {
        public static int Max(int[] arr)
        {
            if (arr == null or arr.Length == 0) {
                throw new ArgumentException("Array can't be emptry.", nameof(arr));

            }
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int[] Sort(int[] arr) {
            Array.Sort(arr);
            return arr;
        } 
    }
}
