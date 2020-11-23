﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Point
    {
        public int x;
        public int y;
        public char c;

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }

        public Point()
        {

        }
    }
}
