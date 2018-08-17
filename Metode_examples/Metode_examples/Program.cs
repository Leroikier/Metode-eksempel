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
            string navn;
            string totalNavn = "";
            //Input
            Console.WriteLine("Hvad hedder du : ");
            navn = Console.ReadLine().Trim();

            //et string array oprettes via "navn", som splitter navn efter hvert mellemrum man indtaster
            string[] delNavn = navn.Split();

            //For hver string "tekst" i delNavn udskriv "xnavn" med metodens parametre inkluderet
            foreach (string xnavn in delNavn)
            {
                totalNavn += StortOgSmaat(xnavn); //Sætter alle navnene sammen 
            }
            Console.WriteLine(totalNavn.TrimEnd());
            Console.ReadLine();

            //Her oprettes en metode i class "main", som sørger for at det første bokstav er stort og resten bliver småt
            string StortOgSmaat(string inavn)
            {
                if (inavn.Length != 0)
                    return inavn.Substring(0, 1).ToUpper() + inavn.Substring(1).ToLower() + " ";
                else
                    return "";
            }
        }
    }
}
