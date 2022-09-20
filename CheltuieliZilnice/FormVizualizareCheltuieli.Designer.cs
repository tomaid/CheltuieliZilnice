
namespace CheltuieliZilnice
{
    partial class FormVizualizareCheltuieli
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cheltuieliContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new CheltuieliZilnice.DataSet3();
            this.txtIdCheltuiala = new System.Windows.Forms.TextBox();
            this.cheltuieli1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCheltuialaNoua = new System.Windows.Forms.Button();
            this.btnModificaCheltuiala = new System.Windows.Forms.Button();
            this.btnStergeCheltuiala = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCheltuialaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieli1TableAdapter = new CheltuieliZilnice.DataSet3TableAdapters.Cheltuieli1TableAdapter();
            this.cheltuieliContinutTableAdapter = new CheltuieliZilnice.DataSet3TableAdapters.CheltuieliContinutTableAdapter();
            this.idCheltuialaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieli1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn1,
            this.idProdusDataGridViewTextBoxColumn,
            this.denumireProdusDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.denumireCategorieDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.cheltuieliContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 227);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1091, 211);
            this.dataGridView2.TabIndex = 1;
            // 
            // cheltuieliContinutBindingSource
            // 
            this.cheltuieliContinutBindingSource.DataMember = "CheltuieliContinut";
            this.cheltuieliContinutBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdCheltuiala
            // 
            this.txtIdCheltuiala.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cheltuieli1BindingSource1, "IdCheltuiala", true));
            this.txtIdCheltuiala.Location = new System.Drawing.Point(1607, 34);
            this.txtIdCheltuiala.Name = "txtIdCheltuiala";
            this.txtIdCheltuiala.Size = new System.Drawing.Size(156, 22);
            this.txtIdCheltuiala.TabIndex = 2;
            // 
            // cheltuieli1BindingSource1
            // 
            this.cheltuieli1BindingSource1.DataMember = "Cheltuieli1";
            this.cheltuieli1BindingSource1.DataSource = this.dataSet3;
            this.cheltuieli1BindingSource1.PositionChanged += new System.EventHandler(this.cheltuieli1BindingSource1_PositionChanged);
            // 
            // btnCheltuialaNoua
            // 
            this.btnCheltuialaNoua.Location = new System.Drawing.Point(886, 34);
            this.btnCheltuialaNoua.Name = "btnCheltuialaNoua";
            this.btnCheltuialaNoua.Size = new System.Drawing.Size(156, 32);
            this.btnCheltuialaNoua.TabIndex = 3;
            this.btnCheltuialaNoua.Text = "Cheltuiala Noua";
            this.btnCheltuialaNoua.UseVisualStyleBackColor = true;
            this.btnCheltuialaNoua.Click += new System.EventHandler(this.btnCheltuialaNoua_Click);
            // 
            // btnModificaCheltuiala
            // 
            this.btnModificaCheltuiala.Location = new System.Drawing.Point(886, 102);
            this.btnModificaCheltuiala.Name = "btnModificaCheltuiala";
            this.btnModificaCheltuiala.Size = new System.Drawing.Size(156, 32);
            this.btnModificaCheltuiala.TabIndex = 4;
            this.btnModificaCheltuiala.Text = "Modificare Cheltuiala";
            this.btnModificaCheltuiala.UseVisualStyleBackColor = true;
            this.btnModificaCheltuiala.Click += new System.EventHandler(this.btnModificaCheltuiala_Click);
            // 
            // btnStergeCheltuiala
            // 
            this.btnStergeCheltuiala.Location = new System.Drawing.Point(886, 170);
            this.btnStergeCheltuiala.Name = "btnStergeCheltuiala";
            this.btnStergeCheltuiala.Size = new System.Drawing.Size(156, 33);
            this.btnStergeCheltuiala.TabIndex = 5;
            this.btnStergeCheltuiala.Text = "Sterge Cheltuiala";
            this.btnStergeCheltuiala.UseVisualStyleBackColor = true;
            this.btnStergeCheltuiala.Click += new System.EventHandler(this.btnStergeCheltuiala_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCheltuialaDataGridViewTextBoxColumn,
            this.dataCheltuialaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieli1BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(22, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 169);
            this.dataGridView1.TabIndex = 6;
            // 
            // idCheltuialaDataGridViewTextBoxColumn
            // 
            this.idCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCheltuialaDataGridViewTextBoxColumn.Name = "idCheltuialaDataGridViewTextBoxColumn";
            this.idCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCheltuialaDataGridViewTextBoxColumn.Visible = false;
            this.idCheltuialaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataCheltuialaDataGridViewTextBoxColumn
            // 
            this.dataCheltuialaDataGridViewTextBoxColumn.DataPropertyName = "DataCheltuiala";
            this.dataCheltuialaDataGridViewTextBoxColumn.HeaderText = "DataCheltuiala";
            this.dataCheltuialaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataCheltuialaDataGridViewTextBoxColumn.Name = "dataCheltuialaDataGridViewTextBoxColumn";
            this.dataCheltuialaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCheltuialaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // cheltuieli1TableAdapter
            // 
            this.cheltuieli1TableAdapter.ClearBeforeFill = true;
            // 
            // cheltuieliContinutTableAdapter
            // 
            this.cheltuieliContinutTableAdapter.ClearBeforeFill = true;
            // 
            // idCheltuialaDataGridViewTextBoxColumn1
            // 
            this.idCheltuialaDataGridViewTextBoxColumn1.DataPropertyName = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.HeaderText = "IdCheltuiala";
            this.idCheltuialaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idCheltuialaDataGridViewTextBoxColumn1.Name = "idCheltuialaDataGridViewTextBoxColumn1";
            this.idCheltuialaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idCheltuialaDataGridViewTextBoxColumn1.Visible = false;
            this.idCheltuialaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdusDataGridViewTextBoxColumn.Visible = false;
            this.idProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireProdusDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 125;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireCategorieDataGridViewTextBoxColumn
            // 
            this.denumireCategorieDataGridViewTextBoxColumn.DataPropertyName = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.HeaderText = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireCategorieDataGridViewTextBoxColumn.Name = "denumireCategorieDataGridViewTextBoxColumn";
            this.denumireCategorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SpImagine";
            this.dataGridViewTextBoxColumn1.HeaderText = "SpImagine";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // FormVizualizareCheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStergeCheltuiala);
            this.Controls.Add(this.btnModificaCheltuiala);
            this.Controls.Add(this.btnCheltuialaNoua);
            this.Controls.Add(this.txtIdCheltuiala);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormVizualizareCheltuieli";
            this.Text = "Cheltuieli";
            this.Load += new System.EventHandler(this.FormVizualizareCheltuieli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieli1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdCheltuiala;
        private System.Windows.Forms.Button btnCheltuialaNoua;
        private System.Windows.Forms.Button btnModificaCheltuiala;
        private System.Windows.Forms.Button btnStergeCheltuiala;
        private DataSet3 dataSet3;
        private DataSet3TableAdapters.Cheltuieli1TableAdapter cheltuieli1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cheltuieli1BindingSource1;
        private System.Windows.Forms.DataGridViewImageColumn denumireCategorieDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cheltuieliContinutBindingSource;
        private DataSet3TableAdapters.CheltuieliContinutTableAdapter cheltuieliContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCheltuialaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCheltuialaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}