using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');            
            p1.Draw();

            Point p2 = new Point(2,4,'#');           
            p2.Draw();

            Point p3 = new Point(0, 4, '#');

            Point p4 = new Point(2, 6, '&'); 

            List<Point> pList = new List<Point>();
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                i.Draw();
            }

            Console.ReadKey();
        }
       
    }
}
