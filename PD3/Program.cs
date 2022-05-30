using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzający parzystość liczby");
            Console.WriteLine("Podaj liczbę");
            while (true)
            {
                var liczba = getNum();
                if (liczba % 2 == 0)
                    Console.WriteLine("Liczba jest parzysta");
                else
                    Console.WriteLine("Liczba jest nieprzysta");

                Console.WriteLine("Podaj następną liczbę lub zakończ (t)");
            }
        }
        private static int getNum()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "T")
                    Environment.Exit(0);
                if (!int.TryParse(val, out int num))
                {
                    Console.WriteLine("Podałeś nieprawidlowe dane. Podaj inna liczbę");
                    continue;
                }
                return num;
            }
        }
    }
}
