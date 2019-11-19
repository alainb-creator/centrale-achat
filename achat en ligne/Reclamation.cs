using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achat_en_ligne
{
    class Reclamation
    {
       public string Text { get; set; }
        public Client Client { get; set; }

        public Reclamation(string text,Client client)
            {
            Text = text;
            Client = client;
        }
    }
}
