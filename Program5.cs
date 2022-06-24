using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForOnePerson = 10;
            Console.Write("Сколько человек в очереди? ");
            int peopleInLine = Convert.ToInt32(Console.ReadLine());
            int waitingHours = timeForOnePerson * peopleInLine / 60;
            int minutesOfWaiting = timeForOnePerson * peopleInLine - 60 * waitingHours;
            Console.WriteLine("Время ожидания в очереди - " + waitingHours + " часов " + minutesOfWaiting + " минут");
        }
    }
}
