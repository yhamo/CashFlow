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
    public partial class Ftableau : Form
    {
        private CashFlow unCash;

        public Ftableau()
        {
            InitializeComponent();
        }
        public Ftableau(CashFlow cash)
        {
            unCash = cash;
            InitializeComponent();

        }

        private void Ftableau_Load(object sender, EventArgs e)
        {
            dg_cash.RowHeadersWidth += 95;
            dg_cash.RowHeadersWidthSizeMode =
            DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            // On définit le nombre de colonnes
            dg_cash.ColumnCount = 5;
            // On définit la taille
            //Création des textes d'en-tête des lignes du DatagridView concernant les Cash-

            List<String> nomsHeaderCell = new List<String>();
            nomsHeaderCell.Add("C.A");
            nomsHeaderCell.Add("C.V");
            nomsHeaderCell.Add("C.F");
            nomsHeaderCell.Add("Ammortissement");
            nomsHeaderCell.Add("Charges Annuelle");
            nomsHeaderCell.Add("Chiffre d'affaire avant impot");
            nomsHeaderCell.Add("Montant impot");
            nomsHeaderCell.Add("");
            nomsHeaderCell.Add("valeur résiduelle");
            nomsHeaderCell.Add("Cash Flow");


            CreerDgv(nomsHeaderCell);


            int nbcolonnes = unCash.NbAnnee;
            for (int i = 0; i < nbcolonnes; i++)
            {
                dg_cash.Rows[0].Cells[i].Value = unCash.Ca[i];
            }

            for (int i = 0; i < nbcolonnes; i++)
            {
                dg_cash.Rows[1].Cells[i].Value = unCash.ChargesVariables[i];
            }

            for (int i = 0; i < nbcolonnes; i++)
            {
                dg_cash.Rows[2].Cells[i].Value = unCash.ChargesFixes[i];
            }


            for (int i = 0; i < nbcolonnes; i++)
            {
                dg_cash.Rows[4].Cells[i].Value = unCash.ChargesFixes[i]+unCash.ChargesVariables[i];
            }

            dg_cash.Rows[8].Cells[nbcolonnes-1].Value = unCash.ValeurResid;
            
        }

        private void CreerDgv(List<String> nomsHeaderCell)
        {

            int cpt = unCash.NbAnnee;

            for (int i = 0; i < nomsHeaderCell.Count; i++)
            {
                dg_cash.Rows.Add();
                dg_cash.Rows[i].HeaderCell.Value = nomsHeaderCell[i];
            }
            for (int i = 0; i < cpt; i++)
            {
                dg_cash.Columns[i].HeaderCell.Value = "Année " + (i+1);
            }

            
        }




        private void dg_cash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }
    }
}
