using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hamdi Ekmekçi
            IndividualCustomer customer1= new IndividualCustomer();
            customer1.CustomerId = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Hamdi";
            customer1.LastName = "Ekmekci";
            customer1.TcNo = "123456789123";

            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.CustomerId = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Gerçek - Tüzel nesne ayrı şeylerdir ve birbirinin yerine kullanılamazlar.
            //SO(L)ID yukarıdaki kuralı L söyler.

            Customer customer3 = new IndividualCustomer(); //new IndividualCustomer() -> Ref. No
            Customer customer4 = new CoorporateCustomer(); //new CoorporateCustomer() -> Ref. No
            //Customer class can hold each Ind. and Coorp. customers

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


        }
    }
}
