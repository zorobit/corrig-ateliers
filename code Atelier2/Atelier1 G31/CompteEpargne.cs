using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1_G31
{
    class CompteEpargne: Compte
    {
        private double TauxInteret;
        public CompteEpargne(Client Titu, MAD solde) : base(Titu, solde)
        {
            bool res;
            double Taux;
            do
            {
                Console.WriteLine("donnez un taux ");
                res = double.TryParse(Console.ReadLine(), out Taux);
            }while(Taux <= 0 || Taux > 100 || !res);


            this.TauxInteret = Taux;
        }

        public void ClaculInteret()
        {
             this.ajouterInteret(TauxInteret / 100);
            
        }

        public override void consulter()
        {
            Console.WriteLine(" Compte Epargne");
            base.consulter();
            Console.WriteLine(" le taux est : " + this.TauxInteret);
        }

        }
}
