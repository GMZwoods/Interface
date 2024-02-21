using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Voiture : ISon, IRéparation 
    {

        public int nbPorte { get; set; }
        public string Marque { get; set; }

        public Voiture(int x, string marque) 
        {
            nbPorte = x;
            Marque = marque;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        void ISon.Parler()
        {
            Console.WriteLine("Son produit de l'interface ISon");
        }

        void IRéparation.Parler()
        {
            Console.WriteLine("Son produit de l'interface IRéparation");
        }
    }

}
