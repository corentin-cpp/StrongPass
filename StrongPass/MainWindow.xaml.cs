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
using System.Net;
using StrongPass.View;

namespace StrongPass
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        private static Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
            GridDefult.Children.Add(new UserControlDefault());
        }

        private void button_Logs_Click(object sender, RoutedEventArgs e)
        {
            GridDefult.Children.Clear();
            GridDefult.Children.Add(new UserControlLogs());
        }

        private void button_Generate_Click(object sender, RoutedEventArgs e)
        {
            GridDefult.Children.Clear();
            GridDefult.Children.Add(new UserControlDefault());
        }
    }
}
