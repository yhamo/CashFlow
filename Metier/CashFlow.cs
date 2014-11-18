using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class CashFlow
    {
        //Attributs
        private double ca;
        private double chargesFixes;
        private double investissement;
        private double nbAnnee;
        private double txActualisation;
        private double chargesVariables;

        //Accesseurs
        public double Ca
        {
            get { return ca; }
            set { ca = value; }
        }


        public double Investissement
        {
            get { return investissement; }
            set { investissement = value; }
        }


        public double NbAnnee
        {
            get { return nbAnnee; }
            set { nbAnnee = value; }
        }


        public double TxActualisation
        {
            get { return txActualisation; }
            set { txActualisation = value; }
        }

        public double ChargesVariables
        {
            get { return chargesVariables; }
            set { chargesVariables = value; }
        }


        public double ChargesFixes
        {
            get { return chargesFixes; }
            set { chargesFixes = value; }
        }

        public CashFlow()
        { }


    }
}
