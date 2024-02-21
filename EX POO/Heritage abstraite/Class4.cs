using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Livre : Document
    {
        public string Auteur { get; set; }

        public Livre(string titre, int nbPage, string auteur)
            : base(titre, nbPage)
        {
            Auteur = auteur;
        }
        public override bool Equals(object? obj)
        {
            //obj doit etre non null
            if (obj == null) return false;

            //obj doit etre de meme type que la classe
            if (!(obj is Livre)) return false;

            //cast 
            Livre l = (Livre)obj;

            //implementer le critere d`égalité
            return base.Equals(l) && l.Auteur == Auteur;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Auteur : " + Auteur;
        }

    }
}
