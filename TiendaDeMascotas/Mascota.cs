using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeMascotas
{
    
    internal class Mascota
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private String propietario;

        public String Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }
        private String especie;
        private string v1;
        private string v2;

        public Mascota(string v1, string v2,string nomb)
        {
            this.propietario = v1;
            this.especie = v2;
            this.nombre = nomb;
        }

        public String Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public override string ToString()
        {
            return Nombre;
        }



    }
	

}
