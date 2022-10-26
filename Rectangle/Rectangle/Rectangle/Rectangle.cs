using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaceRectangle
{
    class Rectangle
    {
        // Définition des attributs privés.
        int longueur;
        int largeur;
        // Définition des propriétés Longueur et Largeur.
        int Longueur
        {
            get { return this.longueur; }
            set { if (value >= 0) this.longueur = value; }
        }

        int Largeur
        {
            get { return this.largeur; }
            set { if (value >= 0) this.largeur = value; }
        }
        // Définir le constructeur de la classe Rectangle.
        public Rectangle(int p_longueur = 1, int p_largeur = 1)
        {
            this.longueur = p_longueur;
            this.largeur = p_largeur;
        }
        //Définir des méthodes. 
        public int Perimetre()
        {
            return (this.longueur + this.largeur) * 2;
        }

        public int Aire()
        {
            return this.longueur * this.largeur;
        }

        public bool EstCarre()
        {
            if (this.longueur == this.largeur)
                return true;
            else
                return false;
        }

        public void AfficherRectangle()
        {
            string s = "";
            s += "- Longueur : " + this.longueur;
            s += " - Largeur : " + this.largeur;
            s += " - Périmétre : " + Perimetre();
            s += " - Aire : " + Aire();
            if (EstCarre())
                s += " - Il s'agit d'un carré.";
            else
                s += " - Il ne s'agit pas d'un carré.";

            Console.WriteLine(s);
        }

        // Surcharger la méthode ToString().
        public override string ToString()
        {
            return "La Longueur du rectange est égale à : " + this.longueur
                + " et sa largeur est égale à : " + this.largeur + ".";
        }
    }
        
    
}
