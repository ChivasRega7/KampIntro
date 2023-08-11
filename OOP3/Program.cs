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

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService()};


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(new BusinessLoanManager(), loggers );


            List<ICreditManager> credits = new List<ICreditManager>() { personalFinanceCreditManager , vehicleLoanManager };
            
            //applicationManager.DoCreditInfo(credits);
            
        }
    }
}
