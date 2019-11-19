using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Vendeur : User
    {
      
        public List<KeyValuePair<Client, double>> Fidelite { get; set; }// liste client et argent depensé
         public List<Article> Articles { get; set; }   //liste articles
        public List<Reclamation> Reclamations { get; set; }

        public Vendeur(string nom, string mail, string password) : base(nom, mail, password) //constructeur
        {
            Articles = new List<Article> { };
            Reclamations = new List<Reclamation> { };
            Fidelite = new List<KeyValuePair<Client, double>>{ };
        }
        public void AddArticle (Article article, Centrale centrale) //ajout article
        {
            Articles.Add(article);
            centrale.AddArticle(article);
        }
        public void AddArticleToStock(Article article, int stock)// ajout article en stock
        {
            article.Stock += stock;
        }
        public void DeactivaeArticle(Article article, Centrale centrale) //desactive article a zero en stock
        {
            article.Active = false;
        }
        public void GererCommentaires() 
        {
            throw new NotImplementedException();

        }
        public void GererReclamations()
        {
            throw new NotImplementedException();
        }
        public void RecompenseFidelite(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
