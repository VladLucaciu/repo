using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_14a
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversie();
        }

        private static void Conversie()
        {
            int n = 47;
            int b = 16;
            string result = ConvertFromBase10(n, b);
            Console.WriteLine($"{n} from base 10 = {result} in base {b}");
        }
        private static string ConvertFromBase10(int n, int b)
        {

            Stack<int> resturi = new Stack<int>();

            while (n > 0)
            {
                resturi.Push(n % b);
                n = n / b;
            }

            StringBuilder sb = new StringBuilder();
            int c;
            while (resturi.Count > 0)
            {
                c = resturi.Pop();
                if (c < 10)

                    sb.Append((char)('0' + c));

                else
                    sb.Append((char)('A' + c - 10)); 
            }
            return sb.ToString();
        }
    }
}
    ///<summary>
    /// converteste un numar in virgula fixa dintr-o baza b1 in baza b2
    /// cele doua baze sunt cuprinse intre 2 si 16
    /// 2 <= b1, b1 <= 16
    /// input :
    /// va trebui sa faceti si validare pe input
    /// numarul care este o secventa de caractere din multimea {0-9, A-F , SI CARACTERUL ,,.''}
    /// b1 , b2  unde b1 este baza sursa si b2 este baza tinta 
    /// OUTPUT - numarul in baza b2 sau "Date de intrare incorecte"
    /// observatii:
    /// Trebuie sa tineti cont de posibilitatea ca nr in baza b2 sa nu poata fi reprezentat pe un nr finit de cifre
    /// 
    ///</summary>
   

