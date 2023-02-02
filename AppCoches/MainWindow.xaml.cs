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

namespace AppCoches
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(var carro in carros())
            {
                list.Items.Add(carro);
            }
        }
        public List<Carro> carros()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro() {Marca = "Toyota",Modelo="Supra",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\supra.jpeg" });
            carros.Add(new Carro() {Marca = "Nissan",Modelo="GTR",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\r34.jpg" });
            carros.Add(new Carro() {Marca = "Mazda",Modelo="Rx7",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\rx7.jpg" });
            carros.Add(new Carro() {Marca = "Mitsubishi",Modelo="EVO V",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\evo.jpg" });
            carros.Add(new Carro() {Marca = "Subaru",Modelo="Impreza WRX",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\wrx.jpg" });
            carros.Add(new Carro() {Marca = "Honda",Modelo="Civic",Matricula="69420",Precio=70000,Foto= "C:\\Users\\casmarru\\C-Learning\\AppCoches\\fotos\\civic.jpg" });
            return carros;
        }
    }

    public class Carro
    {
        public String? Marca { get; set; }
        public String? Modelo { get; set; }
        public String? Matricula { get; set; }
        public int? Precio { get; set; }
        public String? Foto { get; set; }
        public String Nombre{
            get { return $"{Marca} {Modelo}"; }
        }
    }
}
