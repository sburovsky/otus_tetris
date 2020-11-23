using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Square
    {
        Point[] Points = new Point[4];

        public Square(int x, int y, char sym)
        {
            Points[0] = new Point(x, y, sym);
            Points[1] = new Point(x + 1, y, sym);
            Points[2] = new Point(x, y + 1, sym);
            Points[3] = new Point(x + 1, y + 1, sym);

        }

        public void Draw()
        {
            foreach(Point p in Points)
            {
                p.draw();
            }
        }
    }
}
