using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class IntervenantExterne : Intervenant
    {
        private string specialite, adresse;
        private int tel;

        public string Spécialite { get => specialite; }

        public string Adresse { get => adresse; }

        public int Tel { get => tel; }
    
        public IntervenantExterne(string nom, string prenom,string specialite,string adresse,int tel) : base(nom,prenom)
        {
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }
    }
}
