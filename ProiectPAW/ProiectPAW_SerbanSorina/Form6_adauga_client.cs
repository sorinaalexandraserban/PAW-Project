using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_SerbanSorina
{
    public partial class Form6_adauga_client : Form
    {
        Utilizator user;
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";

        public Form6_adauga_client(Utilizator u, Form2_Clienti frm)
        {
            user = u;
            frm_clienti = frm;
            InitializeComponent();
        }

        void insertClient(Client c)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();

                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT COUNT(cod_client) FROM clienti";
                int nr_clienti = Convert.ToInt32(comanda.ExecuteScalar());
                int cod_cl;
                if (nr_clienti == 0)
                {
                    cod_cl = 1;
                }
                else
                {
                    comanda.CommandText = "SELECT MAX(cod_client) FROM clienti";
                    cod_cl = Convert.ToInt32(comanda.ExecuteScalar());
                    cod_cl++;
                }
                c.Cod_client = cod_cl;
                comanda.CommandText = "INSERT INTO clienti VALUES (?,?,?,?,?,?)";
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_cl;
                comanda.Parameters.Add("cod_angajat", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("adresa", OleDbType.Char, 30).Value = c.Adresa;
                comanda.Parameters.Add("nr_telefon", OleDbType.Char, 10).Value = c.NrTelefon;
                comanda.Parameters.Add("email", OleDbType.Char, 50).Value = c.Email;
                comanda.ExecuteNonQuery();

                MessageBox.Show("Client adaugat cu succes!");
                this.Close();
                frm_clienti.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;   
                
                if (tbAdresa.Text == "")
                {
                    errorProvider1.SetError(tbAdresa, "Introduceti adresa");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbAdresa, "");
                }

                if (tbNrTel.Text == "")
                {
                    errorProvider1.SetError(tbNrTel, "Introduceti telefon");
                    error = true;
                }
                else if (tbNrTel.Text.Length != 10)
                {
                    errorProvider1.SetError(tbNrTel, "10 caractere!");
                }
                else
                {
                    errorProvider1.SetError(tbNrTel, "");
                }
                if (tbEmail.Text == "")
                {
                    errorProvider1.SetError(tbEmail, "Introduceti email");
                    error = true;
                }
                else if (!IsValidEmail(tbEmail.Text))
                {
                    errorProvider1.SetError(tbEmail, "Email invalid");
                    error = true;
                }
                else
                {
                    errorProvider1.SetError(tbEmail, "");
                }

                if (!error)
                {
                    string adresa = tbAdresa.Text;
                    string nrTel = tbNrTel.Text;
                    string email = tbEmail.Text;

                    Client c = new Client(adresa,nrTel,email);
                    insertClient(c);
                }
        }

        private void Form6_adauga_client_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }
    }
}
