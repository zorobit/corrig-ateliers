using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1_G31
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adress;
        private List<Compte> lesComptes;


        public Client (string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.adress = a;
            lesComptes = new List<Compte>();
        }

        public void afficherClient()
        {
            Console.WriteLine("le nom est : " + this.nom);
            Console.WriteLine("le prenom est : " + this.prenom);
            Console.WriteLine("l'adresse est : " + this.adress);
            foreach(Compte c in lesComptes)
            {
                c.consulter();
            }
        }

        public void affecterCompte(Compte c)
        {
            lesComptes.Add(c);
        }

    }
}
