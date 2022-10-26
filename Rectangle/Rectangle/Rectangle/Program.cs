using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NameSpaceRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
                       
           //Entrer la longueur et la largeur du rectangle.
           Console.Write("Entrer la longueur du rectangle : ");
           int longr = int.Parse(Console.ReadLine());
           Console.Write("Entrer la largeur du rectangle : ");
           int larg = int.Parse(Console.ReadLine());
           // Instancier un rectangle.
           Rectangle R = new Rectangle(longr,larg);
           // Appeler la méthode AfficherRectangle()  
           R.AfficherRectangle();
           // Appeler la méthode surchargée ToString()
           Console.Write("Appeler la méthode ToString() --> "+R.ToString());
           Console.ReadKey();
            

            
        }
    }
}
