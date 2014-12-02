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
        private int nbAnnee;
        private double txActualisation;
        private List<double> chargesVariables=new List<double>();
        private double valeurResid;
        private double invetMateriel;


     
        //Accesseurs


        public double ValeurResid
        {
            get { return valeurResid; }
            set { valeurResid = value; }
        }


        public double InvetMateriel
        {
            get { return invetMateriel; }
            set { invetMateriel = value; }
        }

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


        public int NbAnnee
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
