using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Agua
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Deposito deposito = new Deposito();
        public MainWindow()
        {
            InitializeComponent();
            deposito.Cantidad_Changed += Deposito_Cantidad_Changed;
            deposito.DepositoVacio += Deposito_Vacio;
            deposito.DepositoLleno += Deposito_Lleno;
            deposito.Cantidad = (int) pbAgua.Value;
            
        }
        private void Deposito_Lleno(object sender, System.EventArgs e)
        {
            MessageBox.Show("Estoy lleno abuela","XD",MessageBoxButton.OK,MessageBoxImage.Warning);


        }
        private void Deposito_Cantidad_Changed(object sender, System.EventArgs e)
        { 
            pbAgua.Value = deposito.Cantidad;
            bBeber.IsEnabled = (deposito.Cantidad > 0);

        }
        private void Deposito_Vacio(object sender,System.EventArgs e)
        {
            bBeber.IsEnabled=false;
        }
        private void bBeber_Click(object sender, RoutedEventArgs e)
        {
            if (pbAgua.Value > 0)
            {
                deposito.Cantidad -= 1;
              

            }
        }

        private void bLlenar_Click(object sender, RoutedEventArgs e)
        {
            deposito.Llenar(10);
        }
    }
}
