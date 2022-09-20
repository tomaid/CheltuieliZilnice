
namespace CheltuieliZilnice
{
    partial class FormCategorii
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.denumireCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CheltuieliZilnice.DataSet1();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.categorieTableAdapter = new CheltuieliZilnice.DataSet1TableAdapters.CategorieTableAdapter();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblAdministare = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.denumireCategorieDataGridViewTextBoxColumn,
            this.idCategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categorieBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // denumireCategorieDataGridViewTextBoxColumn
            // 
            this.denumireCategorieDataGridViewTextBoxColumn.DataPropertyName = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.HeaderText = "Denumire Categorie";
            this.denumireCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireCategorieDataGridViewTextBoxColumn.Name = "denumireCategorieDataGridViewTextBoxColumn";
            this.denumireCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireCategorieDataGridViewTextBoxColumn.Width = 200;
            // 
            // idCategorieDataGridViewTextBoxColumn
            // 
            this.idCategorieDataGridViewTextBoxColumn.DataPropertyName = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.HeaderText = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategorieDataGridViewTextBoxColumn.Name = "idCategorieDataGridViewTextBoxColumn";
            this.idCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCategorieDataGridViewTextBoxColumn.Visible = false;
            this.idCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(174, 33);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(166, 22);
            this.txtNume.TabIndex = 1;
            this.txtNume.Leave += new System.EventHandler(this.txtNume_Leave);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(12, 36);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(145, 17);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Introduceti categoria: ";
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(33, 75);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(94, 31);
            this.btnAdaugare.TabIndex = 3;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(148, 75);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 31);
            this.btnStergere.TabIndex = 4;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 449);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 6;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(244, 75);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(96, 31);
            this.btnModificare.TabIndex = 7;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(84, 75);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(90, 31);
            this.btnConfirmare.TabIndex = 8;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(197, 75);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(88, 31);
            this.btnRenuntare.TabIndex = 9;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(174, 453);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 17);
            this.lblOp.TabIndex = 10;
            // 
            // lblAdministare
            // 
            this.lblAdministare.AutoSize = true;
            this.lblAdministare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministare.Location = new System.Drawing.Point(28, 24);
            this.lblAdministare.Name = "lblAdministare";
            this.lblAdministare.Size = new System.Drawing.Size(247, 29);
            this.lblAdministare.TabIndex = 11;
            this.lblAdministare.Text = "Administrare categorii";
            this.lblAdministare.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCategorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 440);
            this.Controls.Add(this.lblAdministare);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCategorii";
            this.Text = "Categorii";
            this.Load += new System.EventHandler(this.FormCategorii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnStergere;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private DataSet1TableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblAdministare;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn;
    }
}