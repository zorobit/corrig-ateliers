using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier1_G31
{
    class MAD
    {
        private double valeur; 

        public MAD(double val)
        {
            this.valeur = val;
        }

        public void afficherSolde()
        {
            Console.WriteLine(this.valeur);

        }

        public static  bool operator>(MAD m1,MAD m2)
        {

            if (m1.valeur> m2.valeur)
            {
                return true;

            }
                return false;
            
        }
        public static bool operator <(MAD m1, MAD m2)
        {

            if (m1.valeur < m2.valeur)
            {
                return true;

            }
            return false;
        }

        public  static MAD operator+(MAD m1, MAD m2)
        {
            MAD res = new MAD(0);
            res.valeur = m1.valeur + m2.valeur;
            return res;
        }
        public static MAD operator -(MAD m1, MAD m2) => new MAD(m1.valeur - m2.valeur);
        

        public static MAD operator *(MAD m1, double m2) => new MAD(m1.valeur * m2);
       


    }
}
