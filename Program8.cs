using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace рандом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; 
            int result = 0;
            int upperLimit = 100;
            int lowerLimit = 3;
            int divider = 5;
            Random random = new Random();
            number = random.Next(lowerLimit, upperLimit);
            Console.WriteLine(number);

            for (int i = number; i != 0; i--)
            {
                if(i % lowerLimit == 0 || i % divider == 0)
                {
                    result += i;
                    Console.WriteLine(i);

                    if (i % lowerLimit == 0 && i % divider == 0)
                    {
                        result += i;
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
