using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1_G31
{
    class Compte
    {
        private  readonly int numcompte;
        private  static int cpt;
        private  readonly Client titulaire;
        private MAD solde;
        private  static MAD plafond;
        private List<Operation> historique; // la declaration de la liste
       

        static Compte()
        {
            cpt = 0;
            plafond = new MAD(2000);
           // pi = 3.14;
        }
        public Compte(Client Titu, MAD s)
        {
            
            this.numcompte = ++cpt;
            this.titulaire = Titu;
            this.solde = s;
            this.historique = new List<Operation>(); // creation de la liste avec size=0
            this.titulaire.affecterCompte(this);
        }
       

        public  virtual void consulter()
        {
            Console.WriteLine("le num est : " + this.numcompte);
            //this.titulaire.afficherClient();
            this.solde.afficherSolde();
            foreach(Operation o in historique)
            {
                o.afficheroperation();
            }
        }

        public bool crediter(MAD somme)
        {
            MAD nul_Val = new MAD(0);
            if (somme > nul_Val)
            {
                this.solde += somme;
                this.historique.Add(new Operation(somme, "+")); // ajout d'une operation dans la liste
                return true;
            }
            return false;
        }

        public virtual bool debiter(MAD somme)
        {
            MAD nul_Val = new MAD(0);
            if ( somme> nul_Val )
            {
                if (this.solde > somme)
                {
                    if (plafond > somme)
                    {
                        this.solde -= somme;
                        this.historique.Add(new Operation(somme, "-")); // ajout d'une operation dans la liste
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("plafond<somme");
                        return false;

                    }
                }
                else
                {

                    Console.WriteLine("solde<somme");
                    return false;
                }     
            }
            else
            {
                Console.WriteLine("somme<0");
                return false;
            }
        }

        public bool verser(Compte c, MAD somme)
        {
            if (this.debiter(somme)==true&& this.numcompte!=c.numcompte)
            {
                c.crediter(somme);
                return true;
            }
            return false;
        }

        protected void ajouterInteret(double interet)
        {
            this.crediter(new MAD(interet));
        }

        public bool comparerdecouvert(MAD dec, MAD somme)
        {
            if (this.solde - somme > dec)
            {
                return true;
            }
            return false;
        }


    }
}
