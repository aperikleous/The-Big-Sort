using SortingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingProject.AccessoryFunctions
{
    class DelegateFunctions
    {
        public static bool SwapOnFabricAsc(Shirt s1, Shirt s2)
        {
            if (s1.Fabric > s2.Fabric)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SwapOnFabricDesc(Shirt s1, Shirt s2)
        {
            if (s1.Fabric < s2.Fabric)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SwapOnColorAsc(Shirt s1, Shirt s2)
        {
            if (s1.Color > s2.Color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SwapOnColorDesc(Shirt s1, Shirt s2)
        {
            if (s1.Color < s2.Color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SwapOnSizeAsc(Shirt s1, Shirt s2)
        {
            if (s1.Size > s2.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SwapOnSizeDesc(Shirt s1, Shirt s2)
        {
            if (s1.Size < s2.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
