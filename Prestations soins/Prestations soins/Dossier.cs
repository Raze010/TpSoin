using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Dossier
    {
        private string nom, prenom, dateNaissance;

        public string Nom { get => nom; }

        public string Prenom { get => prenom; }

        public string DateNaissance { get => dateNaissance; }

        public List<Prestation> prestations = new List<Prestation>();

        public void ajoutePrestation (Prestation prestation)
        {
            prestations.Add(prestation);
        }

        public int getNbPrestations ()
        {
            return prestations.Count;
        }

        public int getNbPrestationsExternes ()
        {
            int nbPrestationExternes = 0;

            foreach(Prestation p in prestations)
            {
                if (p.Intervenant is IntervenantExterne)
                {
                    nbPrestationExternes++;
                }
            }

            return nbPrestationExternes; ;
        }
             
        public void getNbJoursSoins ()
        {

        }
    }
}
