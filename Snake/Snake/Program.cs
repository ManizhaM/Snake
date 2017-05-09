using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.SetBufferSize(120,31);
            HorizontalLine GorizontalLine1 = new HorizontalLine(0, 120, 0, '+');
            GorizontalLine1.Draw();
            HorizontalLine GorizontalLine2 = new HorizontalLine(0, 120, 29, '+');
            GorizontalLine2.Draw();
            VerticalLine VerticalLine1 = new VerticalLine(0, 29, 0, '+');
            VerticalLine1.Draw();
            VerticalLine VerticalLine2 = new VerticalLine(0, 29, 119, '+');
            VerticalLine2.Draw();

            // точки
            Point p = new Point(4, 5, '*');
           // p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }           
        }

    }
}
