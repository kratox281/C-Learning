using AppRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRestaurantes.Services
{
    public class RestauranteService
    {
        List<Restaurante> restaurantes;
        public List<Restaurante> GetRestaurantes()
        {
            if (restaurantes?.Count > 0)
            {
                return restaurantes; }
            restaurantes = new List<Restaurante>
            {
            new Restaurante{NombreRestaurante = "Burdeos",Descripcion="Hamburguesas y platos",Direccion="Cerca de Trafico",Poblacion="Valladolid",Provincia="Valladolid",ImgRes="C:\\Users\\casmarru\\C-Learning\\AppRestaurantes\\Fotos\\burdeos.png"},

            new Restaurante{NombreRestaurante  ="La Berrea",Descripcion="Ternera de primera",Direccion="Calle Gerona",Poblacion="Valladolid",Provincia="Valladolid",ImgRes= "C:\\Users\\casmarru\\C-Learning\\AppRestaurantes\\Fotos\\berrea.jpg" },
            new Restaurante{NombreRestaurante= "Los faroles",Descripcion="Taberna Rock con carnes Exoticas",Direccion="Paseo Farnesio",Poblacion="Valladolid",Provincia="Valladolid",ImgRes = "C:\\Users\\casmarru\\C-Learning\\AppRestaurantes\\Fotos\\faroles.jpg"},
            new Restaurante{NombreRestaurante= "Moreiro",Descripcion="Parrilla de gran Calidad",Direccion = " Av. López Blanco",Poblacion="Celanova",Provincia="Ourense",ImgRes =  "C:\\Users\\casmarru\\C-Learning\\AppRestaurantes\\Fotos\\moreiro.jpg"}
        };
        restaurantes.TrimExcess();
            App.Current.MainPage.DisplayAlert("Clientes", "Coleccion REcuperada", "Aceptar");
            return restaurantes;
        }
           
            }
        
        }
    

