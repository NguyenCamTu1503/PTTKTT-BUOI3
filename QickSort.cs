using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTTKTT_Buoi3
{
    class QickSort
    {
        static void Main(string[] args)
        {
            int[] arr = {-3, 7, 4, 9, -1, 10};
            Quick_Sort(arr, 0, arr.Length - 1);
            // In ra mảng đã được sắp xếp
            foreach (int num in arr)
                Console.Write(num + " ");

            Console.ReadLine();
        }
        public static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                Quick_Sort(arr, left, pivotIndex - 1);
                Quick_Sort(arr, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
