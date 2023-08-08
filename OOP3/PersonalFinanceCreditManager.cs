using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyaç Kredisi ödeme planı hesaplandı");

        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
