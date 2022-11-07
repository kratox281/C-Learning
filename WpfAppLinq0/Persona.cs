using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppLinq0
{
    public class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string NombreCompleto { get { return $"{Apellidos}, {Nombre}"; } }
    }
}
