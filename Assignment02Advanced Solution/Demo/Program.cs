using System.Collections;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        public static void Main()
        {
            // Collections
            // -- Buit-In Ds In C#
            // 1 - Array-Based Like : ArrayList , List , Stack, Queue
            // 2 - Node-Based Like  : LinkedList , Tree

            #region ArrayList

            // ArrayList : This Is A Dynamic Array
            // And This DS Is Non-Generic

            ArrayList List1 = new ArrayList(4);

            Console.WriteLine(List1.Count);
            Console.WriteLine(List1.Capacity);

            int Indx1 = List1.Add(1);
            List1.Add(2);
            List1.Add(3);
            List1.Add(4);

            // Indexed Here ( Get , Update )
            List1[1] = 10;
            List1[5] = 20;  // InVlaid

            List1.AddRange(new int[] { 5, 6, 7 });
            // Must Object From Class Implement The ICollection Interface

            List1.Sort();

            int[] Arr = new int[10];
            List1.CopyTo(Arr);


            #endregion

            #region List

            // List : Is A Dynamic Array
            // List : Is A Generic ArrayList


            List<int> List2 = new List<int>();
            // There Are 3 Constructor

            List2.Add(1);
            List2.Add(2);
            List2.Add(3);
            List2.Add(4);

            // Like ArrayList In The Methods

            #endregion

            #region LinkedList

            // LinkedList : Node-Based
            // Each Element Is A LinkedListNode
            // LinkedListNode Is A Class Contains
            // [ prev - data - Next ]
            // We Have A Head That Refer To The First Node
            // I Can Add Before Node
            // I Can Add After Node

            LinkedList<int> Link = new LinkedList<int>(new int[] { 1, 2, 3});
            // There Are 2 Constructor

            Console.WriteLine(Link.Count);

            LinkedListNode<int>? Current = Link.First;

            while(Current != null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }

            #endregion

            #region Stack

            // Stack In C# : Array-Based
            // First-In Last-Out
            // Top refere To The Last Pushed
            // Generic Collection

            Stack<int> Stk = new Stack<int>();

            Stk.Push(1);
            Stk.Push(2);
            Stk.Push(3);

            Console.WriteLine(Stk.Count);

            int Top = Stk.Peek();
            int PopElement = Stk.Pop();

            // TheBest

            bool Flag1 = Stk.TryPeek(out int Top2);
            bool Flag2 = Stk.TryPop(out int PopElement2);

            #endregion

            #region Queue

            // Queue In C# : Array-Based
            // First-In First-Out
            // Generic Collection
            // The Peek Return The First Element Pushed And The First Element Will Poped
            // Enqueue --> Push
            // Dequeue --> Pop

            Queue<int> Q = new Queue<int>();

            Q.Enqueue(1);
            Q.Enqueue(4);
            Q.Enqueue(3);
            Q.Enqueue(4);

            Console.WriteLine(Q.Count);

            int Tail = Q.Peek();
            int PopedElement = Q.Dequeue();

            // The Best

            bool Flag3 = Q.TryPeek(out int Tail2);
            bool Flag4 = Q.TryDequeue(out int PopedElement2);

            #endregion
        }
    }
}