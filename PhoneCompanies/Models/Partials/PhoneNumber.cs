﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCompanies.Models
{
    partial class PhoneNumber
    {

        public string PhoneHome
        {
            //Type 1 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == AbonentId && pn.TypeId == 1);
                return phone.Phone;
            }
        }
        public string PhoneWork
        {
            //Type 2 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == AbonentId && pn.TypeId == 2);
                return phone.Phone;
            }
        }
        public string PhoneMobile
        {

            //Type 3 - мобильный телефон в БД
            get
            {
                var phone = App.DB.PhoneNumber.FirstOrDefault(pn => pn.AbonentId == AbonentId && pn.TypeId == 3);
                return phone.Phone;
            }
        }
    }
}
