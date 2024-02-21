using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_abstraite
{
    internal class Cercle :  Forme
    {
        public double Rayon { get; set; }

        public Cercle(int cgX, int cgY, double rayon) : base (cgX, cgY)
        {
            Rayon = rayon;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Cercle)) return false;
            Cercle formeCercle = (Cercle)obj;
            return base.Equals(obj) && Rayon == formeCercle.Rayon;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + $"Rayon : " + Rayon.ToString();
        }

        public override double perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        public override double Surface()
        {
            return Math.PI * Math.Pow(Rayon, 2);
        }
    }
}
