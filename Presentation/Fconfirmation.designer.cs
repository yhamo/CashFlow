namespace WindowsCashFlow
{
    partial class Fconfirmation
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
            this.lb_inv = new System.Windows.Forms.Label();
            this.lb_taux = new System.Windows.Forms.Label();
            this.lb_nbAnnees = new System.Windows.Forms.Label();
            this.lb_resid = new System.Windows.Forms.Label();
            this.lb_invMat = new System.Windows.Forms.Label();
            this.dg_conf = new System.Windows.Forms.DataGridView();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_conf)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_inv
            // 
            this.lb_inv.AutoSize = true;
            this.lb_inv.Location = new System.Drawing.Point(97, 44);
            this.lb_inv.Name = "lb_inv";
            this.lb_inv.Size = new System.Drawing.Size(92, 13);
            this.lb_inv.TabIndex = 0;
            this.lb_inv.Text = "Investissement  :  ";
            // 
            // lb_taux
            // 
            this.lb_taux.AutoSize = true;
            this.lb_taux.Location = new System.Drawing.Point(97, 87);
            this.lb_taux.Name = "lb_taux";
            this.lb_taux.Size = new System.Drawing.Size(88, 13);
            this.lb_taux.TabIndex = 1;
            this.lb_taux.Text = "taux Actualisé  :  ";
            // 
            // lb_nbAnnees
            // 
            this.lb_nbAnnees.AutoSize = true;
            this.lb_nbAnnees.Location = new System.Drawing.Point(97, 137);
            this.lb_nbAnnees.Name = "lb_nbAnnees";
            this.lb_nbAnnees.Size = new System.Drawing.Size(100, 13);
            this.lb_nbAnnees.TabIndex = 2;
            this.lb_nbAnnees.Text = "Nombre d\'année  :  ";
            // 
            // lb_resid
            // 
            this.lb_resid.AutoSize = true;
            this.lb_resid.Location = new System.Drawing.Point(97, 178);
            this.lb_resid.Name = "lb_resid";
            this.lb_resid.Size = new System.Drawing.Size(89, 13);
            this.lb_resid.TabIndex = 3;
            this.lb_resid.Text = "Valeur Residuelle";
            // 
            // lb_invMat
            // 
            this.lb_invMat.AutoSize = true;
            this.lb_invMat.Location = new System.Drawing.Point(97, 221);
            this.lb_invMat.Name = "lb_invMat";
            this.lb_invMat.Size = new System.Drawing.Size(130, 13);
            this.lb_invMat.TabIndex = 4;
            this.lb_invMat.Text = "investissement materiel  :  ";
            // 
            // dg_conf
            // 
            this.dg_conf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_conf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ca,
            this.cf,
            this.cv});
            this.dg_conf.Location = new System.Drawing.Point(114, 286);
            this.dg_conf.Name = "dg_conf";
            this.dg_conf.Size = new System.Drawing.Size(353, 189);
            this.dg_conf.TabIndex = 5;
            this.dg_conf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ca
            // 
            this.ca.HeaderText = "Chiffre d\'affaire";
            this.ca.Name = "ca";
            // 
            // cf
            // 
            this.cf.HeaderText = "Charges Fixes ";
            this.cf.Name = "cf";
            // 
            // cv
            // 
            this.cv.HeaderText = "Charges Variables";
            this.cv.Name = "cv";
            // 
            // Fconfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 499);
            this.Controls.Add(this.dg_conf);
            this.Controls.Add(this.lb_invMat);
            this.Controls.Add(this.lb_resid);
            this.Controls.Add(this.lb_nbAnnees);
            this.Controls.Add(this.lb_taux);
            this.Controls.Add(this.lb_inv);
            this.Name = "Fconfirmation";
            this.Text = "Fconfirmation";
            this.Load += new System.EventHandler(this.Fconfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_conf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_inv;
        private System.Windows.Forms.Label lb_taux;
        private System.Windows.Forms.Label lb_nbAnnees;
        private System.Windows.Forms.Label lb_resid;
        private System.Windows.Forms.Label lb_invMat;
        private System.Windows.Forms.DataGridView dg_conf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn cf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cv;
    }
}