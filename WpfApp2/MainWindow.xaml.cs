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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(var item in GetPersonas())
            {
                Lista.Items.Add(item);
            }
        }

        private List<Persona> GetPersonas()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona() {Nombre="Ruben",Apellidos="Casas",Telefono="642375858"});
            personas.Add(new Persona() {Nombre="roberto",Apellidos="CArlos",Telefono="642375858"});
            personas.Add(new Persona() {Nombre="jorge",Apellidos="manito",Telefono="642375858"});
            personas.Add(new Persona() {Nombre="pACO",Apellidos="Casas",Telefono="642375858"});
            personas.Add(new Persona() {Nombre="manu",Apellidos="Casas",Telefono="642375858"});
            personas.Add(new Persona() {Nombre="mary",Apellidos="Casas",Telefono="642375858"});

            return personas;
        }
    }

    public class Persona
    {
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }

        public string NombreCompleto {
            get { return $"{Apellidos},{Nombre}"; }
        }

    }
}
