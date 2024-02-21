using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Manuel : Livre
    {
        public int NiveauScolaire { get; set; }
        public Manuel(string titre, int nbPage, string auteur, int niveauScolaire)
           : base(titre, nbPage, auteur)
        {
            NiveauScolaire = niveauScolaire;
        }
        public override bool Equals(object? obj)
        {
            //non null
            if (obj == null) return false;

            //obj doit etre de meme type que la classe
            if (!(obj is Manuel)) return false;

            //cast
            Manuel m = (Manuel)obj;

            //implementer le critere d`égalité
            return base.Equals(m) && m.NiveauScolaire == NiveauScolaire;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Niveau Scolaire : " + NiveauScolaire;
        }
    }
}
