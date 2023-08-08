using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager= new PersonalFinanceCreditManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager homeLoanManager = new HomeLoanManager();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.DoApplication(personalFinanceCreditManager);

             
            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager , vehicleLoanManager };
            applicationManager.DoCreditInfo(credits);
            
        }
    }
}
