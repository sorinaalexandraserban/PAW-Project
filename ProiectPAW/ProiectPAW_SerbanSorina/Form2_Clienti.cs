using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProiectPAW_SerbanSorina
{
    public partial class Form2_Clienti : Form
    {
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
        string numeCl = "";
        Form1_Login frm_login;
        Utilizator user;

        void initializareListaClienti()
        {

            listViewClienti.Columns.Add("Cod", 50);
            listViewClienti.Columns.Add("Adresa", 150);
            listViewClienti.Columns.Add("Nr. telefon", 90);
            listViewClienti.Columns.Add("Email", 150);
        }


        public Form2_Clienti(Utilizator u, Form1_Login frm)
        {
            frm_login = frm;
            user = u;
            InitializeComponent();

            this.search.Conn = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = comenzi.accdb";
            this.search.Tabela1 = "clienti";
            this.search.Coloana = "nume";
            this.search.JoinCol = "cod_client";

            if (user.Admin == "da")
            {
                btnVeziUtilizatori.Visible = true;
                btnAdaugaUtilizator.Visible = true;
            }

            initializareListaClienti();

            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbCommand comanda = new OleDbCommand("SELECT * FROM clienti", conexiune);
            try
            {
                //conexiune.Open();
                //OleDbCommand getName = new OleDbCommand("SELECT nume, prenume FROM utilizatori " +
                //"WHERE cod_angajat=" + user.Cod, conexiune);
                //OleDbDataReader reader = getName.ExecuteReader();
                //string nume = "";
                //if (reader.Read())
                //    nume = reader["nume"] + " " + reader["prenume"];

                //label2.Text += " " + nume;
                conexiune.Open();
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["cod_client"].ToString());
                    item.SubItems.Add(reader["email"].ToString());
                    item.SubItems.Add(reader["nr_telefon"].ToString());
                    item.SubItems.Add(reader["adresa"].ToString());
                    listViewClienti.Items.Add(item);
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
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form6_adauga_client(user, this);
            Hide();
            frm.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listViewClienti.Clear();
        }

        private void btnVeziUtilizatori_Click(object sender, EventArgs e)
        {
            Form frm = new Form5_vezi_utilizatori(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void btnAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            Form frm = new Form4_adauga_utilizator(this);
            this.Hide();
            frm.ShowDialog();
        }

        private void veziComenziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cod_client = 0;
            foreach (ListViewItem item in listViewClienti.Items)
                if (item.Selected)
                {
                    cod_client = Convert.ToInt32(item.SubItems[0].Text);
                    numeCl = item.SubItems[1].Text + " " + item.SubItems[2].Text;
                }
            Form frm = new Form3_Comenzi(cod_client, user, numeCl, this); //cod = cod_angajat
            this.Hide();
            frm.ShowDialog();
        }

        private void adaugaComandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cod_client = 0;
            foreach (ListViewItem item in listViewClienti.Items)
                if (item.Selected)
                    cod_client = Convert.ToInt32(item.SubItems[0].Text);
            Form frm = new Form7_adauga_comanda(cod_client, user, this); //cod = cod_angajat
            this.Hide();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_login.Show();
        }

        private void Form2_Clienti_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_login.Show();
        }

        private void listViewClienti_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = e.Data.GetData(typeof(ListViewItem)) as ListViewItem;
                int cod_client = Convert.ToInt32(item.ListView.SelectedItems[0].SubItems[0].Text);
                item.ListView.Items.Remove(item);

                for (int i = 0; i < user.ListaClienti.Count; i++)
                {
                    if (((Client)(user.ListaClienti[i])).Cod_client == cod_client)
                    {
                        Client c = (Client)(user.ListaClienti[i]);
                        user.ListaClienti.Remove(c);

                    }
                }

                OleDbConnection conexiune = new OleDbConnection(connString);

                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    comanda.CommandText = "SELECT * FROM clienti WHERE cod_client=" + cod_client;

                    comanda.CommandText = "DELETE FROM clienti WHERE cod_client=" + cod_client;
                    comanda.ExecuteNonQuery();

                    OleDbCommand comanda2 = new OleDbCommand(connString);
                    comanda2.Connection = conexiune;
                    comanda2.CommandText = "SELECT nr_comanda FROM comenzi WHERE cod_client=" + cod_client;
                    OleDbDataReader reader = comanda2.ExecuteReader();

                    reader.Close();
                    comanda.CommandText = "DELETE FROM comenzi WHERE cod_client=" + cod_client;
                    comanda.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " " + ex.Source);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Move;

            }
        }

        private void informatiiContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nume utilizator: " + user.User + Environment.NewLine +
                "Email: " + user.Email + Environment.NewLine +
                "Nr. telefon: " + user.Telefon + Environment.NewLine +
                "Adresa:" + user.Adresa + Environment.NewLine +
                "Admin:" + user.Admin
                );
        }

        private void setariContToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8_setari frm = new Form8_setari(this, user);
            this.Hide();
            frm.ShowDialog();

        }

        private void exportClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement(user.Nume + user.Prenume);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();
            string numeFisier = user.User + ".xml";

            StreamWriter sw = new StreamWriter(numeFisier);
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("Fisier generat!");
        }
    }
}
