using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCompanies.Models
{
    partial class Streets
    {
        public int CountAbonent
        {
            get
            {
                return Adress.Count;
            }
        }
    }
}
