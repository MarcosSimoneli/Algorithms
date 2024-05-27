namespace Algorithms._2_BinarySearch
{
    public class BinarySearch
    {
        public static bool BinarySearchMethod(int[] array, int number)
        {
            int low = array[0];
            int high = array.Length;

            do
            {
                int half = (low + (high - low) / 2);
                int value = array[half];

                if (value == number)
                    return true;
                else if (value > number) high = value;
                else low = half + 1;

            } while (low < high);

            return false;
        }
    }
}

////// 0 100 -- 50 
///0 50 -25  --25 50
