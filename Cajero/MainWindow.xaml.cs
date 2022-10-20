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

namespace Cajero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> cajetin = new Dictionary<string, int>();
        String pin = "";
        String cantidad = "";
        int cantidadTotal = 6800;
        bool pedir_dinero = false;
        public MainWindow()
        {
            InitializeComponent();
            añadirDinero();
        }

        private void Digitos_Click(object sender, RoutedEventArgs e)
        {
            Button bot = (Button)sender;
            String temp = (String)bot.Content;
            if (!pedir_dinero)
            {
                pin += temp;
                textBlockDisplay.Text += "*";
            }
            else
            {
                cantidad += temp;
                textBlockDisplay.Text += temp;
            }
        }

        private void botonBorrar_Click(object sender, RoutedEventArgs e)
        {
            pin = "";
            cantidad = "";
            if (!pedir_dinero)
            {
                textBlockDisplay.Text = "Introduzca su pin:";
            }
            else
            {
                textBlockDisplay.Text = "Introduzca la cantidad: ";
            }
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {//ok
            if (!pedir_dinero)
            {
                if (pin.Equals("0000"))
                {
                    pedir_dinero = true;
                    //listBoxResultado.Items.Add( "Pin Correcto");
                    //MessageBox.Show("Pin correcto");
                    textBlockDisplay.Text = "Introduzca la cantidad: ";
                    pin = "";
                }
                else
                {
                    listBoxResultado.Items.Add("Pin Incorrecto");
                    //MessageBox.Show("Pin incorrecto");
                    textBlockDisplay.Text = "Introduzca su pin:";
                    pin = "";
                }
            }
            else
            {
                //MessageBox.Show(cantidad);
                if (comprobar())
                {
                    textBlockDisplay.Text = "Recoja su dinero";
                    darDinero();
                }
                else
                {
                    listBoxResultado.Items.Add("Cantidad Insuficiente");
                    textBlockDisplay.Text = "Introduzca su pin:";
                    cantidad = "";
                    pin = "";
                }
            }
        }

        private void botonRecoger_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxResultado.HasItems)
            {
                textBlockDisplay.Text = "Introduzca su pin:";
                pin = "";
                cantidad = "";
                listBoxResultado.Items.Clear();
                pedir_dinero = false;
            }
        }


        private bool comprobar()
        {

            if (cantidadTotal < int.Parse(cantidad))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void darDinero()
        {
            int temp = 0;
            listBoxResultado.Items.Clear();
            while (true)
            {
                int dar = int.Parse(cantidad);
                if (dar - 200 >= 0)
                {
                    dar -= 200;
                    cantidadTotal -= 200;
                    temp = cajetin["200"];
                    cajetin["200"] = temp - 1;
                    listBoxResultado.Items.Add("200€");
                }
                if (dar - 100 >= 0)
                {
                    dar -= 100;
                    cantidadTotal -= 200;
                    temp = cajetin["100"];
                    cajetin["100"] = temp - 1;
                    listBoxResultado.Items.Add("100€");
                }
                if (dar - 50 >= 0)
                {
                    dar -= 50;
                    cantidadTotal -= 200;
                    temp = cajetin["50"];
                    cajetin["50"] = temp - 1;
                    listBoxResultado.Items.Add("50€");
                }
                if (dar - 20 >= 0)
                {
                    dar -= 20;
                    cantidadTotal -= 200;
                    temp = cajetin["20"];
                    cajetin["20"] = temp - 1;
                    listBoxResultado.Items.Add("20€");
                }
                if (dar - 10 >= 0)
                {
                    dar -= 10;
                    cantidadTotal -= 200;
                    temp = cajetin["10"];
                    cajetin["10"] = temp - 1;
                    listBoxResultado.Items.Add("10€");
                }
                if (dar == 0)
                {
                    actualizar_billetes();
                    break;

                }
                if (dar - 10 < 0)
                {
                    dar = 0;
                    MessageBox.Show("Se ha adaptado la cantidad a medidas que puede dar el cajero");
                }


            }

        }
        private void añadirDinero()
        {
            cajetin["200"] = 10;
            cajetin["100"] = 20;
            cajetin["50"] = 30;
            cajetin["20"] = 40;
            cajetin["10"] = 50;
            lbBilletes.Items.Add(10);
            lbBilletes.Items.Add(20);
            lbBilletes.Items.Add(30);
            lbBilletes.Items.Add(40);
            lbBilletes.Items.Add(50);
        }
        private void actualizar_billetes()
        {
            lbBilletes.Items.Clear();
            lbBilletes.Items.Add(cajetin["200"]);
            lbBilletes.Items.Add(cajetin["100"]);
            lbBilletes.Items.Add(cajetin["50"]);
            lbBilletes.Items.Add(cajetin["20"]);
            lbBilletes.Items.Add(cajetin["10"]);

        }
    }
}
