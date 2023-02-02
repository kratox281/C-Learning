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

namespace WpfAppListas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //foreach (Persona persona in GetPersonas())
            //{
            //    lb1.Items.Add(persona);
            //}
            lb1.ItemsSource = GetPersonas();
        }

        private List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona()
                {
                    Nombre = "Alberto",
                    Apellidos = "Gómez",
                    Telefono = "659875432",
                    Imagen="Fotos/usuario.png"
                });
            personas.Add(new Persona()
            {
                Nombre = "Alicia",
                Apellidos = "Gómez",
                Telefono = "987546532"
            });
            personas.Add(new Persona()
            {
                Nombre = "Luis",
                Apellidos = "García",
                Telefono = "654872589"
            });
            personas.Add(new Persona()
            {
                Nombre = "Paula",
                Apellidos = "López",
                Telefono = "67851498"
            });
            return personas;
        }

    }
    public class Persona
    {
        //public string? Nombre;
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Imagen { get; set; }
        public string NombreCompleto
        {
            get { return $"{Apellidos}, {Nombre}"; }
        }

    }
}
