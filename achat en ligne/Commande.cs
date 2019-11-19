using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Commande
    {
        public Client Client { get; set; }
        public Vendeur Vendeur { get; set; }
        public Article Article { get; set; }
        public int Quantite { get; set; }
        public bool Completed { get; set; }

    }
}
