
namespace CheltuieliZilnice
{
    partial class FormProduse
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new CheltuieliZilnice.DataSet2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produseTableAdapter = new CheltuieliZilnice.DataSet2TableAdapters.ProduseTableAdapter();
            this.categorieTableAdapter = new CheltuieliZilnice.DataSet2TableAdapters.CategorieTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(379, 37);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(126, 40);
            this.btnActualizare.TabIndex = 0;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(686, 37);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(133, 40);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(849, 37);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(120, 40);
            this.btnRenuntare.TabIndex = 2;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.produseBindingSource, "SpImagine", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.pictureBox1.Location = new System.Drawing.Point(1018, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdusDataGridViewTextBoxColumn,
            this.denumireProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.idCategorieDataGridViewTextBoxColumn,
            this.denumireCategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 335);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            this.idProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCategorieDataGridViewTextBoxColumn
            // 
            this.idCategorieDataGridViewTextBoxColumn.DataPropertyName = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.HeaderText = "IdCategorie";
            this.idCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCategorieDataGridViewTextBoxColumn.Name = "idCategorieDataGridViewTextBoxColumn";
            this.idCategorieDataGridViewTextBoxColumn.Visible = false;
            this.idCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireCategorieDataGridViewTextBoxColumn
            // 
            this.denumireCategorieDataGridViewTextBoxColumn.DataPropertyName = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.DataSource = this.categorieBindingSource;
            this.denumireCategorieDataGridViewTextBoxColumn.DisplayMember = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireCategorieDataGridViewTextBoxColumn.HeaderText = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireCategorieDataGridViewTextBoxColumn.Name = "denumireCategorieDataGridViewTextBoxColumn";
            this.denumireCategorieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireCategorieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.denumireCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // categorieBindingSource
            // 
            this.categorieBindingSource.DataMember = "Categorie";
            this.categorieBindingSource.DataSource = this.dataSet2;
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // categorieTableAdapter
            // 
            this.categorieTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Administrare Produse";
            // 
            // btnStergere
            // 
            this.btnStergere.Enabled = false;
            this.btnStergere.Location = new System.Drawing.Point(528, 36);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(133, 40);
            this.btnStergere.TabIndex = 8;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Visible = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // FormProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Name = "FormProduse";
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.FormProduse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorieBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet2TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.BindingSource categorieBindingSource;
        private DataSet2TableAdapters.CategorieTableAdapter categorieTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStergere;
    }
}