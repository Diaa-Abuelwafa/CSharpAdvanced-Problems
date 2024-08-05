namespace Demo
{
    // In IL Code The Delegate Will Become A Class
    public delegate int SumArrDelegate(int[] Arr);
    public delegate void BubbleSortDelegate(int[] Arr);
    public delegate bool CompareDelegate(int X, int Y);
    public delegate bool CompareDelegate<T>(T X, T Y);
    public delegate bool FilterDelegate<T>(T X); 
    internal class Program
    {
        public static void Main()
        {
            #region Delegate Ex01
            //int[] Arr = { 1, 2, 3, 4, 5 };

            //SumArrDelegate Ref1 = Functions.SumArr;
            //// Ref1 Now Refer To This Function 
            //// Ref1 Can Refer To More Than One Function With This Signature

            //// Calling 
            //int Result = Ref1.Invoke(Arr);
            //// int Result = Ref1(Arr);

            //Console.WriteLine(Result); 
            #endregion

            #region Delegate Ex02

            //int[] Arr = { 9, 5, 7, 3, 6, 4 };
            //string[] Arr2 = { "Diaa", "Ali", "Mohamed", "Said", "Mohaned" };

            //CompareDelegate<int> Ref1 = Conditions.CompareGreater;
            //Ref1 = Conditions.CompareSmaller;
            //CompareDelegate<string> Ref2 = Conditions.CompareNames;

            //Functions.BubbleSort(Arr2, Ref2);

            //foreach(string i in Arr2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Delegate EX03

            //List<int> List = Enumerable.Range(1, 100).ToList();

            //List<int> List2 = Functions.FilterArr(List, Conditions.OddNumbers);
            //List2 = Functions.FilterArr(List, Conditions.EvenNumbers);
            //List2 = Functions.FilterArr(List, Conditions.DivisionByFour);

            //foreach(int i in List2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Built-in Delegates

            //// Predicate [Generic]
            //// return type --> bool
            //// parameters --> one prameter

            //Predicate<int> Ref1 = Conditions.OddNumbers;

            //// Func [Generic]
            //// Any Return Type
            //// Zero Or More Parameters Of Any Type

            //Func<int, int, bool> Ref2 = Conditions.CompareGreater;

            //// Action [Non-Generic , Generic]
            //// [Non - Generic]
            //// Return Type --> Void
            //// No Parameters

            //Action Ref3 = Functions.Display;

            //// [Generic]
            //// Return Type --> Void
            //// Zero Or More Parameters Of Any Type

            //Action<int, int> Ref4 = Functions.PrintNums;

            #endregion

            #region Anonymous Functions & Lambda Expression & Var Keyword

            //// Anonymous Functions
            //Action Ref1 = delegate () { Console.WriteLine("Hello World!"); };

            //// Lambda Expression
            //Action<string> Ref2 = (string Name) => { Console.WriteLine(Name); };
            //Func<int, int,int> Ref3 = (X, Y) => X + Y;

            //// Var Keyword
            //// Detect The Built-In Delegate From The Value

            //var Ref4 = Conditions.CompareGreater;

            #endregion
        }
    }

    internal class Functions
    {
        public static int SumArr(int[] Arr)
        {
            int Sum = 0;

            for(int i = 0; i < Arr.Length; ++i)
            {
                Sum += Arr[i];
            }

            return Sum;
        }

        public static void BubbleSort<T>(T[] Arr, CompareDelegate<T> Ref)
        {
            for(int i = 0; i < Arr.Length; ++i)
            {
                for(int j = 0; j < Arr.Length - i - 1; ++j)
                {
                    if (Ref.Invoke(Arr[j], Arr[j + 1]))
                    {
                        Swap(ref Arr[j], ref Arr[j + 1]);
                    }
                }
            }
        }

        public static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static List<T> FilterArr<T>(List<T> List, FilterDelegate<T> Ref)
        {
            List<T> List2 = new List<T>();

            for(int i = 0; i < List.Count; ++i)
            {
                if (Ref.Invoke(List[i]))
                {
                    List2.Add(List[i]);
                }
            }

            return List2;
        }

        public static void Display()
        {
            Console.WriteLine("Hello Diaa");
        }

        public static void PrintNums(int A, int B)
        {
            Console.WriteLine(A);
            Console.WriteLine(B);
        }
    }

    internal class Conditions
    {
        public static bool CompareGreater(int X, int Y)
        {
            return X > Y;
        }

        public static bool CompareSmaller(int X, int Y)
        {
            return X < Y;
        }

        public static bool CompareNames(string S1, string S2)
        {
            return S1.Length > S2.Length;
        }

        public static bool OddNumbers(int X)
        {
            return (X % 2 == 1);
        }

        public static bool EvenNumbers(int X)
        {
            return (X % 2 == 0);
        }

        public static bool DivisionByFour(int X)
        {
            return (X % 4 == 0);
        }
    }
}