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

namespace ProgramaPalabras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string palabra = "";
        public MainWindow()
        {
            InitializeComponent();
            llenarListbox1();
        }

        private void botA_Click(object sender, RoutedEventArgs e)
        {
            if (palabra.Equals(""))
            {
                MessageBox.Show("Selecciona una palabra");
            }
            else
            {
                try
                {
                    char selected = tbxLetra.Text[0];
                    comprobar(selected);
                    tbxLetra.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("No has escrito nada");
                }
            }
        }
        private void comprobar(char c)
        {
            if (this.palabra.Contains(c))
            {
                sustituir(c);
                if (!tbkPalabra.Text.Contains("-"))
                {
                    MessageBox.Show("¡¡Acertaste la palabra!!");
                }
            }
            else
            {
                MessageBox.Show("No está");
            }
        }

        private void sustituir(char c)
        {
            char[] cambio = tbkPalabra.Text.ToCharArray();
            string sustituye = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i].Equals(c))
                {
                    cambio[i] = c;
                }

            }
            foreach (char ch in cambio)
            {
                sustituye += ch;
            }
            tbkPalabra.Text = sustituye;
        }

        private void botSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (lbPalabras.SelectedIndex != lbPalabras.Items.Count - 1)
            {
                lbPalabras.SelectedIndex = lbPalabras.SelectedIndex + 1;
            }
            else
            {
                lbPalabras.SelectedIndex = 0;
            }


        }
        private void llenarListbox1()
        {
            String[] lista = { "Berenjena", "coliflor", "mosca", "baño", "estercolero", "zanahoria", "gusarapa", "pizza" };
            foreach (string word in lista)
            {
                lbPalabras.Items.Add(word);
            }
        }

        private void lbPalabras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string guiones = "";
            palabra = (string)lbPalabras.SelectedItem;
            for (int i = 0; i < palabra.Length; i++)
            {
                guiones += "-";
            }
            tbkPalabra.Text = guiones;
        }
    }
}
