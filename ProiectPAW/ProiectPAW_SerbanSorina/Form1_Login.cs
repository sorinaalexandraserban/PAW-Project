using System;
using System.Collections;
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
    public partial class Form1_Login : Form
    {
        ArrayList listaClienti = new ArrayList();
        ArrayList listaUtilizatori = new ArrayList();
        int id;
        string nume;
        string prenume;
        string email;
        string tel;
        string adresa;
        string admin;

        public Form1_Login()
        {
            InitializeComponent();
        }

        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= 'a' && e.KeyChar <= 'z'
               || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "" || tbParola.Text == "")
                MessageBox.Show("Introduceti datele de conectare!");
            else
            {
                string username = tbUser.Text;
                string parola = tbParola.Text;
                string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
                OleDbConnection conexiune = new OleDbConnection(connString);
                OleDbCommand comanda = new OleDbCommand("SELECT * FROM utilizatori " +
                    "WHERE username= '" + username + "' AND parola='" + parola + "'", conexiune);
                try
                {
                    conexiune.Open();
                    OleDbDataReader reader = comanda.ExecuteReader();

                    int nr = 0;
                    while (reader.Read())
                    {
                        nr++;
                        id = (int)reader["cod_angajat"];
                        nume = reader["nume"].ToString();
                        prenume = reader["prenume"].ToString();
                        email = reader["email"].ToString();
                        tel = reader["telefon"].ToString();
                        adresa = reader["adresa"].ToString();
                        admin = reader["admin"].ToString();
                    }

                    if (nr == 0)
                    {
                        MessageBox.Show("Ati introdus date incorecte!");
                    }
                    else if (nr == 1)
                    {
                        Utilizator u = new Utilizator(id, nume, prenume, username,
                            parola, email, tel, adresa, admin, listaClienti);

                        Form frm = new Form2_Clienti(u, this);
                        tbUser.Clear();
                        tbParola.Clear();
                        this.Hide();
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Exista o eroare in baza de date!");
                    }

                    reader.Close();

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
        }
    }
}
