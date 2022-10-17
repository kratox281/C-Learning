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

namespace Cafe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private float[] monedas = { 3, 2, 1, 0.5f, 0.2f, 0.1f };
        private Deposito deposito = new Deposito();
        private String[] productos = { "agua", "cafe", "chocolate" };
        private Button boton;
        private float coste;

        public MainWindow()
        {
            InitializeComponent();
            crearBotones();
            llenarProductos();
            deposito.TotalChange += exito;
            deposito.MonedaNoValida += error;
        }

        private void crearBotones()
        {
            foreach(float moneda in monedas)
            {
                boton = new Button();
                boton.Width = 51;
                boton.Height = 29;
                boton.Click += click_Boton;
                boton.Margin = new Thickness(4);
                boton.Content = moneda;
                spMonedas.Children.Add(boton);
            }
            boton = new Button();
            boton.Width = 51;
            boton.Height = 29;
            boton.Click += devolver_boton;
            boton.Content = "Devolver";
            boton.Margin = new Thickness(4);
            spMonedas.Children.Add(boton);
        }
        private void llenarProductos()
        {
            foreach(String producto in productos)
            {
                boton = new Button();
                boton.Height = 29;
                boton.Click += seleccionar;
                boton.Content = producto;
                boton.Margin = new Thickness(4);
                spProductos.Children.Add(boton);
            }
            boton = new Button();
            boton.Height = 29;
            boton.Click += recoger;
            boton.Content = "Recoger";
            boton.Margin = new Thickness(4);
            spProductos.Children.Add(boton);
        }
        private void recoger(object sender, EventArgs e)
        {
            if (tbDispensador.Text != "")
            {
                MessageBox.Show("Gracias por su compra");
            }
            tbDispensador.Text = "";
            tbVuelta.Text = "";
            
        }

        private void add()
        {
            String mostrar="";
            coste = 0;
            foreach(float moneda in deposito.Introducido)
            {
                mostrar += " " + moneda.ToString() + "€ ";
                coste += moneda;
                deposito.Total+=moneda;
            }
            mostrar += " Total:" + coste.ToString() + "€";
            tbPresupuesto.Text = mostrar;
        }
        private void dar_vuelta()
        {
            string devolucion = "";
            float vuelta = 0;
            coste = coste-1;
            foreach (float moneda in deposito.monedas)
            {
                if (coste % moneda == 0 )
                {
                    float temp = coste;
                    for (int i = 0; i < temp / moneda; i++)
                    {
                        deposito.Vuelta.Add(moneda);
                        coste = coste-moneda;
                    }
                }
            }
            tbPresupuesto.Text = "";
            foreach(float moneda in deposito.Vuelta)
            {
                devolucion += moneda.ToString()+"€ ";
                vuelta += moneda;
            }
            devolucion += " : " + vuelta + "€";
            tbVuelta.Text = devolucion;
        }

        private void seleccionar(object sender, EventArgs e)
        {
            Button bot = (Button)sender;
            if (coste > 1)
            {
                MessageBox.Show("Dispensando tu producto: " + bot.Content);
                dar_vuelta();
                tbDispensador.Text = bot.Content+"";
            }
            else
            {
                float temp = 1 - coste;
                MessageBox.Show("Faltan " + temp+"€");
            }
        }
        private void devolver_boton(object sender, EventArgs e)
        {
            deposito.Introducido.Clear();
            tbPresupuesto.Text = "";
        }
        private void click_Boton(object sender, EventArgs e)
        {
            Button pulsado = (Button)sender;
            float temp = (float)pulsado.Content;
            if (deposito.monedas.Contains(temp))
            {
                deposito.Introducido.Add(pulsado.Content);
                add();
            }
        }
        public void exito(object sender, System.EventArgs e)
        {
            MessageBox.Show("Se ha introducido la moneda");
        }
        public void error(object sender, System.EventArgs e)
        {
            MessageBox.Show("Moneda no existente");
        }

    }
}
