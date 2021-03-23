using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_SerbanSorina
{
    public class Client
    {
        private int cod_client;
        private string adresa;
        private string nrTelefon;
        private string email;
        private ArrayList comenzi;

        public Client()
        {
            cod_client = -1;
            adresa = "---";
            nrTelefon = "---";
            email = "---";
            comenzi = null;
        }

        public Client(string adresa, string nrTel, string email)
        {
            this.adresa = adresa;
            this.nrTelefon = nrTel;
            this.email = email;
        }

        public Client(int cod, string adresa, string nrTel, string email, ArrayList comenzi)
        {
            this.cod_client = cod;
            this.adresa = adresa;
            this.nrTelefon = nrTel;
            this.email = email;
            this.comenzi = comenzi;
        }

        public override string ToString()
        {
            string res = "";
            res += "adresa: " + this.adresa + " nr tel: " + this.nrTelefon + " email: " + this.email +
                " are comenzile: ";
            if (this.comenzi != null)
                for (int i = 0; i < this.comenzi.Count; i++)
                    res += "\n  " + (i + 1) + ":" + this.comenzi[i].ToString();
            return res;
        }

        public void adaugaComanda(Comanda comanda)
        {
            this.comenzi.Add(comanda);

        }
        public void stergeComanda(Comanda comanda)
        {
            this.comenzi.Remove(comanda);
        }

        public ArrayList Comenzi
        {
            get { return this.comenzi; }
            set
            {
                if (value != null)
                    this.comenzi = value;
            }
        }
        public object this[int index]
        {
            get
            {
                if (comenzi != null && index >= 0 && index < comenzi.Count)
                    return comenzi[index];
                else return 0;
            }
            set
            {
                if (value != null && index >= 0 && index < comenzi.Count)
                    comenzi[index] = value;
            }
        }
        public int Cod_client
        {
            get { return this.cod_client; }
            set { this.cod_client = value; }
        }
        public string Adresa
        {
            get { return this.adresa; }
            set { if (value != null) this.adresa = value; }
        }
        public string NrTelefon
        {
            get { return this.nrTelefon; }
            set { if (value != null) this.nrTelefon = value; }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                if (value != null)
                    this.email = value;
            }
        }
        
    }
}

