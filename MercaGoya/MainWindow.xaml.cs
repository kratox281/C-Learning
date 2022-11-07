using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace MercaGoya
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Producto> listaProductos = new List<Producto>();
        Ticket ticket = new Ticket();
        bool creado = false;
        
        public MainWindow()
        {
            InitializeComponent();
            CargarProductos();
            subsciribir();
        }
        private void subsciribir()
        {
            ticket.nuevaLinea += Ticket_nuevaLinea;
            ticket.nuevoTicket += Ticket_nuevoTicket;
        }

        private void Ticket_nuevoTicket(object sender, Ticket e)
        {
            lbTicket.Items.Clear();
            tbEntrega.Text = "";
            lbTicket.Items.Add("MercaGoya");
            lbTicket.Items.Add($"{DateTime.Now.DayOfWeek}, {DateTime.Now.Date}");
            lbTicket.Items.Add(DateTime.Now.TimeOfDay);
            lbTicket.Items.Add("*********************************************************");
           
            //throw new NotImplementedException();
        }

        private void Ticket_nuevaLinea(object sender, Ticket e)
        {

            Producto temp = lbProductos.SelectedItem as Producto;
            ticket.Linea = temp.ToString();
            ticket.Total += temp.Precio;
            lbTicket.Items.Add(ticket.Linea);
        }

        void CargarProductos()
        {
            // añadir 4 productos a la colección de productos
            Producto p1 = new Producto("Patatas Fritas",10F);
            Producto p2 = new Producto("Ketchup 3 Tomates", 20f);
            Producto p3 = new Producto("Carne de Kebab", 50f);
            Producto p4 = new Producto("Jamon Iberico", 100f);
            lbProductos.Items.Add(p1);
            lbProductos.Items.Add(p2);   
            lbProductos.Items.Add(p3);   
            lbProductos.Items.Add(p4);

            // mostrar la colección Productos en el listbox de Productos

        }

        private void lbProductos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (creado)
            {
                Ticket_nuevaLinea(sender,ticket);
            }
            // Asignar valor a la propiedad Linea del Ticket y acumular precio en la propiedad Total
        }

        private void botNuevo_Click(object sender, RoutedEventArgs e)
        {
            // instanciaar un nuevo ticket, suscribire eventos e IniciarTicket
            creado = true;
            Ticket_nuevoTicket(sender, ticket);

            //ticket_nuevoTicket(sender,e);

        }

        private void botCerrar_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar el ticket mostrando la línea de * y el Total
            creado = false;
            lbTicket.Items.Add("*********************************************************");
            lbTicket.Items.Add($"{ticket.Total}€");

        }

        private void botCambio_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar cantidad entregada y el cambio
            float recibido = float.Parse(tbEntrega.Text);
            if (ticket.Total > recibido)
            {
                MessageBox.Show("No has introducido suficiente dinero");
                tbEntrega.Text = "";
            }
            else
            {
                lbTicket.Items.Add($"Ha introducido {recibido}€");
                lbTicket.Items.Add($"Su cambio es de: {recibido - ticket.Total}€");
                ticket.Total = 0;
            }

        }
    }

    public class Producto
    {
        // declarar los atributos respetando las especificaciones
        private string descripcion;
        private float precio;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public Producto(string desc,float preci)
        {
            Descripcion=desc;
            Precio = preci;
        }

        public override string ToString()
        {
            return $"{Descripcion}({Precio}€)";
        }


    }
    public class Ticket:EventArgs
    {
        // declarar los atributos respetando las especificaciones
        private string linea;
        public event EventHandler<Ticket> nuevaLinea;
        public event EventHandler<Ticket> nuevoTicket;
        public string Linea
        {
            get { return linea; }
            set { linea = value; }
        }
       private float total;

        public float Total
        {
            get { return total; }
            set { total = value; }
        }
       

 

    }
}
