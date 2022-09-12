using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Prestation
    {
        private int libellé;
        private string dateHeureSoin; // 11/09/2015 12:00

        public int Libellé { get => libellé; }

        public string DateHeureSoin { get => dateHeureSoin; }

        private Intervenant intervenant;

        public Intervenant Intervenant { get => intervenant; }

        public Prestation (Intervenant intervenant, int libellé, string dateHeureSoin)
        {
            this.intervenant = intervenant;
            this.libellé = libellé;
            this.dateHeureSoin = dateHeureSoin;
        }

        public void compareTo(Prestation prestation)
        {

        }
    }
}
