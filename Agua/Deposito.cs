using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agua
{
    internal class Deposito
    {
		public int cantidad;
		public event EventHandler Cantidad_Changed;
		public event EventHandler DepositoVacio;
        public event EventHandler DepositoLleno;
        public Deposito()
		{
			cantidad = 10;
		}

		public int Cantidad
		{
			get { return cantidad; }
			set { 
				cantidad  = value;
				Cantidad_Changed?.Invoke(this, EventArgs.Empty);
				if(cantidad==0) DepositoVacio?.Invoke(this, EventArgs.Empty);
				if(cantidad==10) DepositoLleno?.Invoke(this, EventArgs.Empty);
			}
		}
		public void Llenar(int valor)
		{
			Cantidad = valor;
		}

	}
}
