using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class IntervenantExterne : Intervenant
    {
        private string spécialité, adresse;
        private int tel;

        public string Spécialité { get => spécialité; }

        public string Adresse { get => adresse; }

        public int Tel { get => tel; }
    }
}
