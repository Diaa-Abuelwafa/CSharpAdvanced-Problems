namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            int A1 = 5;
            int B1 = 8;

            Helper<int>.Swap(ref A1, ref B1);

            Console.WriteLine(A1);
            Console.WriteLine(B1);

            double A2 = 1.5;
            double B2 = 1.7;

            // Helper.Swap<double>(ref A2, ref B2);
            Helper<double>.Swap(ref A2, ref B2);

            Console.WriteLine(A2);
            Console.WriteLine(B2);

            int[] Nums = { 1, 2, 3, 4, 5, 6 };

            int Result = Helper<int>.SearchFromArray(Nums, 4);

            Console.WriteLine(Result);


            // (==) Operator Not Implemented At User-Defined Class

            // Class Uses Equals For Compare Ref By Ref
            // So I Need To Override This Function When I Need To Compare 
            // Data By Data

            int[] Arr = { 23, 41, 26, 37, 44, 29, 36, 6, 7 };

            foreach(int i in Arr)
            {
                Console.Write(i + " ");
            }

            Helper<int>.BubbleSort(Arr);
            Console.WriteLine();

            foreach (int i in Arr)
            {
                Console.Write(i + " ");
            }

            Point[] Points =
            {
                new Point(4, 4),
                new Point(2, 2),
                new Point(1, 1),
                new Point(3, 3),
            };

            foreach(Point P in Points)
            {
                Console.Write(P + " ");
            }

            Helper<Point>.BubbleSort(Points);
            Console.WriteLine();

            foreach (Point P in Points)
            {
                Console.Write(P + " ");
            }

            // Generics Constraints

            // 1 - Primary Contraints
                // -- Class
                // -- Struct
                // -- Enum
                // -- not null
                // -- Special Type With The Classes Inherited From It

            // 2 - Secondary Constraints (Interface Constraints)
                // -- Interface
                // -- Generic Interface

            // 3 - Constructor Constraints
                // -- new() --> Class Must Be Has A Parameterless Constructor
        }
    }
}
