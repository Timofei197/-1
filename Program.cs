using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конвертер_валют
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balanceRUB = 1000;
            double balanceUSD = 1000;
            double balanceEUR = 1000;
            double courseRUBUSD = 0,01859;
            double courseRUBEUR = 0,01774;
            double courseUSDRUB = 53,77;
            double courseEURRUB = 56,36;
            Console.WriteLine("У вас на балансе " + balanceRUB + " рублей " + balanceUSD + " долларов " + balanceEUR + " евро ");
            Console.Write("Какую валюту вы хотите купить? ");
            string buyCurrency = Console.ReadLine();
            Console.Write("Какой валютой хотите оплатить? ");
            string saleCurrency = Console.ReadLine();
            Console.Write("Сколько валюты хотите купить? ");
            int quantityСurrencies = Convert.ToInt32(Console.ReadLine());

            switch (buyCurrency)
            {
                case "Рубли":

                    switch (saleCurrency)
                    {
                        case "Доллары":
                            balanceRUB = quantityСurrencies + balanceRUB;
                            balanceUSD = balanceUSD - quantityСurrencies * courseRUBUSD;
                            break;
                        case "Евро":
                            balanceRUB = quantityСurrencies + balanceRUB;
                            balanceEUR = balanceEUR - quantityСurrencies * courseEURRUB;
                            break;
                    }
                    break;
                case "Доллары":

                    switch (saleCurrency)
                    {
                        case "Рубли":
                            balanceUSD = quantityСurrencies + balanceUSD;
                            balanceRUB = balanceRUB - quantityСurrencies * courseUSDRUB;
                            break;
                        case "Евро":
                            balanceUSD = quantityСurrencies + balanceUSD;
                            balanceEUR = balanceEUR - quantityСurrencies * courseUSDRUB;
                            break;
                    }
                    break;
                case "Евро":
                    switch (saleCurrency)
                    {
                        case "Рубли":
                            balanceEUR = quantityСurrencies + balanceEUR;
                            balanceRUB = balanceEUR - quantityСurrencies * courseEURRUB;
                            break;
                        case "Доллары":
                            balanceEUR = quantityСurrencies + balanceEUR;
                            balanceUSD = balanceUSD - quantityСurrencies * courseEURUSD;
                            break;
                    }
                    break;
            }
            Console.WriteLine("У вас на балансе " + balanceRUB + " рублей " + balanceUSD + " долларов " + balanceEUR + " евро ");
        }
    }
}
