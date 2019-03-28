using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_normale
{
    class Article
    {
        private string reference;
        private string nom;
        private double prix;
        private int stock;


        public string Reference 
        {
            get { return reference; }
            set { reference = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Prix
        {
            get { return prix ; }
            set { prix = value; }
        }

        public int Stock
        {
            get { return stock ; }
            set { stock= value; }
        }

        public Article(string refe, string no, double pri, int stoc){
            this.reference = "refe";
            this.nom = "no";
            this.stock = stoc;
            this.prix = pri;
       }

        public string ToString()
        {
            return reference + "  " + nom + "  " + prix + "  " + stock;
        }
    }
}
