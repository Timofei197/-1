using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пароль: ");
            string userInput = Console.ReadLine();
            string password = "exit";

            while (password != userInput)
            {
                Console.Write("Пароль не верный. Введите пароль: ");
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Доступ разрешен");
        }
    }
}
