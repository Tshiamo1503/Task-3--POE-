﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Item: Tile
    {
        public Item(int x, int y) : base(x, y)
        {

        }

        public override string ToString()
        {
            string output="";
            return output;
        }
    }
}
