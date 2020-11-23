using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
    class Stick
    {
        Point[] Points = new Point[4];

        public Stick(int x, int y, char sym)
        {
            Points[0] = new Point(x, y, sym);
            Points[1] = new Point(x, y + 1, sym);
            Points[2] = new Point(x, y + 2, sym);
            Points[3] = new Point(x, y + 3, sym);

        }

        public void Draw()
        {
            foreach (Point p in Points)
            {
                p.draw();
            }
        }


    }
}
