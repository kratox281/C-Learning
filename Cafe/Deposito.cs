using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{

    internal class Deposito
    {
        public float[] monedas = { 2,1,0.5f,0.2f,0.1f };
        private ArrayList introducido = new ArrayList();
        private ArrayList vuelta = new ArrayList();
        private float total=0;
        public EventHandler TotalChange;
        public EventHandler MonedaNoValida;


        public ArrayList Introducido
        {
            get { return introducido; }
            set
            {
                introducido = value;
                
                
            }
        }
       

        public float Total
        {
            get { return total; }
            set {
                if (value-total>2) { MonedaNoValida?.Invoke(this, EventArgs.Empty); }
                else { total = value;
                TotalChange?.Invoke(this, EventArgs.Empty);}
                
               

            }
        }

        public ArrayList Vuelta
        {
            get { return vuelta; }
            set
            {
                vuelta = value;
            }
        }

    }
}
