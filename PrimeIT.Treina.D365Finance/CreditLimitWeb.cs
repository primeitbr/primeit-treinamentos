using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrimeIT.Treina.D365Finance
{
    public class CreditLimitWeb : IDisposable
    {
        HttpClient client;

        public CreditLimitWeb()
        {
            client = new HttpClient();
        }

        public void Dispose()
        {
            client = null;
        }

        public string getCustomerCreditLimit(string uri)
        {
            var responseTask = client.PostAsync(uri, null);
            var response = responseTask.Result;
            var amount = response.Content.ReadAsStringAsync();

            return amount.Result;
        }
    }
}
