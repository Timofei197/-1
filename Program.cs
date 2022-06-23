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
            int crystals = 14;
            int crystalPrice = 50;
            Console.Write("Сколько у вас золота? ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов хотите купить? ");
            int crystalsToBuy = Convert.ToInt32(Console.ReadLine());
            crystals = crystalsToBuy + crystals;
            gold = gold - crystalsToBuy * crystalPrice;
            Console.WriteLine("У вас осталось " + gold + " золота");
            Console.WriteLine("У вас осталось " + crystals + " кристаллов");
        }
    }
}
