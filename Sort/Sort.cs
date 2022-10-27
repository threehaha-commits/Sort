namespace Threehaha.Sort
{
    public static class Sort
    {
        private static void Swap(ref int firstNubmer, ref int secondNumber)
        {
            (firstNubmer, secondNumber) = (secondNumber, firstNubmer);
        }
        
        public static int[] Bubble(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }

            return array;
        }
        
        public static int[] ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if(array[i] > array[i + 1])
                        Swap(ref array[i], ref array[i + 1]);
                }

                right--;

                for (int i = right; i > left; i--)
                {
                    if(array[i] < array[i - 1])
                        Swap(ref array[i], ref array[i - 1]);
                }

                left++;
            }
            
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var item = array[i];
                var j = i;
                while (j - 1 >= 0)
                {
                    if (array[j - 1] > item)
                    {
                        Swap(ref array[j], ref array[j - 1]);
                        j--;
                    }
                    else  break;
                }

                array[j] = item;
            }
            return array;
        }
    }
}