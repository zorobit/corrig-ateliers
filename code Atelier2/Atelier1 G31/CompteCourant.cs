using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1_G31
{
    class CompteCourant : Compte
    {
        private MAD decouvert; 
        public CompteCourant( Client titu, MAD solde, MAD decouvert): base( titu,solde)
        {

            this.decouvert = decouvert;
        }

        public override void consulter()
        {
            Console.WriteLine(" Compte courant");
            base.consulter();
            this.decouvert.afficherSolde();
        }

        
        public override bool debiter(MAD somme)
        {
            if (this.comparerdecouvert(this.decouvert,somme))
            {
               return base.debiter(somme);
            }
            else
                return false;

        }


        }
}
