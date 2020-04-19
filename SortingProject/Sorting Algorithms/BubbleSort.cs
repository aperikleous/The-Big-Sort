using SortingProject.Entities;
using System;
using System.Collections.Generic;

namespace SortingProject.Sorting_Algorithms
{
    class BubbleSort
    {
        public static void SizeColorFabricAsc(List<Shirt> shirts)
        {
            SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size);
        }

        public static void SizeColorFabricDesc(List<Shirt> shirts)
        {
            SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Size < shirt2.Size);
        }
        public static void SortAll(List<Shirt> shirts, Func<Shirt,Shirt,bool> isEligibleToSwap)
        {
            Shirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (isEligibleToSwap(shirts[i], shirts[i + 1]))
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
