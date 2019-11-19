using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Centrale
    {

        public List<Article> Articles { get; set; } //crée liste article selon class article
        public List<User> Users { get; set; }   //crée liste user selon class user

        public Centrale()   //constructeur
        {
            Articles = new List<Article> { };
            Users = new List<User> { };
        }

        public Client CreateClientAccount(string Nom, string Mail, string Password) //cree compte client
        {
            // crée compte client
            throw new NotImplementedException();
        }
        public Client CreateVendeurAccount(string Nom, string Mail, string Password) //crée compte vendeur
        {
            //crée compte vendeur
            throw new NotImplementedException();
        }
        public User Login(string mail, string password) // crée login user
        {
            List<User> tmp = Users.Where((user) => user.Mail.Equals(mail)).ToList();
            User LoggingIn = null;
            if (tmp.Count() > 0)
                LoggingIn = tmp.First();
            if (LoggingIn == null)
                throw new ArgumentException("email not registered");
            if (LoggingIn.Password != password)
             throw new ArgumentException();
            return LoggingIn;
        }
        public void AddArticle(Article article) 
        {
            // ajoute article a la liste
            Articles.Add(article);
            if (article == null)
                throw new ArgumentNullException();
        }
        public void DeactivateArticle(Article article)
        {
            // Desactive  article de la liste
            article.Active = false;
        }
        public void UpdateStockArticle(Article article, int stock)
        {
            // Modifie article ou desactive and ajoute nouvel article
            article.Stock = stock;
        }
        public List<Article> SearchArticles(string searchInput) //recherche article
        {
            List<Article> SearchResults = new List<Article> { };
            foreach (Article article in Articles)
            {
                if (article.Active && article.Name.Contains(searchInput))
                    SearchResults.Add(article);
            }
            return (SearchResults);
        }
        public List<Article> SearchArticles(string searchInput, double MinPrice, Double MaxPrice)
        {
            List<Article> Result = SearchArticles(searchInput);
            Result.Where((X) => X.Price < MaxPrice && X.Price > MinPrice);
            return Result;
        }


        public bool ConfirmAccount(User user, string ConfirmationAccount)
        {
            throw new NotImplementedException();
        }
        public User LoginTryCatch(string mail, string passwrd)
        {
            User user = null;

            try
            {
                user = this.Login(mail, passwrd);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong email, try again");
                mail = Console.ReadLine();
                Console.WriteLine("Wrong Password, try again");
                passwrd = Console.ReadLine();
                user=LoginTryCatch(mail, passwrd);

            }
            return user;
        }
    }
}

