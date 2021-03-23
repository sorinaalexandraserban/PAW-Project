using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_SerbanSorina
{
    public abstract class Comanda
    {
        private int nrComanda;
        private float sumaComanda;
        private int procentDiscount;
        private string tipPizza;

        public Comanda()
        {
            this.nrComanda = 0;
            this.sumaComanda = 0;
            this.procentDiscount = 0;
            this.tipPizza = "---";
        }

        public Comanda(int nrComanda, float sumaComanda, int procentDiscount, string tip)
        {
            this.nrComanda = nrComanda;
            this.sumaComanda = sumaComanda;
            this.procentDiscount = procentDiscount;
            this.tipPizza = tip;
        }

        public override string ToString()
        {
            return
                Environment.NewLine +
                "Comanda nr. " + this.nrComanda + Environment.NewLine +
                "____________________________ " + Environment.NewLine +
                "____________________________ " + Environment.NewLine +
                "Comanda in valoare de: " + this.sumaComanda + "lei" + Environment.NewLine +
                "____________________________ " + Environment.NewLine +
                "Tip pizza: " + this.tipPizza + Environment.NewLine +
                "____________________________ " + Environment.NewLine +
                "Discount: " + this.procentDiscount;
        }
        public int NrComanda
        {
            get { return this.nrComanda; }
            set
            {
                if (value > 0)
                    this.nrComanda = value;
            }
        }

        public int ProcentDiscount
        {
            get { return this.procentDiscount; }
            set
            {
                if (value > 0 && value < 100)
                    this.procentDiscount = value;
            }
        }

        public float SumaComanda
        {
            get { return this.sumaComanda; }
            set
            {
                if (value > 0)
                    this.sumaComanda = value;
            }
        }
        public string TipPizza
        {
            get { return this.tipPizza; }
        }
    }
}
