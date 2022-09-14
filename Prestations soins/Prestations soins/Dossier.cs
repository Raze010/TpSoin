using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class Dossier
    {
        public Dossier (string nom,string prenom,DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        private string nom, prenom;

        public DateTime dateNaissance;

        public string Nom { get => nom; }

        public string Prenom { get => prenom; }

        public DateTime DateNaissance { get => dateNaissance; }

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
             
        public int getNbJoursSoins ()
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (Prestation p in prestations)
            {
                if(!dates.Contains(p.DateHeureSoin)) 
                dates.Add(p.DateHeureSoin);
            }

            return dates.Count;
        }

        public int GetNbJoursSoinsV2()
        {
            List<DateTime> dates = new List<DateTime>();

            foreach (Prestation p in prestations)
            {
                dates.Add(p.DateHeureSoin);
            }

            if (dates.Count == 0)
                return 0;

            dates.Sort();

            DateTime plusGrandeDate = dates[0];

            int compteur = 1;
    
            for (int i = 1;  i < dates.Count; i++)
            {
                if (dates[i] > plusGrandeDate)
                {
                    compteur += 1;
                    plusGrandeDate = dates[i];
                }
            }

            return compteur;
        }

        public int GetNbJoursSoinsV3 ()
        {
            return 0;
        }

        public override string ToString()
        {
            string a = "-----Début dossier--------------\n\tNom: {0} Prenom: {1} Date de naissance: {2}";

            foreach(Prestation p in prestations)
            {
                a += "\n\tLibelle P" + p.Libelle + " - " + p.DateHeureSoin.ToString() +" - Intervenant : " +p.Intervenant.Nom +" - " +p.Intervenant.Prenom;

                if(p.Intervenant is IntervenantExterne)
                {
                    IntervenantExterne i = ((IntervenantExterne)p.Intervenant);

                    a += " Spécialité : " + i.Spécialite +"\n\t\t" +i.Adresse +" - " +i.Tel;
                }
            }

            a += "\n-----Fin dossier--------------";

            return a;
        }
    }
}
