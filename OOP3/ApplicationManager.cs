using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager //Başvuru Manager
    {
        //Method Injection

        public void DoApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //...
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void DoCreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
