using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
    /// Logique d'interaction pour UserControlDefault.xaml
    /// </summary>
    public partial class UserControlDefault : UserControl
    {
        public UserControlDefault()
        {
            InitializeComponent();
        }


        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(textBox_ResultPass.Text);
        }

        private void button_Generate_Click(object sender, RoutedEventArgs e)
        {
            string result = GetApiResult(SelectSizePass(Convert.ToInt32(slider_lenght.Value)));
            textBox_ResultPass.Text = result;
            button_Copy.IsEnabled = true;
            button_Copy.Foreground = Brushes.White;
            AddLogs(result, DateTime.Now);
        }

        private static string GetApiResult(int lenght)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadString($"https://random.justyy.workers.dev/api/random/?cached&n={lenght}");
            }
        }

        private int SelectSizePass(int value)
        {

            switch (value)
            {
                case 0:
                    break;

                case 1:
                    return 5;
                    break;

                case 2:
                    return 8;
                    break;

                case 3:
                    return 12;
                    break;

                case 4:
                    return 16;
                    break;

                case 5:
                    return 20;
                    break;

                default:
                    break;
            }

            return 0;
        }

        private void AddLogs(string pass, DateTime date)
        {
            BDStrongPassEntities data = new BDStrongPassEntities();
            TableLogs tableLogs = new TableLogs
            {
                Result = pass,
                Date = date.ToString()
            };

            data.TableLogs.Add(tableLogs);
            data.SaveChanges();
        }
    }
}
