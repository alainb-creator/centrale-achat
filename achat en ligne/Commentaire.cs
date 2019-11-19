using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Commentaire
    {
       public string Text { get; set; }
        public Client Auteur { get; set; }

        public Commentaire(string text, Client auteur)
            {
            Text = text;
           Auteur=auteur;
        }
}
}
