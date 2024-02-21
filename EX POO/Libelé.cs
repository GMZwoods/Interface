using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArticles
{
    internal class Article
    {
        public string libelé { get ; set; } 

        private double quantité;
        public double Quantité 
        {
            get { return Quantité; }
            set { if (value > 0) quantité = value; else quantité = 1; }
        
        }

        private double prix;
        public double Prix 
        {
            get { return prix; }
            set { if (value >= 12.99) prix = value; else prix = 12.99; }
        }

        public string Emplacement { get; set; } = "tempo";
        





        void ArticleTest() 
        {
            Article monEpicier = new Article();
            monEpicier.libelé = "Tomate";

        
        
        
        
        
        }

    }
}
