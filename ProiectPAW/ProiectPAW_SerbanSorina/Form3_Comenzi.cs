using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_SerbanSorina
{
    public partial class Form3_Comenzi : Form
    {
        Utilizator user;
        int cod_client;
        string nume_client;
        Form2_Clienti frm_clienti;
        List<Comanda> listaComenzi = new List<Comanda>();

        void initTreeView()
        {
            TreeNode comenzi = new TreeNode("Comenzi");

            treeView1.Nodes.Add(comenzi);

            for (int i = 0; i < user.ListaClienti.Count; i++)
            {
                Comanda comanda= (Comanda)(((Client)user.ListaClienti[i]).Comenzi[i]);

                TreeNode com = new TreeNode("Nr: " + comanda.NrComanda +
                                   "Suma:" + comanda.SumaComanda +
                                   "Discount:" + comanda.ProcentDiscount +
                                   "Tip pizza: " + comanda.TipPizza );
                comenzi.Nodes.Add(com);
                listaComenzi.Add(comanda);
            }
            treeView1.ExpandAll();
        }

        public Form3_Comenzi(int cod_cl, Utilizator u, string numeCl, Form2_Clienti frm)
        {
            frm_clienti = frm;
            cod_client = cod_cl;
            user = u;
            nume_client = numeCl;
            InitializeComponent();
            label1.Text += " " + numeCl;
            initTreeView();
        }

        private void Form3_Comenzi_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm_clienti.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode nodSelectat = treeView1.SelectedNode;
            if (nodSelectat.Parent != null)
            {
                string nr_comanda;

                try
                {
                    int gasit = 0;
                    nr_comanda = nodSelectat.Text.Split(':', '/')[1];
                    nr_comanda = nr_comanda.Trim();
                    foreach (Comanda c in listaComenzi)
                    {
                        if (nr_comanda == c.NrComanda.ToString())
                        {
                            textBox1.Text = "Client: " + nume_client + Environment.NewLine;
                            textBox1.Text += "_____________________" + Environment.NewLine;
                            textBox1.Text += c.ToString();
                            gasit = 1;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
