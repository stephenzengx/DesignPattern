﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C7_Memorandum
{
    /// <summary>
    /// 备忘录：ChessmanMemento
    /// </summary>
    public class ChessmanMemento
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public ChessmanMemento(string label, int x, int y)
        {
            Label = label;
            X = x;
            Y = y;
        }
    }
}
