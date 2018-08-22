using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variabel
            string totalNavn = "";
            string totalNavn1 = "";
            //Input
            Console.Write("Hvad hedder du : ");
            string navn = Console.ReadLine().Trim();
            Console.Write("Hvad hedder din far : ");
            string fnavn = Console.ReadLine().Trim();

            //et string array oprettes via "navn", som splitter navn efter hvert mellemrum man indtaster
            //Mellemrum er default = ();
            string[] delNavn = navn.Split();
            string[] delNavn1 = fnavn.Split();

            //For hver string "tekst" i delNavn udskriv "xnavn" med metodens parametre inkluderet
            foreach (string xnavn in delNavn)
            {
                totalNavn += StortOgSmaat(xnavn); //Sætter alle navnene sammen 
            }
            foreach (string xnavn in delNavn1)
            {
                totalNavn1 += StortOgSmaat(xnavn); //Sætter alle navnene sammen 
            }
            //Udskrivning /TrimEnd sørger for at fjerne mellemrum i udskrivningen
            Console.WriteLine(totalNavn.TrimEnd());
            Console.WriteLine(totalNavn1.TrimEnd());

            //Her oprettes en metode i class "main", som sørger for at det første bokstav er stort og resten bliver småt
            string StortOgSmaat(string inavn)
            {
                //hvis inavn ikke er 0 køre den metoden under
                if (inavn.Length != 0)
                    return inavn.Substring(0, 1).ToUpper() + inavn.Substring(1).ToLower() + " ";
                else
                    //ellers returnere "tomt"
                    return "";
            }
            Console.ReadKey();
        }
    }
}
