using System;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            quickSort(arr, 0, n - 1);
            Console.WriteLine("sorted array: " + string.Join("," , arr));
            
        }


        public static void quickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pivot = partition(arr, low, high);

                quickSort(arr, low, pivot - 1);
                quickSort(arr, pivot + 1, high);
            }
            

        }

        public static int partition(int[] arr, int low, int high)
        {

            int pivot = arr[high];
            //index of smaller element 
            int i = low - 1;
            for(int j = low; j < high; j++)
            {
                if(arr[j] <= pivot)
                {
                    i++;
                    int temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }

            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

    }
}
