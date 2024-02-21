using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Revue : Document
    {
        public double PrixAbonnement { get; set; }
        public string Mois { get; set; }
        public int Annee { get; set; }

        public Revue(string titre, int nbPage, double prixAbonnement, string mois, int annee)
            : base(titre, nbPage)
        {
            PrixAbonnement = prixAbonnement;
            Mois = mois;
            Annee = annee;
        }
        public override bool Equals(object? obj)
        {
            //obj doit etre non null
            if (obj == null) return false;

            //obj doit etre de meme type que la classe
            if (!(obj is Revue)) return false;

            //cast 
            Revue r = (Revue)obj;

            //implementer le critere d`égalité
            return base.Equals(r) && r.PrixAbonnement == PrixAbonnement &&
                r.Mois == Mois &&
                r.Annee == Annee;
        }
        public override string ToString()
        {
            return base.ToString() + "\n " +
                "Prix de L'abonnement : " + PrixAbonnement + "\n " +
                "le mois : " + Mois + "\n " +
                "L'annee : " + Annee;
        }
    }
}
