using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class BD : Livre
    {
        public bool Couleur { get; set; }

        public BD(string titre, int nbPage, string auteur, bool couleur)
            : base(titre, nbPage, auteur)
        {
            Couleur = couleur;
        }
        public override bool Equals(object? obj)
        {
            //non null
            if (obj == null) return false;

            //cast
            BD b = obj as BD;//
            if (b == null) return false;
            //implementer le critere d`égalité
            return base.Equals(b) && b.Couleur == Couleur;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Couleur : " + Couleur;
        }
    }
}
