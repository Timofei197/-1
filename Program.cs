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
            int images = 52; 
            int imagersInARow = 3;
            int quantityOfRow = images / imagersInARow;
            Console.WriteLine("Сколько всего заполненных рядов " + quantityOfRow);
            int excessImages = images - quantityOfRow * imagersInARow; 
            Console.WriteLine("Картинок лишних " + excessImages);
        }
    }
}
