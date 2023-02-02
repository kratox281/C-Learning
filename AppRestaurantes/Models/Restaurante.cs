using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurantes.Models
{
    public class Restaurante
    {
        public string ImgRes { get; set; }
        public string NombreRestaurante { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
    }
}
