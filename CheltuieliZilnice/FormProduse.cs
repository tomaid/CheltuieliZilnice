using System;
using System.Data;
using System.Windows.Forms;

namespace CheltuieliZilnice
{
    public partial class FormProduse : Form
    {
        const int IdProdusIndex = 0;
        const int DenumireProdusIndex = 1;
        const int UMIndex = 2;
        const int PretIndex = 3;
        const int SpImagineIndex = 4;
        const int IdCategorieIndex = 5;
        const int DenumireCategorieIndex = 6;



        public FormProduse()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.ReadOnly = v;

            btnActualizare.Enabled = v;
           // btnStergere.Visible = v;

            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }

        private void refresh()
        {
            produseTableAdapter.Fill(dataSet2.Produse);
            categorieTableAdapter.Fill(dataSet2.Categorie);
            completeazaCategorie();
        }

        private void FormProduse_Load(object sender, EventArgs e)
        {
            refresh();
            config(true);
            btnStergere.Visible = false;
            dataGridView1.Columns[IdProdusIndex].ReadOnly = true;
            dataGridView1.Columns[IdCategorieIndex].ReadOnly = true;




        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                produseTableAdapter.Update(dataSet2.Produse);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }


        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            config(true);
            refresh();

        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;

        }
        private void completeazaCategorie()
        {
            String idCat;
            int idCategorie;
            DataRow r;
            foreach (DataRowView x in produseBindingSource)
            {
                idCat = x["IdCategorie"].ToString();
                idCategorie = Convert.ToInt32(idCat);
                r = dataSet2.Tables["Categorie"].Rows.Find(idCategorie);
                if (r != null)
                {
                    x["DenumireCategorie"] = r[1].ToString();
                }
                else
                {
                    MessageBox.Show("Nu exista categoria cu id " + idCategorie);
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView crt;
            try
            {
                if (dataGridView1.CurrentCell == null) return;
                if (dataGridView1.CurrentCell.ColumnIndex == DenumireCategorieIndex)
                {
                    crt = (DataRowView)categorieBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[IdCategorieIndex].Value = crt["IdCategorie"];
                }
            }
            catch { }

        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            // String idProd;
            // int idProdus;
            String idCat;
            int idCategorie;
            DataRow rr;
            foreach (DataRow r in dataSet2.Produse)
            {
                // idProd = r["IdProdus"].ToString();
                // idProdus = Convert.ToInt32(r["IdProdus"]);
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["DenumireProdus"] == DBNull.Value)
                {
                    MessageBox.Show("Completati campul DenumireProdus la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
                if (r["Pret"] == DBNull.Value)
                {
                    MessageBox.Show("Completati campul Pret la linia cu Id " + r["IdProdus"]);
                    raspuns = false;
                }
                idCat = r["IdCategorie"].ToString();
                idCategorie = Convert.ToInt32(idCat);
                rr = dataSet2.Tables["Categorie"].Rows.Find(idCategorie);
                if (rr != null)
                {
                    r["DenumireCategorie"] = rr[1].ToString();
                    raspuns = true;
                }
                else
                {
                    MessageBox.Show("Selectati categoria la linia cu Id " + idCategorie);
                    raspuns = false;
                }
            }
            return raspuns;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

            if (dataGridView1.CurrentCell.ColumnIndex == SpImagineIndex)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName; ;
                    dataGridView1.CurrentRow.Cells[SpImagineIndex].Value = s;
                    pictureBox1.ImageLocation = s;
                }

        }
        
        private void btnStergere_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                    dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            }
        }
        
    }
}
