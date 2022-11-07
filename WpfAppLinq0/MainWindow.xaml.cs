using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace WpfAppLinq0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Persona> personas = new List<Persona>();

        public MainWindow()
        {
            InitializeComponent();

            //Ejemplo1();
            //Ejemplo2();
            //Ejemplo3();
            //Ejemplo4();
            Ejemplo5();
            //Ejemplo6();
            //Cuantificar();
        }

        private void Ejemplo1()
        {
            List<int> enteros = new List<int>() { 20, 56, 84, 13, 6, 2 };
            /*var resultado = from n in enteros
                            where n > 20
                            orderby n descending
                            select n;*/
            var resultado = from n in enteros
                            where n > 5 && n < 50
                            orderby n ascending
                            select n;
            int cont = 0;
            foreach (var item in resultado)
            {
                tb1.Text += $"{++cont:00}...{item}\n";
            }
        }
        private void Ejemplo2()
        {
            List<int> enteros = new List<int>() { 20, 56, 84, 13, 6, 2 };
            var resultado = from n in enteros
                            where n % 2 == 0
                            orderby n descending
                            select $"{n:C0}";
            foreach (string item in resultado)
            {
                tb1.Text += $"{item}\n";
            }
        }
        private void Ejemplo3()
        {
            List<int> enteros = new List<int>() { 20, 56, 62, 13, 6, 2 };
            var resultado = from n in enteros
                            where n % 2 == 0
                            orderby n descending
                            select new //proyecto el resultado en un tipo anónimo
                            {
                                numero = n,
                                letrita = (char)(n + 64)
                            };
            foreach (var item in resultado)
            {
                tb1.Text += $"\t{item.letrita}\t{item.numero}\n";
            }
        }
        private void Ejemplo4()
        {
            List<Persona> personas = new List<Persona>()
            {
                new Persona{
                    Dni="111111",
                    Nombre="Juancito",
                    Apellidos="Pérez Pí",
                    Telefono="983548798"},
                new Persona{Nombre="Alicia", Dni="222222",
                    Apellidos="Gómez Narro", Telefono="693548721"},
                new Persona{Nombre="Pedro", Dni="333333",
                    Apellidos="Del Alto Sombrero", Telefono="653259874"},
            };
            IEnumerable<Persona> resultado = from p in personas
                                             select p;
            foreach (Persona item in resultado)
            {
                tb1.Text += $"{item.NombreCompleto.PadRight(40, '.')} \t\t({item.Telefono})\n";
                //tb1.Text += $"{item.NombreCompleto,-40} \t\t({item.Telefono})\n";
            }

            //utilizando sintaxis de método:
            var resultado2 = personas.Select(p =>
                        new { nom = p.NombreCompleto, tel = p.Telefono });
            //tengo que utilizar el tipo var porque he creado un tipo anónimo
            //no es necesario asignar un nombre a cada propiedad
            //si no lo hago asume el nombre original
            foreach (var item in resultado2)
            {
                tb1.Text += $"{item.nom,40} - {item.tel}\n";
            }
        }
        private void Ejemplo5()
        {
            List<Persona> personas;
            List<Vehiculo> vehiculos;
            CargarColecciones(out personas, out vehiculos);

            IEnumerable<VistaPropietarios> resultado = from p in personas
                                                       join v in vehiculos on p.Dni equals v.DniPropietario
                                                       select new VistaPropietarios
                                                       {
                                                           Nombre = p.NombreCompleto,
                                                           Matricula = v.Matricula,
                                                           Modelo = v.Modelo
                                                       };
            string g = "";
            foreach (VistaPropietarios item in resultado)
            {
                if (item.Nombre != g)
                {
                    tb1.Text += $"{item.Nombre.PadRight(50, '_')}\n";
                    g = item.Nombre;
                }
                tb1.Text += $"\t\t{item.Matricula} \t{item.Modelo}\n";
            }
        }
        private void Ejemplo6()
        {
            List<Persona> personas;
            List<Vehiculo> vehiculos;
            CargarColecciones(out personas, out vehiculos);

            IEnumerable<VistaPropietarios> resultado = from p in personas
                                                       join v in vehiculos on p.Dni equals v.DniPropietario
                                                       select new VistaPropietarios
                                                       {
                                                           Nombre = p.NombreCompleto,
                                                           Matricula = v.Matricula,
                                                           Modelo = v.Modelo
                                                       };
            lvVehiculos.Visibility = Visibility.Visible;
            lvVehiculos.ItemsSource = resultado;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvVehiculos.ItemsSource);
            PropertyGroupDescription groupDescription = new PropertyGroupDescription("Nombre");
            view.GroupDescriptions.Add(groupDescription);
        }
        void Cuantificar()
        {
            List<Persona> personas;
            List<Vehiculo> vehiculos;
            CargarColecciones(out personas, out vehiculos);

            var resultado = from v in vehiculos
                            join p in personas on v.DniPropietario equals p.Dni
                            group v by p.NombreCompleto into grupo
                            orderby grupo.Count() descending
                            select new
                            {
                                Nombre = grupo.Key,
                                Total = grupo.Count()
                            };
            tb1.Text = $"NOMBRE                                  TOTAL\n";
            foreach (var item in resultado)
            {
                tb1.Text += $"{item.Nombre.PadRight(40, '.')}{item.Total}\n";
            }

        }

        static void CargarColecciones(out List<Persona> personas, out List<Vehiculo> vehiculos)
        {
            personas = new List<Persona>()
            {
                new Persona{
                    Dni="111111",
                    Nombre="Juancito",
                    Apellidos="Pérez Pí",
                    Telefono="983548798"},
                new Persona{Nombre="Alicia", Dni="222222",
                    Apellidos="Gómez Narro", Telefono="983548798"},
                new Persona{Nombre="Pedro", Dni="333333",
                    Apellidos="Del Alto Sombrero", Telefono="983548798"},
            };
            vehiculos = new List<Vehiculo>()
            {
                new Vehiculo{Matricula="AAAAAA",DniPropietario="111111", Modelo="Renault Clio 1.3 100cv",Color="negro"},
                new Vehiculo{Matricula="BBBBBB",DniPropietario="222222", Modelo="Peugeout 2008 1.3 100cv",Color="blanco"},
                new Vehiculo{Matricula="CCCCCC",DniPropietario="111111", Modelo="Seat Toledo 1.3 150cv",Color="blanco"},
                new Vehiculo{Matricula="DDDDDD",DniPropietario="333333", Modelo="Audi A7 3.0 250cv",Color="negro"},
                new Vehiculo{Matricula="EEEEEE",DniPropietario="222222", Modelo="Peugeout 2008 1.4 150cv",Color="VERDE"},
                new Vehiculo{Matricula="FFFFFF",DniPropietario="222222", Modelo="Peugeout 2008 1.5 200cv",Color="AZUL"},

            };
        }

    }

}
