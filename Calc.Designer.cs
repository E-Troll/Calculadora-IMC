namespace Calculadora_IMC
{
    partial class Calc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.btnimc = new System.Windows.Forms.Button();
            this.lbalt = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            this.txtal = new System.Windows.Forms.TextBox();
            this.txtps = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnimc
            // 
            resources.ApplyResources(this.btnimc, "btnimc");
            this.btnimc.Name = "btnimc";
            this.btnimc.UseVisualStyleBackColor = true;
            this.btnimc.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // lbalt
            // 
            resources.ApplyResources(this.lbalt, "lbalt");
            this.lbalt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbalt.Name = "lbalt";
            // 
            // lbpeso
            // 
            resources.ApplyResources(this.lbpeso, "lbpeso");
            this.lbpeso.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Click += new System.EventHandler(this.lbpeso_Click);
            // 
            // txtal
            // 
            resources.ApplyResources(this.txtal, "txtal");
            this.txtal.Name = "txtal";
            // 
            // txtps
            // 
            resources.ApplyResources(this.txtps, "txtps");
            this.txtps.Name = "txtps";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtps);
            this.Controls.Add(this.txtal);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbalt);
            this.Controls.Add(this.btnimc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnimc;
        private Label lbalt;
        private Label lbpeso;
        private TextBox txtal;
        private TextBox txtps;
        private Label label1;
    }
}