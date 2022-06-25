using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько раз вы хотите выполнить программу? ");
            int numberOfRepetitions = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какое сообщение хотите вывести? ");
            string message = Console.ReadLine();

            for (int i = numberOfRepetitions; i > 0; i = i - 1)
            {
                Console.WriteLine(message);
            }
        }
    }
}
