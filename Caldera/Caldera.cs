using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldera
{

    internal class Caldera
    {
        private int temperatura;
        private Estados estado;

        public event EventHandler<CalderaArgumentosEvento> CambioTemperatura;
        public event EventHandler<CalderaArgumentosEvento> CambioEstado;
        public event EventHandler StopCaldera;
    
        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

        public Estados Estado
        {
            get { return estado; }
            set { estado = value; }
        }

    }

    public class CalderaArgumentosEvento
    {
        private int temperatura;
        private Estados estado;
        CalderaArgumentosEvento(int Grados,DateTime fecha,Estados estado)
        {

        }
        public int Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }

    }
    internal enum Estados : int
    {
        Correcto = 0, //(verde)
        Alerta = 1, //     (amarillo)
        Peligro = 2//(rojo)
    }

}

