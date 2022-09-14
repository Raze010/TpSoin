using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dossier dossier = new Dossier("Brouillet","Thibaud",new DateTime(2022,09,14));

            Intervenant Florian = new Intervenant("Gertner","Florian");

            IntervenantExterne Adrien = new IntervenantExterne("Dodero", "Adrien","Pêcheur","Toulon",065454545);

            dossier.ajoutePrestation(new Prestation(Florian, 1, new DateTime(2022, 05, 2)));
            dossier.ajoutePrestation(new Prestation(Florian, 2, new DateTime(2022, 06, 3)));
            dossier.ajoutePrestation(new Prestation(Adrien, 3, new DateTime(2022, 05, 2)));
            dossier.ajoutePrestation(new Prestation(Adrien, 4, new DateTime(2022, 07, 15)));
            dossier.ajoutePrestation(new Prestation(Florian, 5, new DateTime(2022, 06, 5)));
            dossier.ajoutePrestation(new Prestation(Florian, 6, new DateTime(2022, 08, 22))); // BON RESULTAT = 5

            Console.WriteLine("V1 = " +dossier.getNbJoursSoins() + " jours");
            Console.WriteLine("V2 = " +dossier.GetNbJoursSoinsV2() + " jours");

            Console.WriteLine(dossier.ToString());

            Console.ReadLine();
        }
    }
}
