using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenLinQRuben
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Cliente> Clientes = Datos.GetClientes();
        List<Servicio> Servicios = Datos.GetArticulos();
        List<Intervencion> Intervenciones = Datos.GetPedidos();
        public MainWindow()
        {
            InitializeComponent();
            MostrarResultado();
            TimeSpan tiempo = new TimeSpan(0, 0, 0);
        }
        public void MostrarResultado()
        {
            var Consulta =
                 from intervencion in Intervenciones
                 join cliente in Clientes on intervencion.IdCliente equals cliente.IdCliente 
                 join servicio in Servicios on intervencion.IdServicio equals servicio.IdServicio
                 select new{
                         Apellidos = cliente.Apellidos,
                         Nombre= cliente.Nombre,
                         Domicilio = cliente.Domicilio,
                         Fecha =intervencion.Fecha,
                         Descripcion = servicio.Descripcion,
                         Precio=servicio.Precio * (intervencion.TiempoMinutos.TotalMinutes)+" €"
                    };
          
           
            foreach (var c in Consulta)
            {
                lbResultados.Items.Add(c.Apellidos+","+c.Nombre+"("+c.Domicilio+")");
                lbResultados.Items.Add("      " +c.Fecha+"  "+c.Descripcion+"   "+c.Precio);
            }

        }
    }

    public class Datos
    {
        public static List<Cliente> GetClientes()
        {
            return new List<Cliente>()
            {
                new Cliente
                {
                IdCliente = 1,
                Nombre = "Juancito",
                Apellidos = "Pérez Pí",
                Domicilio = "Calle Uno, 1",
                },
                new Cliente
                {
                IdCliente = 2,
                Nombre = "Pepita",
                Apellidos = "García",
                Domicilio = "Calle Dos, 2",
                },
                new Cliente
                {
                IdCliente = 3,
                Nombre = "Alicia",
                Apellidos = "Gómez Pí",
                Domicilio = "Calle Tres, 3",
                },
                new Cliente
                {
                IdCliente = 4,
                Nombre = "Fulano",
                Apellidos = "de Tal",
                Domicilio = "Calle Cuatro, 4",
                }
            };
        }
        public static List<Servicio> GetArticulos()
        {
            return new List<Servicio>()
            {
                new Servicio {IdServicio=1, Descripcion="servicio uno",Precio=10},
                new Servicio {IdServicio=2, Descripcion="servicio dos",Precio=20},
                new Servicio {IdServicio=3, Descripcion="servicio tres",Precio=30},
                new Servicio {IdServicio=4, Descripcion="servicio cuatro",Precio=40}
            };
        }
        public static List<Intervencion> GetPedidos()
        {

            return new List<Intervencion>()
            {
                new Intervencion{ IdIntervencion=1, IdCliente=1, IdServicio=1, TiempoMinutos=new TimeSpan(0,3,0), Fecha=new DateTime(2022,10,01 )},
                new Intervencion{ IdIntervencion=2, IdCliente=1, IdServicio=2, TiempoMinutos=new TimeSpan(1,0,0), Fecha=new DateTime(2022,10,02 )},
                new Intervencion{ IdIntervencion=3, IdCliente=3, IdServicio=1, TiempoMinutos=new TimeSpan(0,30,0), Fecha=new DateTime(2022,10,02 )},
                new Intervencion{ IdIntervencion=4, IdCliente=2, IdServicio=1, TiempoMinutos=new TimeSpan(0,40,0), Fecha=new DateTime(2022,10,02 )},
                new Intervencion{ IdIntervencion=5, IdCliente=4, IdServicio=3, TiempoMinutos=new TimeSpan(0,10,0), Fecha=new DateTime(2022,10,03 )},
                new Intervencion{ IdIntervencion=6, IdCliente=1, IdServicio=4, TiempoMinutos=new TimeSpan(0,20,0), Fecha=new DateTime(2022,10,03 )}
            };
        }
    }
    public class Intervencion
    {
        public int IdIntervencion { get; set; }
        public int IdServicio { get; set; }
        public int IdCliente { get; set; }
        public TimeSpan TiempoMinutos { get; set; }
        public DateTime Fecha { get; set; }
    }
    public class Servicio
    {
        public int IdServicio { get; set; }
        public String Descripcion { get; set; }
        public Double Precio { get; set; }
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Domicilio { get; set; }
    }
}
