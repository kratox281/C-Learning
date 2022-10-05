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

namespace AhorcadoBienHecho
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int fallos = 0;
        private string palabra = "";

        public MainWindow()
        {
            InitializeComponent();
            Console.Write("Hlaa");
            vaciarMoñeco();
            llenarLista();
        }
        private void llenarMuñeco()
        {
            switch (fallos)
            {
                case 0:
                    suelo.Visibility = Visibility.Visible;
                    break;
                case 1:
                    posteVertical.Visibility = Visibility.Visible;
                    break;
                case 2:
                    posteHorizontal.Visibility= Visibility.Visible;
                    break;
                case 3:
                    Cuerda.Visibility = Visibility.Visible; 
                    break;
                case 4:
                    cabeza.Visibility = Visibility.Visible; 
                    break;
                case 5:
                    Cuerpo.Visibility = Visibility.Visible;
                    break;
                case 6:
                    brazos.Visibility = Visibility.Visible;
                    break;
                case 7:
                    Pierna1.Visibility= Visibility.Visible;
                    Pierna2.Visibility= Visibility.Visible;
                    break;
                case 8:
                    MessageBox.Show("Has perdido");
                    fallos = -1;
                    
                    if (Lbox1.SelectedIndex != Lbox1.Items.Count - 1)
                    {
                        Lbox1.SelectedIndex += 1;
                        Lbox1.SelectedIndex -= 1;
                    }
                    else
                    {
                        Lbox1.SelectedIndex -= 1;
                        Lbox1.SelectedIndex += 1;
                    }
                    break;

            }
            fallos++;
        }
        private void vaciarMoñeco()
        {
            suelo.Visibility= Visibility.Hidden;
            posteVertical.Visibility = Visibility.Hidden;
            posteHorizontal.Visibility = Visibility.Hidden;
            Cuerda.Visibility= Visibility.Hidden;
            cabeza.Visibility = Visibility.Hidden;
            Cuerpo.Visibility=Visibility.Hidden;
            brazos.Visibility= Visibility.Hidden;   
            Pierna1.Visibility=Visibility.Hidden;
            Pierna2.Visibility = Visibility.Hidden;

        }
        private void llenarLista()
        {
            String[] lista = {"Patata","Tupu"};
            foreach(string palabra in lista)
            {
                Lbox1.Items.Add(palabra);
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Console.Write("holaa");
            if (Lbox1.SelectedIndex != Lbox1.Items.Count-1)
            {
                Lbox1.SelectedIndex += 1;
            }
            else
            {
                Lbox1.SelectedIndex = 0;
            }
            
        }

        private void bCheck_Click(object sender, RoutedEventArgs e)
        {
            if (Lbox1.SelectedItem == null)
            {
                return;
            }
            try
            {
                if (letra.Text != null)
            {
                char c = letra.Text[0];
                comprobar(c);
            }

            }
            catch (Exception)
            {

            }
            
        }
        private void comprobar(char c)
        {
            if (palabra.Contains(c))
            {
                quitarGuion(c);
                if (!Etiqueta.Content.ToString().Contains("-"))
                {
                    MessageBox.Show("Has acertado la palabra");
                }
            }
            else
            {
                llenarMuñeco();
            }
        }
        private void quitarGuion(char c)
        {
            char[] susti = Etiqueta.Content.ToString().ToCharArray();
            for(int i=0;i<palabra.Length;i++)
            {
                if (palabra[i].Equals(c))
                {
                    susti[i] = c;
                }
            }
            String nuevo = "";
            foreach(char ch in susti)
            {
                nuevo += ch;
            }
            Etiqueta.Content=nuevo;
        } 
        private void Lbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                this.palabra = Lbox1.SelectedItem.ToString();
                cambiarEtiqueta();
                vaciarMoñeco();
            }
            catch (Exception)
            {
                
            }
        }
        private void cambiarEtiqueta()
        {
            String provi="";
            for(int i = 0; i < palabra.Length; i++)
            {
                provi += "-";
            }
            Etiqueta.Content = provi;
            
        }
    }
}
