using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CheltuieliZilnice
{
    public partial class FormCategorii : Form
    {
        public FormCategorii()
        {
            InitializeComponent();
        }
        private void FormCategorii_Load(object sender, EventArgs e)
        {
            this.categorieTableAdapter.Fill(this.dataSet1.Categorie);
            A1();
        }
        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }
        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }


        private void A1()
        {
            
            this.categorieTableAdapter.Fill(this.dataSet1.Categorie);

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            txtId.ReadOnly = true;
            txtNume.ReadOnly = true;
            A3();
        }

        private void A2()
        {
            configureazaButoane(false);
            legareControale(false);
            protectiePanel(false);
            lblOp.Text = "ADAUGARE";
            lblNume.Text = "Adaugati categorie: ";
            txtNume.Focus();
            golireCampuri();

        }
        private void A3()
        {
            lblOp.Text = "";
            configureazaButoane(true);
            protectiePanel(true);
            legareControale(true);
            
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();
                txtNume.Focus();
                refresh_grid(categorieBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {


                modifica_inregistrare();
                refresh_grid(categorieBindingSource.Position);
                A3();
            }
            else
            {
                MessageBox.Show("Operatie actualizare neefectuata");
            }
        }
        private void A5(TextBox txtB)
        {
            string p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (txtB.Text == "") return;


            if (txtB == txtNume)
            {
                con.ConnectionString = categorieTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select IdCategorie From Categorie where UCASE(DenumireCategorie)=UCASE('" + txtNume.Text + "')";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Categoria exista!");
                        txtNume.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select IdCategorie From Categorie where UCASE(DenumireCategorie)=UCASE('" + txtNume.Text + "')" +
                        " AND IdCategorie <>" + txtId.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Categoria exista!");
                        txtNume.Focus();
                    }
                    con.Close();

                }
            }
        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";
            lblNume.Text = "Modificati categoria:";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = categorieTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            cmd.CommandText = "Select IdProdus From Produse where IdCategorie=" + txtId.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Categoria este referita in tabela Produse! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();

            con.ConnectionString = categorieTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            cmd.CommandText = "Delete From Categorie Where IdCategorie = " + txtId.Text;

            //MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(categorieBindingSource.Position);

        }

        private void txtNume_Leave(object sender, EventArgs e)
        {
            A5(txtNume);
        }
        private void refresh_grid(int p)
        {
            categorieTableAdapter.Fill(dataSet1.Categorie);
            categorieBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = categorieTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "DenumireCategorie = '" + txtNume.Text + "'";


            cmd.CommandText = "Update Categorie Set " + listaSet + " Where IdCategorie=" + txtId.Text;

           // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati denumirea categoriei!");
                txtNume.Focus();
                return false;
            }
            return true;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = categorieTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "DenumireCategorie";
            listaValori = "'" + txtNume.Text + "'";

            cmd.CommandText = "Insert into Categorie(" + listaCampuri + ") " +
                              "Select " + listaValori;

            // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtId.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtNume.Text = "";
            txtId.Text = "";
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;
            txtNume.Visible = !v;
            lblNume.Visible = !v;

            lblAdministare.Visible = v;
            btnAdaugare.Visible = v;
            btnModificare.Visible = v;
            btnStergere.Visible = v;
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                txtId.DataBindings.Add("Text", categorieBindingSource, "IdCategorie");
                txtNume.DataBindings.Add("Text", categorieBindingSource, "DenumireCategorie");
            }
            else
            {
                txtId.DataBindings.Clear();
                txtNume.DataBindings.Clear();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
