namespace WindowsCashFlow
{
    partial class Fsaisie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_inv = new System.Windows.Forms.TextBox();
            this.tb_ann = new System.Windows.Forms.TextBox();
            this.tb_txAct = new System.Windows.Forms.TextBox();
            this.tb_cf = new System.Windows.Forms.TextBox();
            this.tb_cv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_ValeurResiduelle = new System.Windows.Forms.TextBox();
            this.tb_Montant_investissement_materiels = new System.Windows.Forms.TextBox();
            this.gb_infosProjet = new System.Windows.Forms.GroupBox();
            this.gb_infosAnnée = new System.Windows.Forms.GroupBox();
            this.cb_MemeValeur = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_ca = new System.Windows.Forms.TextBox();
            this.gb_infosProjet.SuspendLayout();
            this.gb_infosAnnée.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_inv
            // 
            this.tb_inv.Location = new System.Drawing.Point(272, 31);
            this.tb_inv.Name = "tb_inv";
            this.tb_inv.Size = new System.Drawing.Size(100, 20);
            this.tb_inv.TabIndex = 0;
            this.tb_inv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_inv_KeyPress);
            // 
            // tb_ann
            // 
            this.tb_ann.Location = new System.Drawing.Point(272, 155);
            this.tb_ann.Name = "tb_ann";
            this.tb_ann.Size = new System.Drawing.Size(100, 20);
            this.tb_ann.TabIndex = 1;
            this.tb_ann.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ann_KeyPress);
            // 
            // tb_txAct
            // 
            this.tb_txAct.Location = new System.Drawing.Point(272, 115);
            this.tb_txAct.Name = "tb_txAct";
            this.tb_txAct.Size = new System.Drawing.Size(100, 20);
            this.tb_txAct.TabIndex = 2;
            this.tb_txAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_txAct_KeyPress);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(174, 68);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(100, 20);
            this.tb_cf.TabIndex = 3;
            this.tb_cf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cf_KeyPress);
            // 
            // tb_cv
            // 
            this.tb_cv.Location = new System.Drawing.Point(174, 100);
            this.tb_cv.Name = "tb_cv";
            this.tb_cv.Size = new System.Drawing.Size(100, 20);
            this.tb_cv.TabIndex = 4;
            this.tb_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(94, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Montant investissement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(132, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre d\'années :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(118, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taux d\'actualisation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Charges Fixes  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Charges Variables :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(153, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Saisie des données";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(313, 432);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 13;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(519, 432);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 14;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(132, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valeur résiduelle :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(36, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Montant investissement matériels :";
            // 
            // tb_ValeurResiduelle
            // 
            this.tb_ValeurResiduelle.Location = new System.Drawing.Point(272, 195);
            this.tb_ValeurResiduelle.Name = "tb_ValeurResiduelle";
            this.tb_ValeurResiduelle.Size = new System.Drawing.Size(100, 20);
            this.tb_ValeurResiduelle.TabIndex = 18;
            // 
            // tb_Montant_investissement_materiels
            // 
            this.tb_Montant_investissement_materiels.Location = new System.Drawing.Point(272, 77);
            this.tb_Montant_investissement_materiels.Name = "tb_Montant_investissement_materiels";
            this.tb_Montant_investissement_materiels.Size = new System.Drawing.Size(100, 20);
            this.tb_Montant_investissement_materiels.TabIndex = 19;
            // 
            // gb_infosProjet
            // 
            this.gb_infosProjet.Controls.Add(this.tb_ann);
            this.gb_infosProjet.Controls.Add(this.tb_Montant_investissement_materiels);
            this.gb_infosProjet.Controls.Add(this.tb_inv);
            this.gb_infosProjet.Controls.Add(this.tb_ValeurResiduelle);
            this.gb_infosProjet.Controls.Add(this.tb_txAct);
            this.gb_infosProjet.Controls.Add(this.label9);
            this.gb_infosProjet.Controls.Add(this.label1);
            this.gb_infosProjet.Controls.Add(this.label8);
            this.gb_infosProjet.Controls.Add(this.label2);
            this.gb_infosProjet.Controls.Add(this.label3);
            this.gb_infosProjet.Location = new System.Drawing.Point(12, 97);
            this.gb_infosProjet.Name = "gb_infosProjet";
            this.gb_infosProjet.Size = new System.Drawing.Size(431, 238);
            this.gb_infosProjet.TabIndex = 20;
            this.gb_infosProjet.TabStop = false;
            this.gb_infosProjet.Text = "Informations projet";
            // 
            // gb_infosAnnée
            // 
            this.gb_infosAnnée.Controls.Add(this.cb_MemeValeur);
            this.gb_infosAnnée.Controls.Add(this.label10);
            this.gb_infosAnnée.Controls.Add(this.tb_ca);
            this.gb_infosAnnée.Controls.Add(this.tb_cv);
            this.gb_infosAnnée.Controls.Add(this.tb_cf);
            this.gb_infosAnnée.Controls.Add(this.label4);
            this.gb_infosAnnée.Controls.Add(this.label5);
            this.gb_infosAnnée.Location = new System.Drawing.Point(471, 115);
            this.gb_infosAnnée.Name = "gb_infosAnnée";
            this.gb_infosAnnée.Size = new System.Drawing.Size(313, 269);
            this.gb_infosAnnée.TabIndex = 21;
            this.gb_infosAnnée.TabStop = false;
            this.gb_infosAnnée.Text = "informations Pour année n°";
            // 
            // cb_MemeValeur
            // 
            this.cb_MemeValeur.AutoSize = true;
            this.cb_MemeValeur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cb_MemeValeur.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MemeValeur.ForeColor = System.Drawing.Color.Red;
            this.cb_MemeValeur.Location = new System.Drawing.Point(32, 178);
            this.cb_MemeValeur.Name = "cb_MemeValeur";
            this.cb_MemeValeur.Size = new System.Drawing.Size(242, 42);
            this.cb_MemeValeur.TabIndex = 16;
            this.cb_MemeValeur.Text = "Cocher cette case si les valeurs\r\n sont les mêmes pour chaques année";
            this.cb_MemeValeur.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(44, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Chiffre d\'affaire :";
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(174, 138);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(100, 20);
            this.tb_ca.TabIndex = 14;
            // 
            // Fsaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 523);
            this.Controls.Add(this.gb_infosAnnée);
            this.Controls.Add(this.gb_infosProjet);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.label6);
            this.Name = "Fsaisie";
            this.Text = "Fsaisie";
            this.Load += new System.EventHandler(this.Fsaisie_Load);
            this.gb_infosProjet.ResumeLayout(false);
            this.gb_infosProjet.PerformLayout();
            this.gb_infosAnnée.ResumeLayout(false);
            this.gb_infosAnnée.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_inv;
        private System.Windows.Forms.TextBox tb_ann;
        private System.Windows.Forms.TextBox tb_txAct;
        private System.Windows.Forms.TextBox tb_cf;
        private System.Windows.Forms.TextBox tb_cv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_ValeurResiduelle;
        private System.Windows.Forms.TextBox tb_Montant_investissement_materiels;
        private System.Windows.Forms.GroupBox gb_infosProjet;
        private System.Windows.Forms.GroupBox gb_infosAnnée;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_ca;
        private System.Windows.Forms.CheckBox cb_MemeValeur;
    }
}