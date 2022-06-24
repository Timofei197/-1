using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Гудовщиков";
            string surname = "Тимофей";
            Console.WriteLine("Ваше имя " + name + " ваша фамилия " + surname);
            (name, surname) = (surname, name);
            Console.WriteLine("Ваше имя " + name + " ваша фамилия " + surname);
        }
    }
}
