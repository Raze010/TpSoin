using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Intervenant
    {
        private string nom, prenom;

        public string Nom { get => nom; }
        public string Prenom { get => prenom; }

        public List<Prestation> prestations = new List<Prestation>();

        public void ajoutePrestation (Prestation prestation)
        {
            prestations.Add(prestation);
        }
    }
}
