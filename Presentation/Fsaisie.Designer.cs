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
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ca = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_inv
            // 
            this.tb_inv.Location = new System.Drawing.Point(272, 96);
            this.tb_inv.Name = "tb_inv";
            this.tb_inv.Size = new System.Drawing.Size(100, 20);
            this.tb_inv.TabIndex = 0;
            this.tb_inv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_inv_KeyPress);
            // 
            // tb_ann
            // 
            this.tb_ann.Location = new System.Drawing.Point(623, 389);
            this.tb_ann.Name = "tb_ann";
            this.tb_ann.Size = new System.Drawing.Size(100, 20);
            this.tb_ann.TabIndex = 1;
            this.tb_ann.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ann_KeyPress);
            // 
            // tb_txAct
            // 
            this.tb_txAct.Location = new System.Drawing.Point(272, 200);
            this.tb_txAct.Name = "tb_txAct";
            this.tb_txAct.Size = new System.Drawing.Size(100, 20);
            this.tb_txAct.TabIndex = 2;
            this.tb_txAct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_txAct_KeyPress);
            // 
            // tb_cf
            // 
            this.tb_cf.Location = new System.Drawing.Point(623, 193);
            this.tb_cf.Name = "tb_cf";
            this.tb_cf.Size = new System.Drawing.Size(100, 20);
            this.tb_cf.TabIndex = 3;
            this.tb_cf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cf_KeyPress);
            // 
            // tb_cv
            // 
            this.tb_cv.Location = new System.Drawing.Point(623, 225);
            this.tb_cv.Name = "tb_cv";
            this.tb_cv.Size = new System.Drawing.Size(100, 20);
            this.tb_cv.TabIndex = 4;
            this.tb_cv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cv_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Montant investissement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre d\'années :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Taux d\'actualisation :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Charges Fixes  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 224);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(95, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chiffre d\'affaire :";
            // 
            // tb_ca
            // 
            this.tb_ca.Location = new System.Drawing.Point(272, 379);
            this.tb_ca.Name = "tb_ca";
            this.tb_ca.Size = new System.Drawing.Size(100, 20);
            this.tb_ca.TabIndex = 12;
            this.tb_ca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ca_KeyPress);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(134, 475);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 13;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(284, 475);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 14;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(70, 419);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(424, 23);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Cocher cette case si les valeurs sont les mêmes pour chaques année";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valeur résiduelle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Montant investissement matériels";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // Fsaisie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 523);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.tb_ca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_cv);
            this.Controls.Add(this.tb_cf);
            this.Controls.Add(this.tb_txAct);
            this.Controls.Add(this.tb_ann);
            this.Controls.Add(this.tb_inv);
            this.Name = "Fsaisie";
            this.Text = "Fsaisie";
            this.Load += new System.EventHandler(this.Fsaisie_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ca;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}