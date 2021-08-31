using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeIT.Treina.D365Finance.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CreditLimitWeb creditLimitWeb = new CreditLimitWeb())
            {
                string amount = creditLimitWeb.getCustomerCreditLimit("https://primeit-treina.azurewebsites.net/api/limitcreditcalc?externalId=123");
                Console.WriteLine(amount);
            }
            
            Console.ReadKey();
        }
    }
}
