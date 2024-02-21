using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_abstraite
{
    internal class Rectangle : Forme
    {
        public double Largeur { get; set; }
        public double Longueur { get; set; }

        public Rectangle(int cgX, int cgY, double largeur, double longueur) : base (cgX, cgY)
        {
            Largeur = largeur;
            Longueur = longueur;
        
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Rectangle)) return false;
            Rectangle formeRec = (Rectangle)obj;
            return base.Equals(obj) && Largeur == formeRec.Largeur && Longueur == formeRec.Longueur;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + $"Largeur : " + Largeur.ToString() + "\n" + "Longueur : " + Longueur.ToString();
        }

        public override double Surface()
        {
           return Longueur * Largeur;
        }

        public override double perimetre()
        {
            return (Largeur + Longueur) * 2;
        }

          
    }
}
