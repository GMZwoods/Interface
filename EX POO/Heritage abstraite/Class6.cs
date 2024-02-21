using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Dictionnaire : Document
    {
        public string Langue { get; set; }

        public Dictionnaire(string titre, int nbPage, string langue)
            : base(titre, nbPage)
        {
            Langue = langue;
        }
        public override bool Equals(object? obj)
        {
            //non null
            if (obj == null) return false;

            //meme type que la classe
            if (!(obj is Dictionnaire)) { return false; }

            //cast
            Dictionnaire d = (Dictionnaire)obj;

            //critere egaliter 
            return base.Equals(d) && d.Langue == Langue;
        }
        public override string ToString()
        {
            return base.ToString() + "\n Langue : " + Langue;
        }
    }
}
