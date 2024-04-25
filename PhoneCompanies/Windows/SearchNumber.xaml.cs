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
                //var newList = App.DB.Abonent(a=>a.)
            }
            else
            {
                MessageBox.Show("Line is empty");
            }
            MessageBox.Show("Not found abonents satisfying the search criteria");

        }
    }
}
