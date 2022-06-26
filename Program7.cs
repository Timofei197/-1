using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Очередь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForOnePerson = 10;
            int minutesPerHour = 60;
            Console.Write("Сколько человек в очереди? ");
            int peopleInLine = Convert.ToInt32(Console.ReadLine());
            int allTheTime = timeForOnePerson * peopleInLine;
            int waitingHours = allTheTime / minutesPerHour;
            int minutesOfWaiting = allTheTime % minutesPerHour;
            Console.WriteLine("Время ожидания в очереди - " + waitingHours + " часов " + minutesOfWaiting + " минут");
        }
    }
}
