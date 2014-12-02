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
    public partial class Fconfirmation : Form
    {

        private CashFlow unCash;
        public Fconfirmation()
        {
            InitializeComponent();
        }

        public Fconfirmation(CashFlow cash)
        {
            unCash = cash;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Fconfirmation_Load(object sender, EventArgs e)
        {
            lb_inv.Text += "  " + unCash.Investissement.ToString();
            lb_invMat.Text += "  " + unCash.InvetMateriel.ToString();
            lb_nbAnnees.Text += "  "+unCash.NbAnnee.ToString();
            lb_resid.Text += "  " + unCash.ValeurResid.ToString();
            lb_taux.Text += "  " + unCash.TxActualisation.ToString();
            int cpt = 0;
            while(cpt < unCash.NbAnnee)
            {
                dg_conf.Rows.Add(unCash.Ca[cpt],unCash.ChargesFixes[cpt],unCash.ChargesVariables[cpt]);
                cpt++;
            }

            

        }
    }
}
