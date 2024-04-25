using PhoneCompanies.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PhoneCompanies
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
       public static PhoneCompanyEntities DB = new PhoneCompanyEntities();


        public static PhoneCompanyEntities ContextDB = DB;
    }
}
