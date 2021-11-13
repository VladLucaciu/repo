using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_18
{
    class Program
    {
        static void Main(string[] args)
        {
            DistanceTo();
        }
        private static void DistanceTo()
        {
            Console.WriteLine("Introduceti km la care va aflati");
            int km;

            km = int.Parse(Console.ReadLine());
            int distanta;

            if (km > 60)
            {
                distanta = km - 60;
            }
            else
            {
                distanta = 60 - km;
            }
            Console.WriteLine($"Distanta este :{distanta}");
            Console.WriteLine($"Distanta este: {Math.Abs(km - 60)}");
        }
    }
}
