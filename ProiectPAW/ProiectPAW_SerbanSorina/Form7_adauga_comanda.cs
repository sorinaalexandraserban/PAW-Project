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
    public partial class Form7_adauga_comanda : Form
    {
        int cod_client;
        Utilizator user;
        Form2_Clienti frm_clienti;
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";


        void insertComanda(Comanda c)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            try
            {
                conexiune.Open();

                comanda.CommandText = "INSERT INTO comenzi VALUES (?,?,?,?,?,?,?,?,?)";
                comanda.Parameters.Add("nr_comanda", OleDbType.Integer).Value = c.NrComanda;
                comanda.Parameters.Add("cod_client", OleDbType.Integer).Value = cod_client;
                comanda.Parameters.Add("cod_angajat", OleDbType.Integer).Value = user.Cod;
                comanda.Parameters.Add("suma_comanda", OleDbType.Double).Value = c.SumaComanda;
                comanda.Parameters.Add("proc_discount", OleDbType.Integer).Value = c.ProcentDiscount;
                comanda.Parameters.Add("tip_pizza", OleDbType.Char).Value = c.TipPizza;
                comanda.ExecuteNonQuery();

                foreach (Client client in user.ListaClienti)
                {
                    if (client.Cod_client == cod_client)
                    {
                        if (client.Comenzi == null)
                            client.Comenzi = new ArrayList();
                        client.Comenzi.Add(c);
                    }
                }

                MessageBox.Show("Comanda adaugata cu succes in baza de date!");
                this.Close();
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

        public Form7_adauga_comanda(int cod_cl, Utilizator u, Form2_Clienti frm)
        {
            frm_clienti = frm;
            cod_client = cod_cl;
            user = u;

            InitializeComponent();
        }

        private void Form7_adauga_asigurare_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            bool error = false;
            conexiune.Open();
            OleDbCommand comanda = new OleDbCommand();
            comanda.Connection = conexiune;
            comanda.CommandText = "SELECT COUNT(nr_comanda) FROM comenzi";
            int nr_comenzi = Convert.ToInt32(comanda.ExecuteScalar());
            int cod_comanda;
            if (nr_comenzi == 0)
            {
                cod_comanda = 1;
            }
            else
            {
                comanda.CommandText = "SELECT MAX(nr_comanda) FROM comenzi";
                cod_comanda = Convert.ToInt32(comanda.ExecuteScalar());
                cod_comanda++;
            }

            if (tbSumaCom.Text == "")
            {
                errorProvider1.SetError(tbSumaCom, "Care este suma comenzii?");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbSumaCom, "");
            }

            if (tbDiscount.Text == "")
            {
                errorProvider1.SetError(tbDiscount, "Introduceti procent discount!");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbDiscount, "");
            }
            if (tbInfo.Text == "")
            {
                errorProvider1.SetError(tbInfo, "Adaugati detalii aferente comenzii");
                error = true;
            }
            else
            {
                errorProvider1.SetError(tbInfo, "");
            }

            if (!error)
            {
                float sumaComenzii = (float)Convert.ToDouble(tbSumaCom.Text);
                int procentDis = Convert.ToInt32(tbDiscount.Text);
                string info = tbInfo.Text;
            }
        }

        private void tbSumaCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else e.Handled = true;
        }

    }
}
