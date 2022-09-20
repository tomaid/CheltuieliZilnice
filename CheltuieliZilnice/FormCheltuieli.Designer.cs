
namespace CheltuieliZilnice
{
    partial class FormCheltuieli
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet3 = new CheltuieliZilnice.DataSet3();
            this.cheltuieliContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblOp = new System.Windows.Forms.Label();
            this.produseTableAdapter = new CheltuieliZilnice.DataSet3TableAdapters.ProduseTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutManevraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(302, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(302, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(96, 22);
            this.txtTotal.TabIndex = 3;
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(830, 83);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(96, 35);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCrtDataGridViewTextBoxColumn,
            this.denumireProdusDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idProdusDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn,
            this.denumireCategorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 293);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // produseBindingSource
            // 
            this.produseBindingSource.DataMember = "Produse";
            this.produseBindingSource.DataSource = this.dataSet3;
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cheltuieliContinutManevraBindingSource
            // 
            this.cheltuieliContinutManevraBindingSource.DataMember = "CheltuieliContinutManevra";
            this.cheltuieliContinutManevraBindingSource.DataSource = this.dataSet3;
            this.cheltuieliContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.cheltuieliContinutManevraBindingSource_CurrentChanged);
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(827, 34);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(136, 17);
            this.lblOp.TabIndex = 6;
            this.lblOp.Text = "CHELTUIALA NOUA";
            // 
            // produseTableAdapter
            // 
            this.produseTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Inregistrati cheltuieli pentru data de:";
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.Width = 70;
            // 
            // denumireProdusDataGridViewTextBoxColumn
            // 
            this.denumireProdusDataGridViewTextBoxColumn.DataPropertyName = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.DataSource = this.produseBindingSource;
            this.denumireProdusDataGridViewTextBoxColumn.DisplayMember = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.denumireProdusDataGridViewTextBoxColumn.HeaderText = "DenumireProdus";
            this.denumireProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireProdusDataGridViewTextBoxColumn.Name = "denumireProdusDataGridViewTextBoxColumn";
            this.denumireProdusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.denumireProdusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.pretDataGridViewTextBoxColumn.Width = 70;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.Width = 70;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 70;
            // 
            // idProdusDataGridViewTextBoxColumn
            // 
            this.idProdusDataGridViewTextBoxColumn.DataPropertyName = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.HeaderText = "IdProdus";
            this.idProdusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProdusDataGridViewTextBoxColumn.Name = "idProdusDataGridViewTextBoxColumn";
            this.idProdusDataGridViewTextBoxColumn.Width = 70;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Width = 125;
            // 
            // denumireCategorieDataGridViewTextBoxColumn
            // 
            this.denumireCategorieDataGridViewTextBoxColumn.DataPropertyName = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.HeaderText = "DenumireCategorie";
            this.denumireCategorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireCategorieDataGridViewTextBoxColumn.Name = "denumireCategorieDataGridViewTextBoxColumn";
            this.denumireCategorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormCheltuieli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormCheltuieli";
            this.Text = "Cheltuieli";
            this.Load += new System.EventHandler(this.FormCheltuieli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliContinutManevraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.BindingSource cheltuieliContinutManevraBindingSource;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource produseBindingSource;
        private DataSet3TableAdapters.ProduseTableAdapter produseTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn denumireProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireCategorieDataGridViewTextBoxColumn;
    }
}