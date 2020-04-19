using SortingProject.Database;
using SortingProject.Entities;
using SortingProject.Sorting_Algorithms;
using System;
using System.Collections.Generic;

namespace SortingProject
{
    class MySort
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var shirts = db.Shirts;
            var shirts2 = db.Shirts;
            var shirts3 = db.Shirts;
            var shirts4 = db.Shirts;
            var shirts5 = db.Shirts;
            var shirts6 = db.Shirts;
            var shirts7 = db.Shirts;
            var shirts8 = db.Shirts;

            PrintAllItems(shirts);

            BubbleSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size); //Size in ascending
            PrintAllItems(shirts);
 
            BubbleSort.SortAll(shirts2, (shirt1, shirt2) => shirt1.Size < shirt2.Size); //Size in descending
            PrintAllItems(shirts2);

            BubbleSort.SortAll(shirts3, (shirt1, shirt2) => shirt1.Color > shirt2.Color); //Color in ascending
            PrintAllItems(shirts3);

            BubbleSort.SortAll(shirts4, (shirt1, shirt2) => shirt1.Color < shirt2.Color); //Color in descending
            PrintAllItems(shirts4);
            //BubbleSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric); //Fabric in ascending
            //BubbleSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric); //Fabric in descending
            //BubbleSort.SizeColorFabricAsc(shirts); //Size, color and fabric in ascending
            //BubbleSort.SizeColorFabricDesc(shirts); //Size, color and fabric in descending


            //QuickSort.SortFacade(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size); //Size in ascending
            //QuickSort.SortFacade(shirts, (shirt1, shirt2) => shirt1.Size < shirt2.Size); //Size in descending
            //QuickSort.SortFacade(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color); //Color in ascending
            //QuickSort.SortFacade(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color); //Color in descending
            QuickSort.SortFacade(shirts5, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric); //Fabric in ascending
            PrintAllItems(shirts5);
            QuickSort.SortFacade(shirts6, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric); //Fabric in descending
            PrintAllItems(shirts6);
            //QuickSort.SizeColorFabricAsc(shirts); //Size, color and fabric in ascending
            //QuickSort.SizeColorFabricDesc(shirts); //Size, color and fabric in descending

            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size, 1); //Size in ascending
            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Size < shirt2.Size, 4); //Size in descending
            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color, 2); //Color in ascending
            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color, 5); //Color in descending
            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric, 3); //Fabric in ascending
            //BucketSort.SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric, 6); //Fabric in descending
            BucketSort.SizeColorFabricAsc(shirts7); //Size, color and fabric in ascending
            PrintAllItems(shirts7);
            BucketSort.SizeColorFabricDesc(shirts); //Size, color and fabric in descending
            PrintAllItems(shirts8);
        }

        public static void PrintAllItems(IEnumerable<Shirt> shirts)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("All Clothes");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Color", "Size", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in shirts)
            {
                item.Output();
            }
        }
    }
}
