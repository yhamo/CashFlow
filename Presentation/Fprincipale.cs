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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saisieDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unCashFlow = new CashFlow();
            Fsaisie uneFSD = new Fsaisie(unCashFlow);
            uneFSD.ShowDialog();
        }
    }
}
