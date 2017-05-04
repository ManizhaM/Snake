using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int y1, int y2, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = y1; i < y2; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
