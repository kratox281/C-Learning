using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
namespace Reloj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        private int interval = 1000;
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += cambiarHora;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void cambiarHora(object? sender,EventArgs e)
        {
           
                mostrarHora.Text = DateTime.Now.ToString("H:mm:ss");
            
        }
    }
    
}
