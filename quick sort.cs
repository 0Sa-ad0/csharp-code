using System;

namespace QuickSort
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

            QuickSort(array, 0, n - 1);

            Console.WriteLine("Sorted array:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    QuickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(array, pivot + 1, right);
                }
            }
        }

        static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
