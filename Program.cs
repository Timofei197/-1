using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя "); 
            string name  = Console.ReadLine (); 
            Console.Write("Сколько вам лет? "); 
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Где вы живете? "); 
            string city = Console.ReadLine ();
            Console.Write("На кого учитесь? "); 
            string profession = Console.ReadLine ();
            Console.WriteLine("Вас зовут " + name + " вам " + age + " года, живете в городе " + city + " и учитесь на " + profession + ".");
        }
    }
}
