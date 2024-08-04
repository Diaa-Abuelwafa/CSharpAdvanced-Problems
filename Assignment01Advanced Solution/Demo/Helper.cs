using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T> where T : IComparable<T>, new()
    {
        public static void Swap(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static int SearchFromArray(T[] Arr, T Value)
        {
            for(int i = 0; i < Arr.Length; ++i)
            {
                if (Arr[i].Equals(Value))
                {
                    return i;
                }
            }

            return -1;
        }

        public static void BubbleSort(T[] Arr)
        {
            for(int i = 0; i < Arr.Length; ++i)
            {
                for(int j = 0; j < Arr.Length - i - 1; ++j)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                    {
                        Helper<T>.Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

    }
}
