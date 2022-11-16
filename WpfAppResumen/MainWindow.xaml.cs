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

namespace WpfAppResumen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random aleatorios=new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec;
            SolidColorBrush color;
            for (int i = 0; i < aleatorios.Next(1,11); i++)
            {
                color = new SolidColorBrush(Color.FromRgb(
                    (Byte)aleatorios.Next(256),
                    (Byte)aleatorios.Next(256),
                    (Byte)aleatorios.Next(256)));
                rec =new Rectangle();
                rec.Width = 70;rec.Height = 40;
                rec.Margin=new Thickness(7);
                rec.Fill= color;
                sp1.Children.Add(rec);
            }
        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            Rectangle rec;
            for (int i = 0; i < aleatorios.Next(1, 11); i++)
            {
                rec = new Rectangle();
                rec.Width = 70; rec.Height = 40;
                rec.Margin = new Thickness(7);
                rec.Fill = new SolidColorBrush(Color.FromRgb(
                    (Byte)aleatorios.Next(256),
                    (Byte)aleatorios.Next(256),
                    (Byte)aleatorios.Next(256)));
                wp1.Children.Add(rec);
            }
        }
    }
}
