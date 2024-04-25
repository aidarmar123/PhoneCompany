using PhoneCompanies.Windows;
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

namespace PhoneCompanies
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            App.mainWindow=this;
            App.Refresh();
        }

        

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            new SearchNumber().ShowDialog();
        }


        private void BInstallCSV_Click(object sender, RoutedEventArgs e)
        {
            new InstallCSV().ShowDialog();
        }

        private void BStreets_Click(object sender, RoutedEventArgs e)
        {
            new StreetsWindow().Show();
        }

        private void BAll_Click(object sender, RoutedEventArgs e)
        {
            App.contextAbonets = App.DB.Abonent.ToList();
            App.Refresh();
        }
    }
}
