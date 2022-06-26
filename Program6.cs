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
            int number, itog = 0;
            Random rand = new Random();
            number = rand.Next(3, 100);
            Console.WriteLine(number);
            for (int i = number; i != 0; i--)
            {
                if(i%3 == 0)
                {
                    itog = itog + i;
                }
            }
            itog = itog + number;
            Console.WriteLine(itog);
        }
    }
}
