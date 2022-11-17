using System;
using System.Windows;
using System.Windows.Threading;

namespace WpfAppDockPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();

            dispatcherTimer.Tick += DispatcherTimer_Tick; ;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object? sender, EventArgs e)
        {
            labelReloj.Content = DateTime.Now.ToString("T");
        }

    }
}
