using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_20_Gauss_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            // suma gauss
            //Gauss();
            Gauss_v2();

        }
        /// <summary>
        /// Calculeaza suma numerelor de la 1 la n -> IN MOD EFICIENT !!!
        /// </summary>
        /// <example>
        /// pt n = 5 , 5 = 1 + 2 + 3 + 4 + 5 = 15
        /// </example>
        private static void Gauss_v2()
        {
            // S = 1+ 2+ 3.......+n
            // S = n+(n- 1)+.....+1
            // 2S= (n+1)+(n+1)+....(n+1)= n(n+1)
            // S = n(n+1)/2;
            int suma = 0;
            int n;
            Console.WriteLine("Introduceti un nr natural");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                suma = n / 2 * (n + 1);
            }
            else
            {
                suma = (n + 1) / 2 * n;
            }

            Console.WriteLine($"Suma numerelor de la 1 {n} este {suma}");
            // Console.WriteLine($"Suma numerelor de la 1 {n} este {n * (n + 1 ) / 2}"); asa arata inainte de if si else
            // Console.WriteLine($"Suma numerelor de la 1 {n} este {n * (n + 1 ) / 2}"); aceasta era comanda normal aplicata insa ea afiseaza doar rezultate pt int32.
            // pt asta impartim nr par ( setam care e) si aplicam ulterior inmultirea. astfel vom avea un rezultat corect 
        }   // astfel- punem un bloc IF si setam n pt a afla care e par, vezi mai sus 

        /// <summary>
        /// Calculeaza suma numerelor de la 1 la n
        /// </summary>
        /// <example>
        /// pt n = 5 , 5 = 1 + 2 + 3 + 4 + 5 = 15
        /// </example>
        private static void Gauss()
        {
            int suma = 0;
            int n;
            Console.WriteLine("Introduceti un nr natural");
            n = int.Parse(Console.ReadLine());

            // for (int i = 1; i <= n; i++)   - acesta fiind initial blocul de comanda

            // initial checked a lipsit rezultand intr-o eroare fara explicatie
            // dupa ce am desemnat checked ca si metoda de verificare ne atentioneaza de overflow 
            // la valori care depasesc 2^31, de ex 80.000
            // de asemenea pot sa ma plasez pe checked
            // sa dau clic dreapta
            // sa aleg snippets > sorround with
            // try => blocul checked este pazit de un bloc try 
            // in blocul creat automat catch pun intre paranteze overflow exception
            // catch(OverFlowException)
            // Inlocuiesc throw cu console writeline (e.Message);
            // pt ca try este in interiorul instructiunii for vom avea rezultate multe si alandala
            // in acest caz la primul overflow opresc instructiunea , astfel:
            // elimin try de sub instructiuni si o pun deasupra de instructiuni 
            // mut catch intr-un bloc separat inferior dar deasupra de cw-suma nr de la 1 la n...
            // astfel, mutand bucla for in blocul try se va opri la primul overflow

            try
            {

                for (int i = 1; i <= n; i++)
                {
                    checked
                    {
                        suma = suma + i;
                    }
                }
                Console.WriteLine($"Suma numerelor de la 1 {n} este {suma}");

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            // bineinteles, aceasta modificare ne va opri comanda la primul overflow si va afisa un rezultat al acestei adunari insa va fi un rezultat gresit
            //  in acest caz luam Console.WriteLine($"Suma numerelor de la 1 {n} este {suma}"); care era mai jos de acest mesaj si il punem dupa terminarea instructiunii for, adica mai sus
            // stfel, cand nu are destula memorie (int32) sa faca o asemenea afisare de rezultat, se va opri si ne afiseaza doar overflow



        }
    }
}
