using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Prestation
    {
        private int libelle;
        private DateTime dateHeureSoin; // 11/09/2015 12:00

        public int Libelle { get => libelle; }

        public DateTime DateHeureSoin { get => dateHeureSoin; }

        private Intervenant intervenant;

        public Intervenant Intervenant { get => intervenant; }

        public Prestation (Intervenant intervenant, int libelle, DateTime dateHeureSoin)
        {
            this.intervenant = intervenant;
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
        }

        public int compareTo(Prestation prestation)
        {
            return DateTime.Compare(dateHeureSoin,prestation.DateHeureSoin);
        }
    }
}
