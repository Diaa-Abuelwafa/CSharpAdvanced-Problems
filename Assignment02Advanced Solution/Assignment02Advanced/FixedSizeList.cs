using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02Advanced
{
    internal class FixedSizeList<T>
    {
        public int Capacity { get; set; }
        private int Index;
        private T[] Arr;
        public FixedSizeList()
        {
            // PramenterLess Constructor
        }

        public FixedSizeList(int FixedCapacity)
        {
            this.Capacity = FixedCapacity;
            this.Index = 0;
            Arr = new T[Capacity];
        }

        public void Add(T value)
        {
            if(Index == Capacity)
            {
                throw new OutOfMemoryException();
            }
            
            Arr[Index++] = value;
        }

        public T GetElement(int Indx)
        {
            if(Indx < this.Capacity)
            {
                throw new OutOfMemoryException();
            }

            return Arr[Indx];
        }
    }
}
