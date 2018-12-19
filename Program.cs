using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] saison = new string[] {"AUTOMNE","HIVER","PRINTEMPS","ETE"};
            Console.WriteLine("VEUILLEZ INDIQUER LE MOIS SOUHAITE (MAJUSCULE SVP) :");
            string mois = Console.ReadLine();
            if (mois == "JANVIER" ^ mois == "FEVRIER" ^ mois == "DECEMBRE")
                Console.WriteLine("VOUS ETE EN SAISON DE (D') " + saison[1]);
                else
                    if (mois == "MARS" ^ mois == "AVRIL" ^ mois == "MAI")
                        Console.WriteLine("VOUS ETE EN SAISON DE (D') " + saison[2]);
                    else
                        if (mois == "JUIN" ^ mois == "JUILLET" ^ mois == "AOUT")
                            Console.WriteLine("VOUS ETE EN SAISON DE (D') " + saison[3]);
                        else
                            Console.WriteLine("VOUS ETE EN SAISON DE (D') " + saison[0]);
        }
    }
}
/* Console.WriteLine("Choisissez un mois ");
            string mounth = Console.ReadLine();
            switch (mounth)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'automne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;*/
