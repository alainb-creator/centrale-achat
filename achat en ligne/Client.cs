using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Client: User
    {
     
       public Panier Panier { get; set; }
        public Client(string nom, string mail, string password) : base(nom, mail, password)
        {
            Panier = new Panier(this);
        }


        public void CommanderPanier(Centrale centrale)
        {
            //envoyer les commandes au vendeur concerné
            foreach(KeyValuePair<Article, int> articleQtePair in Panier.Articles)
            {
                //articleQtePair.Key.vendeur.AddToBonus(this, articleQtePair.Key.Price * articleQtePair.Value);
                //compte les achats pour les bonus (cote vendeur
                if (articleQtePair.Key.Stock >= articleQtePair.Value)
                    articleQtePair.Key.Stock -= articleQtePair.Value;
                else
                {
                    Console.WriteLine("  ");
}
            }
           
            
        }

        public void Comment(Article article, string comment)
        {
            article.Commentaires.Add(new Commentaire(comment, this));
        }
        public void Reclamation(Article article,string text) 
        {
            throw new NotImplementedException();
        } 
     
    }
}
