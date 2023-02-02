using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Coleccion_MVM
{

    internal class Pojo
    {
        public string EnlaceFoto { get; set; }
        public string Propiedad1 { get; set; }
        public string Propiedad2 { get; set; }
        public string Propiedad3 { get; set; }
        public static IEnumerable<Pojo> All { get; private set; }

        static Pojo(){
            List<Pojo> all = new List<Pojo>
            {
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 1",Propiedad2 = "elemento 1",Propiedad3 = "Objeto 1"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 2",Propiedad2 = "elemento 2",Propiedad3 = "Objeto 2"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 3",Propiedad2 = "elemento 3",Propiedad3 = "Objeto 3"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 4",Propiedad2 = "elemento 4",Propiedad3 = "Objeto 4"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 5",Propiedad2 = "elemento 5",Propiedad3 = "Objeto 5"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 6",Propiedad2 = "elemento 6",Propiedad3 = "Objeto 6"},
                    new Pojo{EnlaceFoto = "https://picsum.photos/500",Propiedad1 = "Foto 7",Propiedad2 = "elemento 7",Propiedad3 = "Objeto 7"},
            };
            all.TrimExcess();
            All= all;
                     }
    }
}
