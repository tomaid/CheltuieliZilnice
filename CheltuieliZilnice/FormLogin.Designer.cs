
namespace CheltuieliZilnice
{
    partial class FormLogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheltuieliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriiToolStripMenuItem,
            this.produseToolStripMenuItem,
            this.cheltuieliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriiToolStripMenuItem
            // 
            this.categoriiToolStripMenuItem.Name = "categoriiToolStripMenuItem";
            this.categoriiToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.categoriiToolStripMenuItem.Text = "Categorii";
            this.categoriiToolStripMenuItem.Click += new System.EventHandler(this.categoriiToolStripMenuItem_Click);
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // cheltuieliToolStripMenuItem
            // 
            this.cheltuieliToolStripMenuItem.Name = "cheltuieliToolStripMenuItem";
            this.cheltuieliToolStripMenuItem.Size = new System.Drawing.Size(85, 26);
            this.cheltuieliToolStripMenuItem.Text = "Cheltuieli";
            this.cheltuieliToolStripMenuItem.Click += new System.EventHandler(this.cheltuieliToolStripMenuItem_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(198, 70);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(357, 29);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Gestiunea cheltuielilor zilnice";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(252, 114);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(231, 25);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor: Toma Ionut-Daniel";
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(340, 175);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(138, 22);
            this.txtUtilizator.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(340, 218);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(138, 22);
            this.txtParola.TabIndex = 4;
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilizator.Location = new System.Drawing.Point(244, 175);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(81, 20);
            this.lblUtilizator.TabIndex = 5;
            this.lblUtilizator.Text = "Utilizator:";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParola.Location = new System.Drawing.Point(244, 218);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(62, 20);
            this.lblParola.TabIndex = 6;
            this.lblParola.Text = "Parola:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(340, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Autentificare";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormLogin";
            this.Text = "Cheltuieli Zilnice";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheltuieliToolStripMenuItem;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblUtilizator;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnStart;
    }
}

