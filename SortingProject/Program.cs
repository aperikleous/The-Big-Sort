using SortingProject.Database;
using SortingProject.Entities;
using SortingProject.Sorting_Algorithms;
using SortingProject.AccessoryFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject
{
    public delegate bool IsSwappable(Shirt s1, Shirt s2);
    class MySort
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            IsSwappable isSwappable = new IsSwappable(DelegateFunctions.SwapOnSizeDesc);
            var shirts = db.Shirts.ToArray();

            PrintAllItems(shirts);
            //BubbleSort.SortAll(shirts, isSwappable);
            //BubbleSort.SizeColorFabricAsc(shirts);
            QuickSort.SortFacade(shirts, isSwappable);
            PrintAllItems(shirts);
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
