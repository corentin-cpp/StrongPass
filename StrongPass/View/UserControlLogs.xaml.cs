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
using StrongPass.Model;

namespace StrongPass.View
{
    /// <summary>
    /// Logique d'interaction pour UserControlLogs.xaml
    /// </summary>
    public partial class UserControlLogs : UserControl
    {
        BDStrongPassEntities data = new BDStrongPassEntities();
        public UserControlLogs()
        {
            InitializeComponent();
            var result = data.TableLogs.ToList();
            DatatGridLogs.ItemsSource = result;
        }
    }
}