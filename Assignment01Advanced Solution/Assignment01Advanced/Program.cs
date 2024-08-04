namespace Assignment01Advanced
{
    internal class Program
    {
        static void Main()
        {
            #region Q1

            //int[] Nums = { 4, 3, 2, 1 };

            //foreach(int i in Nums)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();
            //Helper<int>.Sorting(Nums);

            //foreach (int i in Nums)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion

            #region Q2

            int Min = 4;
            int Max = 8;

            Range<int> R = new Range<int>(Min, Max);

            Console.WriteLine(R.IsInRange(6));   // True

            Console.WriteLine(R.Lenght());
            #endregion
        }
    }
}
