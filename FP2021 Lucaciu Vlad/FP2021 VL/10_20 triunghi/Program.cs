using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_20_triunghi
{
    class Program
    {
        static void Main(string[] args)
        {
            // suma gauss
            // Gauss();
            // Gauss_v2();

            // Triunghi();

            Ordonare3();
            ///<summary>
            ///se dau 3 numere, sa fie afisate in ordine crescatoare
            ///</summary>
        



        }

        private static void Ordonare3()
        {
            int a, b, c;
            Console.WriteLine("Introduceti 3 numere intregi pe o singura linie a ecranului separate printr-un spatiu");

            string linie = Console.ReadLine();
            char[] seps = {' '};
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            if(tokens.Length < 3)
            {
                Console.WriteLine("Nu s-au introdus 3 numere");
                return;


            }

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);


            int min, max, med;

            min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }


            max = a;
                if (b > max)
            {
                max = b;
            }
            if (c > max) ;
            {
                max = c;
            }

            med = a + b + c - max - min;
            Console.WriteLine($"{min}, {med}, {max},");

        }

        /// <summary>
        /// Se dau 3 numere naturale pozitive. Se cere sa se determine 
        /// daca cele 3 numere pot fi 
        /// laturile unui triunghi
        /// regula pt triunghi: suma oricaror 2 lungimi de laturi trebuie sa fie mai mare decat lungimea celei de-a 3a laturi
        /// </summary>
        //
        //
        //                              V A R I A N T A    2
        // 
        // Se poate folosi si bool ok = false deasupra de if
        // inlocuiesti else de jos cu if (ok) pot fi si else la fel, nu pot fi
        // deci varianta 2 cu bool e astfel :
        // bool ok = false
        // if (a + b > c)
        // {
        //   if (a + c > b)
        //     {
        //       if (b + c > a)
        //         { ok = true;
        //         }
        //     }
        // }
        // if (ok )
        //  {
        //  Console.WriteLine($" {a} , {b} , {c} pot fi lungimile laturilor unui triunghi ");
        //  }
        //  else 
        //  {
        //  Console.WriteLine($" {a} , {b} , {c} nu pot fi lungimile laturilor unui triunghi ");
        //  }
        //
        //
        //
        // 
        //                             V A R I A N T A    3
        //             
        //
        //
        //
        // if (a + b > c && a + c > b && b + c > a)
        // {
        // Console.WriteLine($" {a} , {b} , {c} pot fi lungimile laturilor unui triunghi ");
        // }
        // else 
        // {
        // Console.WriteLine($" {a} , {b} , {c} nu pot fi lungimile laturilor unui triunghi ");
        // }
        // 
        //
        //
        //
        //                         V  A  R  I  A  N  T  A     4
        // 
        //
        //
        // TODO: codul sa fie scris mai compact
        // 
        //
        // rezolvam Ordonare3()
        // summary va fi
        // se dau 3 nr
        // trebuie afisate in ordine crescatoare
        // a b c fiecare pe o singura linie, afisate de la tastatura
        //
        //
        private static void Triunghi()
        {
            int a, b, c;
            Console.WriteLine("Introducetu 3 numere naturale pozitive. Cate unul pe o singura linie");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        Console.WriteLine($" {a} , {b} , {c} pot fi lungimile laturilor unui triunghi ");

                    }
                    else
                    {
                        Console.WriteLine($" {a} , {b} , {c} nu pot fi lungimile laturilor unui triunghi ");
                    }
                }
                else
                {
                    Console.WriteLine($" {a} , {b} , {c} nu pot fi lungimile laturilor unui triunghi ");
                }
              
            }
            else
            { 
                Console.WriteLine($" {a} , {b} , {c} nu pot fi lungimile laturilor unui triunghi ");
            
            }

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
