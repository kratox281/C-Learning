using System;
using System.Collections;
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

namespace TiendaDeMascotas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        List<Mascota> mascotas = new List<Mascota>();
        public MainWindow()
        {
            InitializeComponent();
            aniadirAnimales();
            cargarLista();
        }
        private void cargarLista()
        {
            lbAnimal.Items.Clear();
            foreach (Mascota mas in mascotas)
            {
                lbAnimal.Items.Add(mas);
            }

        }
        private void aniadirAnimales()
        {
            mascotas.Add(new Mascota("rober", "gato", "paco"));
            mascotas.Add(new Mascota("juan", "perro", "Rex"));
            mascotas.Add(new Mascota("javi", "gato", "fufi"));
            mascotas.Add(new Mascota("concha", "gato", "cuki"));
            mascotas.Add(new Mascota("adam", "perro", "perro"));



        }
        private void lbAnimal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mascota temp = lbAnimal.SelectedItem as Mascota;
            if (temp != null)
            {
                nomPropi.Text = temp.Propietario;
                nomEspecie.Text = temp.Especie;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mascota ms = (Mascota)lbAnimal.SelectedItem;
            mascotas.Remove(ms);
            nomPropi.Text = "";
            nomEspecie.Text = "";
            cargarLista();
        }
    }
}
