using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_abstraite
{
    internal class Document
    {
        public static int id = 1;
        public int Id { get; private set; }
        public string Titre { get; set; }
        public int NbPage { get; set; }

        public Document(string titre, int nbPage)
        {
            Id = id++;
            Titre = titre;
            NbPage = nbPage;
            //id++;
        }
        public override bool Equals(object? obj)
        {
            //non null
            if (obj == null) return false;

            //meme type que la classe
            if (!(obj is Document)) { return false; }

            //cast
            Document d = (Document)obj;

            //critere egaliter 
            return d.Id == this.Id && d.Titre == this.Titre && d.NbPage == this.NbPage;
        }
        public override string ToString()
        {
            return "ID : "+ GetType().Name+ "\n" + Id + "\nTitre : " + Titre + "\n Nombre de page : " + NbPage;
        }

    }
}
