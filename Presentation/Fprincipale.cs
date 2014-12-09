using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace WindowsCashFlow
{
    public partial class Fprincipale : Form
    {
        private CashFlow unCashFlow;
        public Fprincipale()
        {
            InitializeComponent();
        }


        /// <summary>
        /// quitte l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Affiche la page de saisie des données 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saisieDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unCashFlow = new CashFlow();
            Fsaisie uneFSD = new Fsaisie(unCashFlow);
            uneFSD.ShowDialog();
        }



        private void Fprincipale_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Verifie que des données ont ete entrees et affiche les tableaux de resultats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unCashFlow==null||unCashFlow.InvetMateriel==0) 
            {
                MessageBox.Show("Veuillez entrez d'abord des données");
            }
            else
            {
                Ftableau uneFSD = new Ftableau(unCashFlow);
                uneFSD.ShowDialog();
            }
        }
    }
}
