using CsvHelper;
using Microsoft.Win32;
using PhoneCompanies.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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
using System.Windows.Shapes;

namespace PhoneCompanies.Windows
{
    /// <summary>
    /// Логика взаимодействия для InstallCSV.xaml
    /// </summary>
    public partial class InstallCSV : Window
    {
        public InstallCSV()
        {
            InitializeComponent();
            Refresh();
            
        }

        private void Refresh()
        {
            DGData.ItemsSource = App.contextAbonets;
        }

        private void BInstall_Click(object sender, RoutedEventArgs e)
        {
            var saveFile = new SaveFileDialog() { Filter = ".csv | *.csv" };
            if(saveFile.ShowDialog().GetValueOrDefault())
            {
                
                using(var writer = new StreamWriter(saveFile.FileName))
                {
                    using(var csv = new CsvWriter(writer,CultureInfo.InvariantCulture))
                    {
                        foreach(var abonets in App.contextAbonets)
                        {
                            var data = new
                            {
                                Name = abonets.FullName,
                                NumberHome = abonets.Adress.NumberHome,
                                NameStreet = abonets.Adress.Streets.Name,
                                PhoneMobile = abonets.PhoneMobile,
                                PhoneHome = abonets.PhoneHome,
                                PhoneWork = abonets.PhoneWork,

                            };
                            csv.WriteRecord(data);
                            csv.NextRecord();
                        }
                    }
                }
            }
        }
    }
}
