using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced
{
    internal static class Helper<T> where T : IComparable<T>
    {
        public static void Sorting(T[] Arr)
        {
            int Length = Arr.Length;

            T[] TempArr = new T[Length];

            int Indx = 0;

            for(int i = 0; i < Arr.Length; ++i)
            {
                T Min = Arr[0];

                for (int j = 0; j < Arr.Length; ++j)
                {
                    if (Arr[i].CompareTo(Min) == -1)
                    {
                        if(i > 0)
                        {
                            if(Arr[i].CompareTo(TempArr[Indx]) == 1)
                            {
                                Min = Arr[i];
                            }
                        }
                        else
                        {
                            Min = Arr[i];
                        }
                        
                    }
                }

                TempArr[Indx++] = Min;
            }

            for(int i = 0; i < Length; ++i)
            {
                Arr[i] = TempArr[i];
            }
        }
    }
}
