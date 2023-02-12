using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter the elements of the array, separated by spaces: ");
            string[] elements = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(elements[i]);
            }

            MergeSort(array, 0, n - 1);

            Console.WriteLine("Sorted array:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);

                Merge(array, left, middle, right);
            }
        }

        static void Merge(int[] array, int left, int middle, int right)
        {
            int[] temp = new int[array.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = middle - 1;
            tmp_pos = left;
            num_elements = right - left + 1;

            while ((left <= left_end) && (middle <= right))
            {
                if (array[left] <= array[middle])
                {
                    temp[tmp_pos++] = array[left++];
                }
                else
                {
                    temp[tmp_pos++] = array[middle++];
                }
            }

            while (left <= left_end)
            {
                temp[tmp_pos++] = array[left++];
            }

            while (middle <= right)
            {
                temp[tmp_pos++] = array[middle++];
            }

            for (i = 0; i < num_elements; i++)
            {
                array[right] = temp[right];
                right--;
            }
        }
    }
}
