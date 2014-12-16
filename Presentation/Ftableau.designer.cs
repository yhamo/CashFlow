namespace WindowsCashFlow
{
    partial class Ftableau
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabCashFLow = new System.Windows.Forms.TabPage();
            this.dg_cash = new System.Windows.Forms.DataGridView();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCashFlowAct = new System.Windows.Forms.TabPage();
            this.dg_CashActualise = new System.Windows.Forms.DataGridView();
            this.tabConclusion = new System.Windows.Forms.TabPage();
            this.lb_conc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_marche = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbControl.SuspendLayout();
            this.tabCashFLow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cash)).BeginInit();
            this.tabCashFlowAct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_CashActualise)).BeginInit();
            this.tabConclusion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabCashFLow);
            this.tbControl.Controls.Add(this.tabCashFlowAct);
            this.tbControl.Controls.Add(this.tabConclusion);
            this.tbControl.Location = new System.Drawing.Point(60, 92);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(621, 367);
            this.tbControl.TabIndex = 0;
            // 
            // tabCashFLow
            // 
            this.tabCashFLow.Controls.Add(this.dg_cash);
            this.tabCashFLow.Location = new System.Drawing.Point(4, 22);
            this.tabCashFLow.Name = "tabCashFLow";
            this.tabCashFLow.Padding = new System.Windows.Forms.Padding(3);
            this.tabCashFLow.Size = new System.Drawing.Size(613, 341);
            this.tabCashFLow.TabIndex = 0;
            this.tabCashFLow.Text = "CashFlow";
            this.tabCashFLow.UseVisualStyleBackColor = true;
            // 
            // dg_cash
            // 
            this.dg_cash.AllowDrop = true;
            this.dg_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cash.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titre});
            this.dg_cash.Location = new System.Drawing.Point(6, 6);
            this.dg_cash.Name = "dg_cash";
            this.dg_cash.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dg_cash.Size = new System.Drawing.Size(601, 329);
            this.dg_cash.TabIndex = 0;
            this.dg_cash.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_cash_CellContentClick);
            // 
            // titre
            // 
            this.titre.HeaderText = "";
            this.titre.Name = "titre";
            // 
            // tabCashFlowAct
            // 
            this.tabCashFlowAct.Controls.Add(this.dg_CashActualise);
            this.tabCashFlowAct.Location = new System.Drawing.Point(4, 22);
            this.tabCashFlowAct.Name = "tabCashFlowAct";
            this.tabCashFlowAct.Padding = new System.Windows.Forms.Padding(3);
            this.tabCashFlowAct.Size = new System.Drawing.Size(613, 341);
            this.tabCashFlowAct.TabIndex = 1;
            this.tabCashFlowAct.Text = "CashFlow Actualisé";
            this.tabCashFlowAct.UseVisualStyleBackColor = true;
            // 
            // dg_CashActualise
            // 
            this.dg_CashActualise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_CashActualise.Location = new System.Drawing.Point(6, 6);
            this.dg_CashActualise.Name = "dg_CashActualise";
            this.dg_CashActualise.Size = new System.Drawing.Size(601, 329);
            this.dg_CashActualise.TabIndex = 0;
            // 
            // tabConclusion
            // 
            this.tabConclusion.Controls.Add(this.groupBox1);
            this.tabConclusion.Controls.Add(this.gb_marche);
            this.tabConclusion.Location = new System.Drawing.Point(4, 22);
            this.tabConclusion.Name = "tabConclusion";
            this.tabConclusion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConclusion.Size = new System.Drawing.Size(613, 341);
            this.tabConclusion.TabIndex = 2;
            this.tabConclusion.Text = "Conclusion";
            this.tabConclusion.UseVisualStyleBackColor = true;
            // 
            // lb_conc
            // 
            this.lb_conc.AutoSize = true;
            this.lb_conc.Location = new System.Drawing.Point(63, 71);
            this.lb_conc.Name = "lb_conc";
            this.lb_conc.Size = new System.Drawing.Size(35, 13);
            this.lb_conc.TabIndex = 0;
            this.lb_conc.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Résultat de la simulation";
            // 
            // gb_marche
            // 
            this.gb_marche.BackgroundImage = global::Presentation.Properties.Resources.vial;
            this.gb_marche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gb_marche.Location = new System.Drawing.Point(6, 39);
            this.gb_marche.Name = "gb_marche";
            this.gb_marche.Size = new System.Drawing.Size(269, 296);
            this.gb_marche.TabIndex = 1;
            this.gb_marche.TabStop = false;
            this.gb_marche.Text = "M.Vial";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Presentation.Properties.Resources.bulle;
            this.groupBox1.Controls.Add(this.lb_conc);
            this.groupBox1.Location = new System.Drawing.Point(281, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Ftableau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbControl);
            this.Name = "Ftableau";
            this.Text = "Ftableau";
            this.Load += new System.EventHandler(this.Ftableau_Load);
            this.tbControl.ResumeLayout(false);
            this.tabCashFLow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cash)).EndInit();
            this.tabCashFlowAct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_CashActualise)).EndInit();
            this.tabConclusion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabCashFLow;
        private System.Windows.Forms.TabPage tabCashFlowAct;
        private System.Windows.Forms.DataGridView dg_CashActualise;
        private System.Windows.Forms.TabPage tabConclusion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.Label lb_conc;
        private System.Windows.Forms.GroupBox gb_marche;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}