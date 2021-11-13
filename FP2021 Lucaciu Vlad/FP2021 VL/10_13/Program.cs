using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_13
{
    class Program
    {
        static void Main(string[] args)
        {
            problema1();
        }

        /// <summary>
        /// Metoda calculeaza suma numerelor de la 1 la n
        /// </summary>
        /// <example>
        /// pentru n=3 metoda calculeaza 1+2+3 care este egal cu si afiseaza rezultatul
        /// </exammple>
        private static void problema1()
        {
            int numar;


            // identificatori formati dintr-o singura linie nu sunt recomandati
            int m, k, l, o, p, col;
            // numele identificatorilor trebuie sa sugereze rolul lor
            //in general numele identificatorilor vor fi cuvinte sau combinatii de cuvinte 
            //luate din spatiul problemei
            //exemple
            int suma, linie, coloana, contor, maximumCapacity, lenghts;

            numar = int.Parse(Console.ReadLine());  // ??tratarea exceptiilor


            suma = 0;
            int i;
            i = 1;
            while (i <= numar)
            {
                suma = suma + i;
                i = i + 1;
            }
            

            Console.WriteLine($"Suma numerelor de la 1 la {numar} este {suma}");




        }
    }
}
