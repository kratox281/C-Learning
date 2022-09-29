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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //No tocar NUNCA;
            LlenarLB1();
            boton1.Content = "LB2 Cleaner";
            sp1.Children.Add(
                new Button()
                {
                    Content = "Boton dos",
                    Margin = new Thickness(3),
                });
            Button boton3 = new Button();
            boton3.Content = "boton 3";
            boton3.Margin = new Thickness(3);
            sp1.Children.Add(boton3);
            boton3.Click += Boton3_Click;
         }

        private void Boton3_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add("Boton 3");
        }

        public void LlenarLB1()
        {
            listBox1.Items.Add("Holaaaaaaa");
            listBox1.Items.Add("UWU");


        }



        private void listBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string elemento = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(elemento);
            labelElemento.Content = elemento;
            try
            {
                int valor = Convert.ToInt32(elemento);
            }
            catch (Exception)
            {
                MessageBox.Show("Errror");
            }
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void supu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
