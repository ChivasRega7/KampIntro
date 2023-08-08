using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    //Gerçek Müşteri
    // : ->Inheritance = You are a Customer now
    class IndividualCustomer : Customer
    {

        public string TcNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
