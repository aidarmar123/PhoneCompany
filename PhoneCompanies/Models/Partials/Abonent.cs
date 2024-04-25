using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCompanies.Models
{
    partial class Abonent
    {
        
        public string FullName
        {
            get
            {
                return $"{Name} {Fename} {Surname}";
            }
        }
        [Name("Phone Home")]
        public string PhoneHome
        {
            //Type 1 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == Id && pn.TypeId == 1);
                return phone.Phone;
            }
            set { }
        }
        [Name("Phone Work")]
        public string PhoneWork
        {
            //Type 2 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == Id && pn.TypeId == 2);
                return phone.Phone;
            }
        }
        [Name("Phone Mobile")]
        public string PhoneMobile
        {

            //Type 3 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == Id && pn.TypeId == 3);
                return phone.Phone;
            }
        }
    }
}
