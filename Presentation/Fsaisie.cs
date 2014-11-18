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

    public partial class Fsaisie : Form
    {
        int cpt = 1;
        private CashFlow unCash;
        public Fsaisie()
        {
            InitializeComponent();
        }

        public Fsaisie(CashFlow cash)
        {

            unCash = cash;
            InitializeComponent();

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            cpt++;
            if (cb_MemeValeur.Checked==true)
            {
                if ((tb_txAct.Text != "") && (tb_ann.Text != "") && (tb_ca.Text != "") && (tb_inv.Text != ""))
                {
                    String tampon;

                    tampon = tb_ca.Text;
                    Double ca = Double.Parse(tampon);
                    unCash.Ca.Add(ca);

                    if (tb_cv.Text != "")
                    {
                        tampon = tb_cv.Text;
                        Double cv = Double.Parse(tampon);
                        unCash.ChargesVariables.Add(cv);
                    }
                    else
                        unCash.ChargesVariables.Add(0.0);

                    if (tb_cf.Text != "")
                    {
                        tampon = tb_cf.Text;
                        Double cf = Double.Parse(tampon);
                        unCash.ChargesFixes.Add(cf);
                    }
                    else
                        unCash.ChargesFixes.Add(0.0);

                    tampon = tb_inv.Text;
                    Double inv = Double.Parse(tampon);
                    unCash.Investissement = inv;

                    tampon = tb_txAct.Text;
                    Double txAct = Double.Parse(tampon);
                    unCash.TxActualisation = txAct;

                    tampon = tb_txAct.Text;
                    Double nbannees = Double.Parse(tampon);
                    unCash.NbAnnee = nbannees;

                }
                else
                    MessageBox.Show("Entrez les champs obligatoires");

            }

            
            while ((cb_MemeValeur.Checked != true) || (cpt <= unCash.NbAnnee))
            {
                if ((tb_txAct.Text != "") && (tb_ann.Text != "") && (tb_ca.Text != "") && (tb_inv.Text != ""))
                {
                    String tampon;

                    tampon = tb_ca.Text;
                    Double ca = Double.Parse(tampon);
                    unCash.Ca.Add(ca);

                    if (tb_cv.Text != "")
                    {
                        tampon = tb_cv.Text;
                        Double cv = Double.Parse(tampon);
                        unCash.ChargesVariables.Add(cv);
                    }
                    else
                        unCash.ChargesVariables.Add(0.0);

                    if (tb_cf.Text != "")
                    {
                        tampon = tb_cf.Text;
                        Double cf = Double.Parse(tampon);
                        unCash.ChargesFixes.Add(cf);
                    }
                    else
                        unCash.ChargesFixes.Add(0.0);

                    tampon = tb_inv.Text;
                    Double inv = Double.Parse(tampon);
                    unCash.Investissement = inv;

                    tampon = tb_txAct.Text;
                    Double txAct = Double.Parse(tampon);
                    unCash.TxActualisation = txAct;

                    tampon = tb_txAct.Text;
                    Double nbannees = Double.Parse(tampon);
                    unCash.NbAnnee = nbannees;

                }
                else
                    MessageBox.Show("Entrez les champs obligatoires");

                


            
            }
            else
            {
                 if ((tb_txAct.Text != "") && (tb_ann.Text != "") && (tb_ca.Text != "") && (tb_inv.Text != ""))
                {
                    String tampon;

                    tampon = tb_ca.Text;
                    Double ca = Double.Parse(tampon);
                    unCash.Ca.Add(ca);

                    if (tb_cv.Text != "")
                    {
                        tampon = tb_cv.Text;
                        Double cv = Double.Parse(tampon);
                        unCash.ChargesVariables.Add(cv);
                    }
                    else
                        unCash.ChargesVariables.Add(0.0);

                    if (tb_cf.Text != "")
                    {
                        tampon = tb_cf.Text;
                        Double cf = Double.Parse(tampon);
                        unCash.ChargesFixes.Add(cf);
                    }
                    else
                        unCash.ChargesFixes.Add(0.0);

                    tampon = tb_inv.Text;
                    Double inv = Double.Parse(tampon);
                    unCash.Investissement = inv;

                    tampon = tb_txAct.Text;
                    Double txAct = Double.Parse(tampon);
                    unCash.TxActualisation = txAct;

                    tampon = tb_txAct.Text;
                    Double nbannees = Double.Parse(tampon);
                    unCash.NbAnnee = nbannees;

                }
                else
                    MessageBox.Show("Entrez les champs obligatoires");

                
            this.Close();
        }}



        private void tb_inv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
               (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }
        }

        private void tb_ann_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
              (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }
        }

        private void tb_txAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
              (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }
        }

        private void tb_cf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
             (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }

        }

        private void tb_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
             (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }

        }

        private void tb_ca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) ||
             (e.KeyChar == (char)44))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Champ réservé aux valeurs numériques !");
            }

        }

        private void Fsaisie_Load(object sender, EventArgs e)
        {
            gb_infosAnnée.Text = "Informations pour l'année n°" + cpt;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            //tb_ann.Text == "";
        }


    }
}
