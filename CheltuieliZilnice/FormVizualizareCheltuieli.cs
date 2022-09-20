using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CheltuieliZilnice
{
    public partial class FormVizualizareCheltuieli : Form
    {
        public FormVizualizareCheltuieli()
        {
            InitializeComponent();
        }
        private void refreshGrid()
        {
            cheltuieli1TableAdapter.Fill(dataSet3.Cheltuieli1);
            cheltuieliContinutTableAdapter.Fill(dataSet3.CheltuieliContinut);
            try
            {
                cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + txtIdCheltuiala.Text;
            }
            catch { }
        }
        private void FormVizualizareCheltuieli_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataSet3.CheltuieliContinut' table. You can move, or remove it, as needed.
            this.cheltuieliContinutTableAdapter.Fill(this.dataSet3.CheltuieliContinut);
            // TODO: This line of code loads data into the 'dataSet3.Cheltuieli1' table. You can move, or remove it, as needed.
            this.cheltuieli1TableAdapter.Fill(this.dataSet3.Cheltuieli1);
            refreshGrid();

            try
            {
                cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + txtIdCheltuiala.Text;
            }
            catch { }
        }

        private void btnCheltuialaNoua_Click(object sender, EventArgs e)
        {
            FormCheltuieli f = new FormCheltuieli();
            f.ShowDialog();
            refreshGrid();

        }

        private void btnStergeCheltuiala_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = cheltuieli1TableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut cheltuiala
            cmd.CommandText = "Delete From CheltuieliContinut Where IdCheltuiala = " + txtIdCheltuiala.Text;

            // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Cheltuieli Where IdCheltuiala = " + txtIdCheltuiala.Text;
           // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid();

        }

        private void btnModificaCheltuiala_Click(object sender, EventArgs e)
        {
            FormCheltuieli f = new FormCheltuieli();
            f.completeazaTitlu("MODIFICARE CHELTUIALA");
            f.bs1 = cheltuieli1BindingSource1;
            f.bs2 = cheltuieliContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
        }

        private void cheltuieli1BindingSource1_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                cheltuieliContinutBindingSource.Filter = "IdCheltuiala=" + txtIdCheltuiala.Text;
            }
            catch { }
        }
    }
}
