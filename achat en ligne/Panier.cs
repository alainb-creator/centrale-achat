using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Panier
    {
        public Client Client {get; set;}
       public List<KeyValuePair<Article, int>> Articles { get; set; } // cree liste article

        public Panier(Client client)    // constructeur
        {
            Client = client;
            Articles = new List<KeyValuePair<Article, int>> { };
        }
        public void AddArticleToPanier(Article article, int quantite) //ajout article au panier
        {
            Articles.Add(new KeyValuePair<Article, int>(article, quantite));
        }
        public void ModifyQuantityInPanier(Article article, int newQuantity) //modifie quantité article panier
        {
            throw new NotImplementedException();
        }
        public void RemoveArticleFromPanier(Article article)    // supprimer article du panier
        {
            throw new NotImplementedException();
        }
    }
}
