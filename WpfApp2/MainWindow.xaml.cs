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
using System.Windows.Threading;

namespace WpfApp2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        DispatcherTimer tmr = new DispatcherTimer();
        TimeSpan tmspan = new TimeSpan(0, 0, 0);
        public MainWindow() {
            InitializeComponent();
            tmr.Interval = new TimeSpan(0, 0, 1);
            tmr.Tick += delegate {
                lbl.Content = (tmspan = tmspan.Add(new TimeSpan(0, 0, 1))).ToString(@"mm\:ss");
            };
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            tmr.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            tmr.IsEnabled = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            tmr.IsEnabled = false;
            tmspan = new TimeSpan(0, 0, 0);
            lbl.Content = tmspan.ToString(@"mm\:ss");
        }
    }
}
