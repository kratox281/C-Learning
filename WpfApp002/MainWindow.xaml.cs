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

namespace WpfApp002
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid grid0;
        public MainWindow()
        {
            InitializeComponent();

            grid0 = (Grid)this.Content;
            for (int i = 0; i < 3; i++)
            {
                grid0.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(i * 10) });
            }
            for (int i = 0; i < 2; i++)
            {
                grid0.ColumnDefinitions.Add(new ColumnDefinition());
            }
            Button b1 = new Button() { Content = "uno" };
            Grid.SetColumn(b1, 1);
            Grid.SetRow(b1, 2);
            grid0.Children.Add(b1);

            StackPanel sp = new StackPanel();
            grid0.Children.Add(sp);
            Grid.SetRow(sp, 2);
            Grid.SetColumn(sp, 1);
            for (int i = 0; i < 10; i++)
            {
                TextBlock tb = new TextBlock();
                tb.Background = Brushes.DarkSeaGreen;
                sp.Children.Add(tb);
            }
        }
    }
}
