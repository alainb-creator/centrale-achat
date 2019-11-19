using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Article
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Active { get; set; }
        public List<Commentaire>Commentaires { get; set; }
        public int Stock { get; set; }
        public List<KeyValuePair<Client,int>>Reservation { get; set; } // crée liste de réservation
        public Vendeur Vendeur { get; set; }
        public Article(string name,string description,double price,Vendeur vendeur)

        {
            Name = name;
            Description = description;
           Vendeur = vendeur;
            Stock = 0;
            Active = true;
                
        }

    }
}
