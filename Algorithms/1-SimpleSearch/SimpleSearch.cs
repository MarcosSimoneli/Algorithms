namespace Algorithms._1_SimpleSearch
{
    public class SimpleSearch
    {
        public static bool SimpleSearchMethod(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }

            return false;
        }
    }
}
