using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CheltuieliZilnice
{
    public partial class FormCheltuieli : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idCda;
        public BindingSource bs1;
        public BindingSource bs2;
        public FormCheltuieli()
        {
            InitializeComponent();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void FormCheltuieli_Load(object sender, EventArgs e)
        {

            this.produseTableAdapter.Fill(this.dataSet3.Produse);
            A1();
        }
        private void completeazaCheltuiala()
        {
            DataRowView current = (DataRowView)bs1.Current;
            idCda = (int)current["IdCheltuiala"];
            // Console.WriteLine(idCda);
            txtTotal.Text = current["Total"].ToString();
            // Console.WriteLine(txtTotal.Text);
            // MessageBox.Show(txtTotal.Text);
            dateTimePicker1.Value = Convert.ToDateTime(current["DataCheltuiala"]);
            bs2.MoveFirst();
            dataSet3.CheltuieliContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DataSet3.CheltuieliContinutManevraRow r = dataSet3.CheltuieliContinutManevra.NewCheltuieliContinutManevraRow();
                r.NrCrt = Convert.ToInt16(i);
                r.DenumireProdus = Convert.ToString(current["DenumireProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Pret = Convert.ToDecimal(current["Pret"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.DenumireCategorie = Convert.ToString(current["DenumireCategorie"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.Valoare = Convert.ToDecimal(current["Pret"]);
                r.SpImagine = Convert.ToString(current["SpImagine"]);

                dataSet3.CheltuieliContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(dataSet3.Produse);

            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretDataGridViewTextBoxColumn.ReadOnly = true;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            spImagineDataGridViewTextBoxColumn.ReadOnly = true;
            denumireCategorieDataGridViewTextBoxColumn.ReadOnly = true;

            if (lblOp.Text == "MODIFICARE CHELTUIALA") {
                dateTimePicker1.Enabled = false;
                completeazaCheltuiala(); }
            else
            {
                verificaData();
            }



        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE CHELTUIALA")
            {
                // modificaInregistrare();
                stergeContinut();
                adaugaInregistrariCheltuieliContinut();
                this.Close();
            }
            else if (lblOp.Text == "CHELTUIALA NOUA")
            {
                
                if (!verificaData()) return;
                adaugaInregistrareCheltuieli();
                cautaInregistrare();
                adaugaInregistrariCheltuieliContinut();
                golireCampuri();
            }
        }

        private void A3()
        {
            // Generare NrCrt
            try
            {
                DataRowView current = (DataRowView)cheltuieliContinutManevraBindingSource.Current;
                current["NrCrt"] = cheltuieliContinutManevraBindingSource.Position + 1;
            }
            catch { }

        }

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell == null) return;
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)produseBindingSource.Current;

                    dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];
                    dataGridView1.CurrentRow.Cells[7].Value = current["SpImagine"];
                    dataGridView1.CurrentRow.Cells[8].Value = current["DenumireCategorie"];

                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    cheltuieliContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }
        private void A20()
        {
            if (lblOp.Text != "MODIFICARE CHELTUIALA")
            {
                verificaData();
            }


        }

        private bool verificaData()
        {
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DateTime d = dateTimePicker1.Value;
            cmd.CommandText = "SELECT COUNT(idCheltuiala) From Cheltuieli Where DataCheltuiala = " + "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            int countcheltuiala = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
            if (countcheltuiala > 0) {
                if (dateTimePicker1.Value.Date == DateTime.Now.Date)
                {
                    MessageBox.Show("Data curenta este folosita. Alegeti alta data.");
                }
                else
                {
                    MessageBox.Show("Data selectata este folosita. Alegeti alta data.");
                }
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = " ";
                return false;
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Long;
                return true;
            }
            return true;
                
        }
        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet3.CheltuieliContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }

            txtTotal.Text = Convert.ToString(t);
        }


        private bool validareCampuriObligatorii()
        {

            // Validare completare continut
            if (cheltuieliContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut cheltuiala !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareCheltuieli()
        {
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "DataCheltuiala";
            listaValori = "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#";

            cmd.CommandText = "Insert into Cheltuieli(" + listaCampuri + ") " + "Select " + listaValori;

            // MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void cautaInregistrare()
        {
            DateTime d = dateTimePicker1.Value;
            cmd.CommandText = "SELECT idCheltuiala From Cheltuieli Where DataCheltuiala = " + "#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idCda = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariCheltuieliContinut()
        {
            string listaCampuri = "IdCheltuiala, IdProdus, Cantitate, Pret";
            string listaValori;

            con.Open();
            foreach (DataRow r in dataSet3.CheltuieliContinutManevra)
            {
                listaValori = idCda + "," + r["IdProdus"] + "," + r["Cantitate"] + "," + r["Pret"];

                cmd.CommandText = "Insert into CheltuieliContinut(" + listaCampuri + ") " + "Select " + listaValori;

                // MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void golireCampuri()
        {
            txtTotal.Text = "";
            dataSet3.CheltuieliContinutManevra.Clear();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdCheltuiala = " + idCda;

            string clauzaSet = "Set DataCheltuiala = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#";

            cmd.CommandText = "Update Cheltuieli " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete from CheltuieliContinut Where IdCheltuiala = " + idCda;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void cheltuieliContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            A20();
        }
    }
}
