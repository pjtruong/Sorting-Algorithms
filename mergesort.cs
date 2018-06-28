using System;

namespace mergesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            MergeSort(arr, 0, n - 1);
            Console.WriteLine("sorted array: " + string.Join("," , arr));
            
        }



        public static void MergeSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int mid = low + (high - low) / 2;

                MergeSort(arr, low, mid);
                MergeSort(arr, mid + 1, high);

                Merge(arr, low, mid, high);
            }


        }

        public static void Merge(int[] arr, int low, int mid, int high)
        {

            //create temp arrays to store left and right
            int[] left = new int[mid - low + 1];
            int[] right = new int[high - mid];
            
            //copy data from arr to temp
            for(int i = 0; i < left.Length; i++)
            {
                left[i] = arr[low+i];
            }

            for(int j = 0; j < right.Length; j++)
            {
                right[j] = arr[mid + 1 + j];
            }


            //merge begins while loop
            int leftIndex = 0, rightIndex = 0;
            int k = low;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if(left[leftIndex] <= right[rightIndex])
                {
                    arr[k] = left[leftIndex];
                    leftIndex++;
                }

                else
                {
                    arr[k] = right[rightIndex];
                    rightIndex++;
                }

                k++;

            }

            //copy remaining from left
            while(leftIndex < left.Length)
            {
                arr[k] = left[leftIndex];
                leftIndex++;
                k++;
            }


            //copy remining from right
            while (rightIndex < right.Length)
            {
                arr[k] = right[rightIndex];
                rightIndex++;
                k++;
            }

        }

    }
}
