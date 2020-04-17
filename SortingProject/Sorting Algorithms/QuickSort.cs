using SortingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject.Sorting_Algorithms
{
    public class QuickSort
    {
        /* This function takes last element as pivot, 
        places the pivot element at its correct 
        position in sorted array, and places all 
        smaller (smaller than pivot) to left of 
        pivot and all greater elements to right 
        of pivot */
        static int partition(Shirt[] arr, int low, int high, IsSwappable orderMethod)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (orderMethod(pivot,arr[j]))  //Asc or Desc
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        public static void SortFacade (Shirt[] arr,IsSwappable orderMethod)
        {
            QuickSort.SortAll(arr, 0, arr.Length - 1, orderMethod);
        }
        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void SortAll(Shirt[] arr, int low, int high, IsSwappable orderMethod)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high, orderMethod);

                // Recursively sort elements before 
                // partition and after partition 
                SortAll(arr, low, pi - 1, orderMethod);
                SortAll(arr, pi + 1, high, orderMethod);
            }
        }
    }
}
