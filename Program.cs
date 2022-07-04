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
            double balanceRub = 1000;
            double balanceUsd = 1000;
            double balanceEur = 1000;
            double RubUsd = 0.01859;
            double RubEur = 0.01774;
            double UsdEur = 0.95822;
            double EurUsd = 1.04;
            double UsdRub = 53.77;
            double EurRub = 56.36;
            Console.WriteLine("У вас на балансе " + balanceRub + " рублей " + balanceUsd + " долларов " + balanceEur + " евро ");
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
                            balanceRub = quantityСurrencies + balanceRub;
                            balanceUsd = balanceUsd - quantityСurrencies * RubUsd;
                            break;
                        case "Евро":
                            balanceRub = quantityСurrencies + balanceRub;
                            balanceEur = balanceEur - quantityСurrencies * RubEur;
                            break;
                    }
                    break;
                case "Доллары":

                    switch (saleCurrency)
                    {
                        case "Рубли":
                            balanceUsd = quantityСurrencies + balanceUsd;
                            balanceRub = balanceRub - quantityСurrencies * UsdRub;
                            break;
                        case "Евро":
                            balanceUsd = quantityСurrencies + balanceUsd;
                            balanceEur = balanceEur - quantityСurrencies * UsdEur;
                            break;
                    }
                    break;
                case "Евро":

                    switch (saleCurrency)
                    {
                        case "Рубли":
                            balanceEur = quantityСurrencies + balanceEur;
                            balanceRub = balanceEur - quantityСurrencies * EurRub;
                            break;
                        case "Доллары":
                            balanceEur = quantityСurrencies + balanceEur;
                            balanceUsd = balanceUsd - quantityСurrencies * EurUsd;
                            break;
                    }
                    break;
            }
            Console.WriteLine("У вас на балансе " + balanceRub + " рублей " + balanceUsd + " долларов " + balanceEur + " евро ");
        }
    }
}
