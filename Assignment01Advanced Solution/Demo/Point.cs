﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                return this.X.CompareTo(other.X);
            }

            return -1;
        }
    }
}
