using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_abstraite
{
    internal abstract class Forme
    {

        public int CGx { get; set; }
        public int CGy { get; set; }

        public Forme(int cgX, int cgY) 
        {
            CGx = cgX; 
            CGy = cgY;
        }
 
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (!(obj is Forme)) return false;
            Forme f = (Forme)obj;
            return CGx == f.CGx && CGy == f.CGx;
        }

        public override string ToString()
        {
            return $"Forme : " + GetType().Name + "\n" + "Centre de gravité : " + (CGx) + (CGy);
        }

        public abstract double Surface();
        

        public abstract double perimetre();
       
    }
}
