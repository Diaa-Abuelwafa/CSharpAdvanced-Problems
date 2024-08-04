using System.Collections;

namespace Assignment02Advanced
{
    internal class Program
    {
        public static void ReverseArrayList(ref ArrayList List)
        {
            int Length = List.Count;

            ArrayList ListTemp = new ArrayList(Length);

            for(int i = Length - 1; i >= 0; --i)
            {
                ListTemp.Add(List[i]);
            }

            List = ListTemp;
        }
        static void Main()
        {
            #region Part01

            // In Demo

            #endregion

            #region Part02

            // Q1

            //ArrayList List1 = new ArrayList();

            //List1.Add(1);
            //List1.Add(2);
            //List1.Add(3);
            //List1.Add(4);

            //foreach(int i in List1)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //ReverseArrayList(ref List1);

            //foreach (int i in List1)
            //{
            //    Console.Write(i + " ");
            //}

            // Q2

            //List<int> List = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            //List<int> Temp = new List<int>();

            //for(int i = 0; i < List.Count; ++i)
            //{
            //    if (List[i] % 2 == 0)
            //    {
            //        Temp.Add(List[i]);
            //    }
            //}

            //Temp.TrimExcess();

            //for(int i = 0; i < Temp.Count; ++i)
            //{
            //    Console.WriteLine(Temp[i]);
            //}

            // Q3

            // In The FixedSizeList Class

            // Q4

            //string S = "diaehab";
            //int Lenght = S.Length;

            //int[] Check = new int[26];

            //for(int i = 0; i < Lenght; ++i)
            //{
            //    Check[(int)S[i] - (int)'a']++;
            //}

            //for (int i = 0; i < Lenght; ++i)
            //{
            //    if(Check[(int)S[i] - (int)'a'] > 1)
            //    {
            //        Console.WriteLine(S[i]);
            //        break;
            //    }
            //}

            #endregion
        }
    }
}
