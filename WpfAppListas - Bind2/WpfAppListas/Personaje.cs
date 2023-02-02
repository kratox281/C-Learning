using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppListas.MetodosExtension;

namespace WpfAppListas
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string MisIniciales
        {
            get { return Nombre.Iniciales(); }
        }

    }
}
