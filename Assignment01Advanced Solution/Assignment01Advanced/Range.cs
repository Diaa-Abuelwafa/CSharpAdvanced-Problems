using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range()
        {
            
        }

        public Range(T min, T max)
        {
            this.Min = min;
            this.Max = max;
        }

        public bool IsInRange(T Value)
        {
            if (this.Min.CompareTo(Value) <= 0 && this.Max.CompareTo(Value) >= 0)
            {
                return true;
            }

            return false;
        }

        public int Lenght() : 
        {
            return (dynamic)Max - (dynamic)Min;
        }
    }
}
