using System;
using System.Windows;

namespace WpfAppListas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Personajes coleccion;
        public MainWindow()
        {
            InitializeComponent();
            coleccion = (Personajes)this.Resources["coleccionPersonajes"];
            coleccion.ColeccionVacia += Coleccion_ColeccionVacia; 
        }

        private void Coleccion_ColeccionVacia(object sender, EventArgs e)
        {
            MessageBox.Show("Colección VACIA"); 
        }


        private void BotonNuevo_Click(object sender, RoutedEventArgs e)
        {
            coleccion.Add(new Personaje() { Nombre = "la estrella", Foto = "imagenes/estrella.png" });
        }

        private void BotonEliminar_Click(object sender, RoutedEventArgs e)
        {
            coleccion.RemoveAt(lb.SelectedIndex); 
        }
    }
}
