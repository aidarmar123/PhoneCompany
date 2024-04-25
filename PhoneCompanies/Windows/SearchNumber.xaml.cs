using PhoneCompanies.Models;
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
using System.Windows.Shapes;

namespace PhoneCompanies.Windows
{
    /// <summary>
    /// Логика взаимодействия для SearchNumber.xaml
    /// </summary>
    public partial class SearchNumber : Window
    {
        public string InputSearchNumber { get; set; }
        public SearchNumber()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BSearch_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(InputSearchNumber))
            {
                List<Abonent> abonents = App.DB.Abonent.ToList();
                
                var newList = abonents.Where(ab => ab.PhoneHome.Contains(InputSearchNumber)
                || ab.PhoneWork.Contains(InputSearchNumber) 
                || ab.PhoneMobile.Contains(InputSearchNumber))
                .ToList();
                if (newList.Count > 0) 
                {
                    App.contextAbonets = newList;
                    App.Refresh();
                }
                else
                {
                    MessageBox.Show("Not found abonents satisfying the search criteria");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Line is empty");
            }
            

        }
    }
}
