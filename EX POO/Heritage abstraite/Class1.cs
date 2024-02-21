using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Roman : Livre
    {
        public string PrixLitteraire { get; set; }
        public Roman(string titre, int nbPage, string auteur, string prixLitteraire)
            : base(titre, nbPage, auteur)
        {
            PrixLitteraire = prixLitteraire;
        }
        public override bool Equals(object? obj)
        {
            //non null
            if (obj == null) return false;

            //obj doit etre de meme type que la classe
            if (!(obj is Roman)) return false;

            //cast
            Roman r = (Roman)obj;

            //implementer le critere d`égalité
            return base.Equals(r) && r.PrixLitteraire == PrixLitteraire;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Prix itternaire : " + PrixLitteraire;
        }
    }
}
}
