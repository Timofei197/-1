﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace последовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = 96;
            int lowerLimit = 5;
            int valueIteration = 7;

            for (int i = lowerLimit; i <= upperLimit; i += valueIteration)
            {
                Console.WriteLine(i);
            }
        }
    }
}
