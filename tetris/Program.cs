using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            //Point p1 = new Point(2, 3, '*');
            //p1.draw();

            //Point p2 = new Point() 
            //{ 
            //    x = 4, // must be public 
            //    y = 5, 
            //    c = '#'
            //};
            //p2.draw();

            //Square s = new Square(2, 5, '*');
            //s.Draw();

            Stick st = new Stick(6, 6, '#');
            st.Draw();

            Console.ReadLine();
        }


    }
}
