﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Ex01
{
    internal struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Location(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
    }
}
