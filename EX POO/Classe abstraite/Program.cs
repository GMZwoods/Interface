




using Classe_abstraite;

internal class program 
{ 
    static void Main(string[] args) 
    {
        Rectangle r1 = new Rectangle(4, 5, 6, 7);
        Cercle c1 = new Cercle(12,12, 5);
        Carré cc = new Carré(8, 10, 3);

        Forme r = r1;
        Forme c = c1;
        Forme forme = cc;
    
    }

}








