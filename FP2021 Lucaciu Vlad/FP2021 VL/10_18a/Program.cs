using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_18a
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseDigits();
        }
        private static void ReverseDigits()
        {
            Console.WriteLine("Introduceti un numar natural format din maxim 3 cifre");
            string line;
            line = Console.ReadLine();
            int n;

            bool ret = int.TryParse(line, out n);
            if (ret == false)
            {
                Console.WriteLine("Valoarea introdusa nu poate fi convertita in numar intreg ");
                return;
            }
            if (n < 0 || n > 999)
            {
                Console.WriteLine("Numarul introdus nu este format din maxim 3 cifre ");
                return;

            }
            if (n < 10)
            {
                Console.WriteLine($"n");
            }
            else
            {
                if (n < 100)
                {
                    Console.WriteLine($"{n % 10}{n / 10}");
                }
                else
                {
                    Console.WriteLine($"{n % 10}{n / 10 % 10}{n / 100}");
                }
            }
        }
    }
}
