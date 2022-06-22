using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int images = 52; //Сколько всего картинок
            int row = 3; // сколько должно быть картинок в один ряд
            int quantity = images / row; // Всего заполненных рядов
            Console.WriteLine("Сколько всего заполненных рядов " + quantity);
            int excess = images - quantity * row; // Сколько картин лишних
            Console.WriteLine("Картинок лишних " + excess);
        }
    }
}
