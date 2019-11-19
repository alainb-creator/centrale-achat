using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{



    class Program
    {
        // la fonction logintrycatch s'apelle elle même 
      
        static void Main(string[] args)
        {
            Centrale centrale = new Centrale();

        

            User client = new Client("jean", "moi@gmail.com", "pass");
            User vendeur = new Vendeur("Momo", "momo@gmail.com ", "pass");
            Client clicli = (Client)client;
            centrale.Users.Add(client);
            centrale.Users.Add(vendeur);
             /* Console.WriteLine("Enter eMail adress");
          string mail = Console.ReadLine();
          Console.WriteLine("enter password");
          string passwrd = Console.ReadLine();
          User LogClient = centrale.LoginTryCatch(mail, passwrd);
          Console.WriteLine(LogClient.Nom);
         */

            //on castre la variable vendeur(déclarée de type user) dans le type vendeur
            Article art = new Article("velo", "un super velo", 100.5, (Vendeur)vendeur);
            Article art1 = new Article("montre", "rollexo", 10000.5, (Vendeur)vendeur);
            Article art2 = new Article("coca", "c'est pas bon", 1.5, (Vendeur)vendeur);

            centrale.AddArticle(art);
            centrale.AddArticle(art1);
            centrale.AddArticle(art2);
            centrale.UpdateStockArticle(art, 10);

            clicli.Panier.AddArticleToPanier(art, 10);
            clicli.CommanderPanier(centrale);

            foreach(Article article in centrale.SearchArticles("velo"))
            {
             
                Console.WriteLine(article.Name);
                Console.WriteLine(article.Description);
            }
            Console.ReadKey();
        }
    }
}

