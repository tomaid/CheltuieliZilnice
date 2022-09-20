using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CheltuieliZilnice
{
    public partial class FormLogin : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public FormLogin()
        {
            InitializeComponent();
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Autentificare";
            else btnStart.Text = "Log Out";
        }
        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                   "Data Source=C:\\Users\\pc\\Facultate\\Anul3\\Sem1\\TAP\\proiect\\CheltuieliZilnice\\cheltuieli.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (btnStart.Text == "Autentificare")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void categoriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategorii fc = new FormCategorii();
            fc.ShowDialog();

        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduse fp = new FormProduse();
            fp.ShowDialog();
        }

        private void cheltuieliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVizualizareCheltuieli fch = new FormVizualizareCheltuieli();
            fch.ShowDialog();
        }
    }

}

