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

namespace WpfAppLINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Data source.
        int[] puntuaciones = { 90, 71, 82, 93, 75, 82 };
        Datos db;
        List<Cliente> TablaClientes;
        public MainWindow()
        {
            InitializeComponent();
            db = new Datos();
            TablaClientes = db.GetClientes();
        }

        private void Button_Click(object sender, RoutedEventArgs e) //mejores puntuaciones (consulta)
        {
            IEnumerable<string> scoreQuery =
                from puntuacion in puntuaciones
                where puntuacion > 80
                orderby puntuacion descending
                select $"....{puntuacion}";

            MostrarResultado<string>(scoreQuery);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //mejores puntuaciones (método)
        {
            var Resultado = puntuaciones.Where<int>(s => s > 80).OrderByDescending(s => s);
            MostrarResultado<int>(Resultado);
        }

        void MostrarResultado<T>(IEnumerable<T> resultado)
        {
            lbResultados.Items.Clear();
            foreach (T elemento in resultado)
                lbResultados.Items.Add(elemento);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //lista de Clientes
        {
            var ConsultaClientes = from cliente in TablaClientes
                                   select cliente;
            //MostrarResultado<Cliente>(ConsultaClientes);
            lbResultados.Items.Clear();
            foreach (Cliente c in ConsultaClientes)
                lbResultados.Items.Add($"{c.Nombre}, ({c.Localidad}) = {c.TotalCompras:C2}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Nombre y TotalCompras (proyección en tipo anónimo)
        {
            //int i = 0;
            //var ConsultaNombreCuenta = from cliente in TablaClientes
            //                           select new
            //                           {
            //                               Indice=++i,
            //                               Nombre = cliente.Nombre,
            //                               TotalCompras = cliente.TotalCompras.ToString("C")
            //                           };
            var ConsultaNombreCuenta = TablaClientes.Select((c,i) =>
            new { Indice = i, Nombre = c.Nombre, TotalCompras = c.TotalCompras.ToString("C") });

            lbResultados.Items.Clear();
            foreach (var vista in ConsultaNombreCuenta)
                lbResultados.Items.Add($"{vista.Indice} - {vista.Nombre} >> {vista.TotalCompras}");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) //Nombre y TotalCompras (obteniendo una cadena)
        {
            var ConsultaNombreCuenta = from cliente in TablaClientes
                                       select $"{cliente.Nombre} >> {cliente.TotalCompras:C}";
            MostrarResultado<String>(ConsultaNombreCuenta);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e) //suma de TotalCompras
        {
            Double TotalCuentas = TablaClientes.Sum<Cliente>(c => c.TotalCompras);
            Double Total = (from c in TablaClientes
                            select c.TotalCompras).Sum();
            tbResultado.Text = TotalCuentas.ToString("C") + "<=>" + Total.ToString("C");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e) //Agrupar clientes por localidad
        {
            var ConsultaAgrupada = from c in TablaClientes
                                   group c by c.Localidad ;
            lbResultados.Items.Clear();
            foreach (var grupo in ConsultaAgrupada)
            {
                lbResultados.Items.Add(grupo.Key);
                foreach (Cliente cliente in grupo)
                    lbResultados.Items.Add($"\t {cliente.Nombre}");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e) // Ordenar clientes por totalCompras
        {
            var r = from c in TablaClientes
                    orderby c.TotalCompras descending
                    select c;
            lbResultados.Items.Clear();
            foreach (Cliente c in r)
                lbResultados.Items.Add($"{c.Nombre}\t{c.TotalCompras:C}");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e) //Totalizar compras por localidad (ordenadas)
        {
            lbResultados.Items.Clear();
            //var r = (from c in db.Clientes
            //         group c by c.Localidad into localidad
            //         select new
            //         {
            //             Localidad = localidad.Key,
            //             Total = localidad.Sum<Cliente>(l => l.TotalCompras)
            //         } into x
            //         orderby x.Total descending
            //         select x);
            var r = (from c in TablaClientes
                     group c by c.Localidad into localidad
                     select new
                     {
                         Localidad = localidad.Key,
                         Total = localidad.Sum<Cliente>(l => l.TotalCompras)
                     }).OrderByDescending(x => x.Total);

            foreach (var cl in r)
                lbResultados.Items.Add($"{cl.Localidad,-15} {cl.Total,12:C}");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e) //detalle de pedidos
        {
            lbResultados.Items.Clear();
            var r = from p in db.Pedidos
                    join a in db.Articulos on p.IdArticulo equals a.IdArticulo
                    join c in db.Clientes on p.IdCliente equals c.IdCliente
                    select new
                    {
                        Pedido = p.IdPedido,
                        Fecha = p.Fecha,
                        Cliente = c.Nombre,
                        Descripcion = a.Descripcion,
                        Cantidad = p.Cantidad,
                        Importe = a.Precio * p.Cantidad,
                        Localidad = c.Localidad
                    } into consulta
                    group consulta by new { consulta.Localidad, consulta.Cliente };
            //mostrar el resultado agrupado:
            foreach (var grupo in r)
            {
                lbResultados.Items.Add($"{grupo.Key.Cliente} ({grupo.Key.Localidad})");
                foreach (var fila in grupo)
                    lbResultados.Items.Add($"\t{fila.Fecha,35:D}:{fila.Importe,10:C}");
            }

            //segunda forma:
            lbResultados.Items.Add("-------------------------");
            var r2 = from p in db.Pedidos
                    join a in db.Articulos on p.IdArticulo equals a.IdArticulo
                    join c in db.Clientes on p.IdCliente equals c.IdCliente
                    select new Vista
                    {
                        Fecha = p.Fecha,
                        Cliente = c.Nombre,
                        Importe = a.Precio * p.Cantidad,
                        Localidad = c.Localidad
                    }  into nivel1
                    group nivel1 by nivel1.Localidad into grupoLocalidad
                    from nivel2 in (from nivel1 in grupoLocalidad group nivel1 by nivel1.Cliente)
                    group nivel2 by grupoLocalidad.Key;

            foreach (var grupo1 in r2)
            {
                lbResultados.Items.Add($"{grupo1.Key}");
                foreach (var nivel2 in grupo1)
                {
                    lbResultados.Items.Add($"\t{nivel2.Key}");
                    foreach (var fila in nivel2)
                        lbResultados.Items.Add($"\t\t{fila.Fecha:D}...{fila.Importe:C}");
                }
            }

            //tercera forma:
            lbResultados.Items.Add("-------------------------");

            
            var r3 = from p in db.Pedidos
                    join a in db.Articulos on p.IdArticulo equals a.IdArticulo
                    join c in db.Clientes on p.IdCliente equals c.IdCliente
                    orderby c.Localidad, c.Nombre
                    select new
                    {
                        Fecha = p.Fecha,
                        Cliente = c.Nombre,
                        Importe = a.Precio * p.Cantidad,
                        Localidad = c.Localidad
                    };
            foreach (var x in r3.GroupBy(x => x.Localidad))
            {
                lbResultados.Items.Add(x.Key);
                foreach (var y in x.GroupBy(y => y.Cliente))
                {
                    lbResultados.Items.Add($"\t{y.Key}");
                    foreach (var z in y)
                    {
                        lbResultados.Items.Add($"\t\t{z.Fecha:d} {z.Importe:c}");
                    }
                    lbResultados.Items.Add($"\tTotal...\t{y.Sum(a => a.Importe):c}");
                }
            }

            //utilizando el listView y la sintaxis de métodos:

            //lvResultados.Visibility = Visibility.Visible;
            lvResultados.ItemsSource =
                db.Pedidos.Join(db.Articulos, x => x.IdArticulo, y => y.IdArticulo,
                (x, y) => new { Fecha = x.Fecha.ToShortDateString(), Importe = x.Cantidad * y.Precio, x.IdCliente }).
                Join(db.Clientes, a => a.IdCliente, b => b.IdCliente,
                (a, b) => new { a.Fecha, a.Importe, b.Localidad, Cliente = b.Nombre });

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvResultados.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Localidad");
            PropertyGroupDescription groupDescription2 = new PropertyGroupDescription("Cliente");
            view.GroupDescriptions.Add(groupDescription);
            view.GroupDescriptions.Add(groupDescription2);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e) //totalizar importes de pedidos por cliente
        {
            lbResultados.Items.Clear();
            var r = from p in db.Pedidos
                    join a in db.Articulos on p.IdArticulo equals a.IdArticulo
                    join c in db.Clientes on p.IdCliente equals c.IdCliente
                    select new
                    {
                        p.IdPedido,
                        c.Nombre,
                        Importe = p.Cantidad * a.Precio
                    } into pc
                    group pc by pc.Nombre into grupo
                    select new
                    {
                        grupo.Key,
                        Total = grupo.Sum(g => g.Importe)
                    };
            foreach (var grupo in r)
            {
                lbResultados.Items.Add($"{grupo.Key}={grupo.Total}");
            }

        }

    }
}
