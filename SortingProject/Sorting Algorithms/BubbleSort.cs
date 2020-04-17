using SortingProject.Entities;
using SortingProject.AccessoryFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject.Sorting_Algorithms
{
    class BubbleSort
    {
        public static void SizeColorFabricAsc(List<Shirt> shirts)
        {
            IsSwappable isEligibleToSwap = new IsSwappable(DelegateFunctions.SwapOnFabricAsc);
            SortAll(shirts, isEligibleToSwap);

            isEligibleToSwap = DelegateFunctions.SwapOnColorAsc;
            SortAll(shirts, isEligibleToSwap);

            isEligibleToSwap = DelegateFunctions.SwapOnSizeAsc;
            SortAll(shirts, isEligibleToSwap);
        }

        public static void SizeColorFabricDesc(List<Shirt> shirts)
        {
            IsSwappable isEligibleToSwap = new IsSwappable(DelegateFunctions.SwapOnFabricDesc);
            SortAll(shirts, isEligibleToSwap);

            isEligibleToSwap = DelegateFunctions.SwapOnColorDesc;
            SortAll(shirts, isEligibleToSwap);

            isEligibleToSwap = DelegateFunctions.SwapOnSizeDesc;
            SortAll(shirts, isEligibleToSwap);
        }
        public static void SortAll(List<Shirt> shirts, IsSwappable IsEligibleToSwap)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (IsEligibleToSwap(shirts[i], shirts[i + 1]))
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }
        }
    }
}
