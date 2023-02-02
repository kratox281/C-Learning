using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppBindColeccion
{
    internal class Socio

    {
        public int NumSocio { get; set; }
        public string ApellidosSocio { get; set; }
        public string NombreSocio { get; set; }
        public string TelefonoSocio { get; set; }
        public bool PagadoSocio { get; set; } // cierto si está al corriente del pago de las cuotas
        public string ImagenSocio { get; set; }
        public static IEnumerable<Socio> All { get; private set; }

        static Socio()
        {
            List<Socio> all = new List<Socio>
            {
                new Socio { NumSocio = 1, ApellidosSocio = "García López", NombreSocio = "Luis", TelefonoSocio = "984653221", PagadoSocio = false },
                new Socio { NumSocio = 2, ApellidosSocio = "Apellido López", NombreSocio = "Luisa", TelefonoSocio = "984653221", PagadoSocio = true },
                new Socio { NumSocio = 3, ApellidosSocio = "García Apellido", NombreSocio = "Alberta", TelefonoSocio = "984653221", PagadoSocio = true },
                new Socio { NumSocio = 4, ApellidosSocio = "López Apellido", NombreSocio = "Alberto", TelefonoSocio = "984653221", PagadoSocio = false }
            };
            all.TrimExcess();
            All = all;
        }
    }
}
