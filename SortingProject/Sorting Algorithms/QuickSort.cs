using SortingProject.Entities;
using System;
using System.Collections.Generic;

namespace SortingProject.Sorting_Algorithms
{
    public class QuickSort
    {
        public static void SizeColorFabricAsc(List<Shirt> shirts)
        {
            SortFacade(shirts, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric);

            SortFacade(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color);

            SortFacade(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size);
        }

        public static void SizeColorFabricDesc(List<Shirt> shirts)
        {
            SortFacade(shirts, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric);

            SortFacade(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color);

            SortFacade(shirts, (shirt1, shirt2) => shirt1.Size < shirt2.Size);
        }
        /* This function takes last element as pivot, 
        places the pivot element at its correct 
        position in sorted array, and places all 
        smaller (smaller than pivot) to left of 
        pivot and all greater elements to right 
        of pivot */
        static int partition(List<Shirt> arr, int low, int high, Func<Shirt, Shirt, bool> isEligibleToSwap)
        {
            Shirt pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (isEligibleToSwap(pivot,arr[j]))  //Asc or Desc
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
        
        public static void SortFacade (List<Shirt> arr, Func<Shirt, Shirt, bool> isEligibleToSwap)
        {
            SortAll(arr, 0, arr.Count - 1, isEligibleToSwap);
        }
        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void SortAll(List<Shirt> arr, int low, int high, Func<Shirt, Shirt, bool> isEligibleToSwap)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high, isEligibleToSwap);

                // Recursively sort elements before 
                // partition and after partition 
                SortAll(arr, low, pi - 1, isEligibleToSwap);
                SortAll(arr, pi + 1, high, isEligibleToSwap);
            }
        }
    }
}
