﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class CBBItem
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public DateTime Dt { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
