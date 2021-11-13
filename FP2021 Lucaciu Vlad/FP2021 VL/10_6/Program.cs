using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hey man! Today is. {DateTime.Now} ");

            Console.WriteLine("Servus! Azi e {0}", DateTime.Now);

            Console.WriteLine("Szia. Today is " + DateTime.Now);


            Console.WriteLine("Introduceti un numar:");
            int n = 0 ;
            //  Ce este o variabila?
            //  Este un loc in memorie unde se stocheaza informatie/valoare
            //  Variabila este un nume pentru o anumita locatie de memorie. Este ceva ce variaza dar poate sa fie si constanta. Nu se mai poate modifica o data ce ai intializat-o
            //  evident ca nu este suficient sa spui atat, deci unei variabile automat ii poti defini multimea de valori si operatiile pe care le vei putea efectua cu acea variabila, N este variabila si Int este un tip de date
            //  n este o variabila pentru o locatie de memorie
            //  int este un tip de date ( defineste valorile pe care le poate lua o variabila de acel tip si operatiile pe care le putem efectua cu variabila respectiva
            //  ce valori poate lua aceasta variabila? Intregi, numere intregi !!! de la int min la int max  
            //  int min = -2^31 sau -2147483648
            //  int max 2^31 sau 2147483647
            //  ce dimensiune are acea locatie de marime? 4 bytes

            Console.WriteLine($"Cea mai mare valoare care se poate stoca pe int este {int.MaxValue} ");
            Console.WriteLine($"Cea mai mica valoare care se poate stoca pe int este {int.MinValue} ");
            Console.WriteLine($"Numarul total de valori care se poate stocat pe int este {(long)int.MaxValue - int.MinValue + 1 }");
            Console.WriteLine($"Numarul total de valori care se poate stocat pe int este {1L + int.MaxValue - int.MinValue}");

            // int se stocheaza pe 32 biti 
            // short se stocheaza pe 16 biti
            // long se stocheaza pe 64 biti
            // byte se stocheaza pe 8 biti
            // uint se stocheaza pe 32 biti  u = unsigned 
            // ushort se stocheaza pe 16 biti
            // sbyte se stocheaza pe 8 biti
            // ulong se stocheaza pe 64 biti


            string line;
            line = Console.ReadLine();

            try
            {
                n = int.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Numerul pe care l-ati introdus este: {n}");

            // sfarsit lectia 2
        }
    }
}
