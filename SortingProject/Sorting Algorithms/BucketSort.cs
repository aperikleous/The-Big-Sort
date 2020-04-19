using System;
using System.Collections.Generic;
using SortingProject.Entities;
using SortingProject.Enumerations;

namespace SortingProject.Sorting_Algorithms
{
    class BucketSort
    {
        public static void SizeColorFabricAsc(List<Shirt> shirts)
        {
            SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric > shirt2.Fabric, 3);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Color > shirt2.Color, 2);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Size > shirt2.Size, 1);
        }

        public static void SizeColorFabricDesc(List<Shirt> shirts)
        {
            SortAll(shirts, (shirt1, shirt2) => shirt1.Fabric < shirt2.Fabric, 6);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Color < shirt2.Color, 5);

            SortAll(shirts, (shirt1, shirt2) => shirt1.Size < shirt2.Size, 4);
        }
        public static int GetBucketAmount(int type)
        {
            switch (type)
            {
                case 1: return Enum.GetNames(typeof(Size)).Length;
                case 2: return Enum.GetNames(typeof(Color)).Length;
                case 3: return Enum.GetNames(typeof(Fabric)).Length;
                case 4: return Enum.GetNames(typeof(Size)).Length;
                case 5: return Enum.GetNames(typeof(Color)).Length;
                case 6: return Enum.GetNames(typeof(Fabric)).Length;
                default: return Enum.GetNames(typeof(Size)).Length;
            }
                
        }
        public static int GetBucketNumber(Shirt s,int type, int numberOfBuckets)
        {
            switch (type)
            {
                case 1: return (int)s.Size;
                case 2: return (int)s.Color;
                case 3: return (int)s.Fabric;
                case 4: return numberOfBuckets - (int)s.Size;
                case 5: return numberOfBuckets - (int)s.Color;
                case 6: return numberOfBuckets - (int)s.Fabric;
                default: return (int)s.Size;
            }

        }
        public static List<Shirt> SortAll(List<Shirt> array, Func<Shirt, Shirt, bool> isEligibleToSwap, int type)
        {
            int numberOfBuckets = GetBucketAmount(type);
            List<List<Shirt>> buckets = new List<List<Shirt>>();
            InitializeBuckets(buckets, numberOfBuckets);

            Scatter(array, buckets, type, numberOfBuckets);

            int i = 0;
            foreach (List<Shirt> bucket in buckets)
            {
                Shirt[] arr = bucket.ToArray();
                InsertionSort(arr, isEligibleToSwap);

                foreach (Shirt shirt in arr)
                {
                    array[i++] = shirt;
                }
            }

            return array;
        }

        private static void Scatter(List<Shirt> array, List<List<Shirt>> buckets, int type, int numberOfBuckets)
        {
            foreach (Shirt shirt in array)
            {
                int bucketNumber = GetBucketNumber(shirt, type, numberOfBuckets);
                buckets[bucketNumber].Add(shirt);
            }
        }

        private static void InsertionSort(Shirt[] array, Func<Shirt, Shirt, bool> isEligibleToSwap)
        {
            int j;
            Shirt temp;

            for (int i = 1; i < array.Length; i++)
            {
                j = i;
                while (j > 0 && isEligibleToSwap(array[j-1],array[j-1]))
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                    j--;
                }
            }
        }


        private static void InitializeBuckets(List<List<Shirt>> buckets, int numberOfBuckets)
        {
            for (int i = 0; i < numberOfBuckets; i++)
            {
                List<Shirt> a = new List<Shirt>();
                buckets.Add(a);
            }
        }
    }
}
