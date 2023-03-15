using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace giveToken
{
    public class giveToken
    {
        private static HttpClient _client;
        static giveToken()
        {
            // 初期化処理
            _client = new HttpClient();
        }
        [FunctionName("giveToken")]
        public void Run([TimerTrigger("0 35 1 * * *")] TimerInfo myTimer, ILogger log)
        {
            _client.GetAsync("https://app-backend-debug.azurewebsites.net/api/transaction/give");
        }
    }
}

