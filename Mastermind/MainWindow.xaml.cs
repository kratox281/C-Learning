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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        private int[] oculto;
        private int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
            generarNumero();
        }

        private void BotComprobar_Click(object sender, RoutedEventArgs e)
        {
            int[] user = convertir();
            int acertados = comprobarExistencia(user);
            int colocados = comprobarPosi(user);
            LbHistorial.Items.Add(TbPropuesto.Text + " " + acertados + " " + colocados);
            if(acertados==4 && colocados == 4)
            {
                MessageBox.Show("¡Has Acertado!");
                reset();
                generarNumero();

            }
        }
        private void reset()
        {
            contador = 0;
            TbPropuesto.Text = null;
            bot0.IsEnabled = true;
            bot1.IsEnabled = true;
            bot2.IsEnabled = true;
            bot3.IsEnabled = true;
            bot4.IsEnabled = true;
            bot5.IsEnabled = true;
            bot6.IsEnabled = true;
            bot7.IsEnabled = true;
            bot8.IsEnabled = true;
            bot9.IsEnabled = true;
        }
        private int comprobarPosi(int[] usuario)
        {
            int contador = 0;
         for(int i = 0; i < 4; i++)
            {
                if (oculto[i] == usuario[i])
                {
                    contador++;
                }
            }
            return contador;
        }
        private int comprobarExistencia(int[] usuario)
        {
            int contador = 0;
            foreach(int n in usuario)
            {
                if (oculto.Contains(n))
                {
                    contador++;
                }
            }
            return contador;
           
        }
        private int[] convertir()
        {
            string temp = TbPropuesto.Text;
            int[] conver = new int[4];
            char[] unico = temp.ToCharArray();
            for (int i  =0; i < 4; i++)
            {
                string solo =""+unico[i];
                int prov = int.Parse(solo);
                conver[i] = prov;
            }
            
            return conver;
        }
        private void BotOtro_Click(object sender, RoutedEventArgs e)
        {
            reset();
            generarNumero();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (contador < 4) {
                Button boton = (Button)sender; 
                contador++;
                String temp = (string)boton.Content;
                aniadir(temp);
                boton.IsEnabled = false;

            }
            

        }
        private void aniadir(String n)
        {
            String temp = TbPropuesto.Text;
            temp += n;
            TbPropuesto.Text = temp;
        } 
        private void generarNumero()
        {
           
            oculto = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int n = rand.Next(10);
                do
                {
                    n = rand.Next(10);

                } while (comprobarRepe(n, oculto));
                oculto[i] = n;
               
            }
            
        }
        private bool comprobarRepe(int n, int[] wrap)
        {
            if (wrap.Contains(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BotCancelar_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
    }
}
