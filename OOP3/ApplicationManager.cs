using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager //Başvuru Manager
    {
        public void DoApplication(ICreditManager creditManager)
        {
            //Başvuran bilgilerini değerlendirme
            //...
            creditManager.Calculate();
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
