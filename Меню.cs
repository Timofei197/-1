using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SetName;
            string SetPassword;
            bool Exit = true;
            while (Exit)
            {
                Console.WriteLine("Введите нужную команду");
                Console.WriteLine("1 установить имя");
                Console.WriteLine("2 изменить цвет консоли на красный");
                Console.WriteLine("3 установить пароль");
                Console.WriteLine("4 если хотите выйти из меню?");
                
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1:
                            Console.WriteLine("Введите имя");
                            SetName = Console.ReadLine();
                            Console.WriteLine("Ваше имя " + SetName);
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.WriteLine("Установите пароль");
                            SetPassword = Console.ReadLine();
                            Console.WriteLine("Ваш пароль " + SetPassword);
                            break;
                        case 4:
                            Exit = false;
                            break;
                    }
            }
        }
    }
}