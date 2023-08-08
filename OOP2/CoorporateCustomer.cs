using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Tüzel Müşteri
    // : ->Inheritance = You are a Customer now
    class CoorporateCustomer : Customer
    {
       
        public string CompanyName { get; set; }

        public string TaxNo { get; set; }
    }
}
