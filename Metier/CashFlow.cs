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



        private List<double> ca= new List<double>();
        private List<double> chargesFixes=new List<double>();
        private double investissement;
        private double nbAnnee;
        private double txActualisation;
        private List<double> chargesVariables=new List<double>();

     
        //Accesseurs

        public List<double> Ca
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

       


        public List<double> ChargesFixes
        {
            get { return chargesFixes; }
            set { chargesFixes = value; }
        }
        public CashFlow()
        { }

        public List<double> ChargesVariables
        {
            get { return chargesVariables; }
            set { chargesVariables = value; }
        }

    }
}
