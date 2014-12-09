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

        /// <summary>
        /// Resultat avant impot
        /// </summary>
        /// <param name="nbAnnee"></param>
        /// <returns></returns>
        public double ResultatAvantImpôt(int nbAnnee)
        {
            double calcul = Ca[nbAnnee] - ChargesFixes[nbAnnee] - ChargesVariables[nbAnnee] - Ammortissement();

            return (calcul);
        }

        /// <summary>
        /// Retourne ammortissment 
        /// </summary>
        /// <returns></returns>
        public double Ammortissement()
        {
            return ((InvetMateriel-ValeurResid)/NbAnnee);
        }

        /// <summary>
        /// calcul resultat apres impot
        /// </summary>
        /// <returns></returns>
        public double ValeurImpôt(int i)
        {
            
            return (ResultatAvantImpôt(i) * (0.35));
        }



         public double CFActualisé(int i)
        {
            double calcul = CalculCashFlow(i) * ((Math.Pow((1+ (TxActualisation / 100)), -(i+1)))) ;
            return calcul;
        }

        /// <summary>
        /// Calcul de la Van
        /// </summary>
        /// <returns></returns>
         public double VAN( )
         {
             double merde = 1.0;
             double calcul = 1.0;
             for (int i = 0; i < NbAnnee; i++)
             {
                 merde = CFActualisé(i);
                 calcul = calcul + merde;
                 
             }
             return calcul-investissement;
         }
        

        /// <summary>
        /// Calcul du CashFlow
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public double CalculCashFlow(int i)
         {
             double cashFlow = 0;
             if (i< nbAnnee-1)
             {
                 cashFlow = Ammortissement() + (ResultatAvantImpôt(i) - ValeurImpôt(i));
             }
             else
                 cashFlow = (Ammortissement() + (ResultatAvantImpôt(i) - ValeurImpôt(i))) + valeurResid;

             return cashFlow;
         }
    }
}
