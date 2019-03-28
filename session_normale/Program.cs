using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_normale
{
    class Program
    {

        private static List<Article> articles = new List<Article >();

        //2.2 article par reference
        public static int SearchArticleparreference(List<Article > articles, string refe)
        {
            int result = -1;
            for (int i = 0; i < articles.Count; i++)
            {
                if (articles.ElementAt(i).Reference.Equals(refe))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }


        //article par nom
        public static int Searcharticleparnom(List<Article> articles, string no)
        {
            int result = -1;
            for (int i = 0; i < articles.Count; i++)
            {
                if (articles.ElementAt(i).Nom.Equals(no))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        //supprimer par reference
        public static bool Delarticleparreference(List<Article > articles, String refe)
        {
            int is_exist = SearchArticleparreference(articles , refe);
            if (is_exist != -1)
            {
                articles.RemoveAt(is_exist);
                return true;
            }
            else
            {
                return false;
            }
        }

        // rechercher un article par intervalle de prix de vente


        // afficher tous les articles
        public static void afficherarticle()
        {
            

            for (int k = 0; k < articles.Count; k++)
            {
                System.Console.Out.WriteLine(articles.ElementAt(k).ToString());
            }
        }

        static void Main(string[] args)
        {
            //ajout de trois livres

            Console.WriteLine("Enregistrement de 3 livres");
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("Enregistrement du livre N° " + (i + 1));
                Console.Write("Reference : ");
                String reference = Console.ReadLine();
                String nom = "Pysique";
                Console.Write("Nom : ", nom );
                
                 double prix = 5000;
                Console.Write("Prix : ",+prix);
               
                Article  articles  = new Article (reference ,nom, prix,1);
               
                    i++;
            }

            // ajout de deux paquet de bic
            Console.WriteLine("Enregistrement de 3 livres");
            int j = 0;
            while (j < 2)
            {
                Console.WriteLine("Enregistrement du paquet de bic N° " + (j + 1));
                Console.Write("Reference : ");
                String reference = Console.ReadLine();
                String nom = "Paquet de bic";
                Console.Write("Nom : ", nom);

                double prix = 1000;
                Console.Write("Prix : ", +prix);

                Article articles = new Article(reference, nom, prix, 1);

                j++;
            }

            //ajout de quatre paquets de cahiers
            Console.WriteLine("Enregistrement de 3 livres");
            int cpt = 0;
            while (cpt < 4)
            {
                Console.WriteLine("Enregistrement du paquet de cahier N° " + (cpt + 1));
                Console.Write("Reference : ");
                String reference = Console.ReadLine();
                String nom = "Paquet de bic";
                Console.Write("Nom : ", nom);

                double prix = 2350;
                Console.Write("Prix : ", +prix);

                Article articles = new Article(reference, nom, prix, 1);

                cpt++;
            }


           

            //liste des livres présents dans la librairie
            afficherarticle();
          
            System.Console.ReadLine();

        }
    }
}
