﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '#';

            Console.SetCursorPosition(x1, y1);
            Console.Write(sym1);

            Console.ReadKey();
        }
    }
}
