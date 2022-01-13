//using System;
//using System.IO;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
//using Microsoft.AspNetCore.Http;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using Microsoft.Extensions.Options;

//namespace FunctionApp
//{
//    public class HttpFunction
//    {
//        private readonly MySettings _settings;

//        public HttpFunction(IOptions<MySettings> optionsAccessor)
//        {
//            _settings = optionsAccessor.Value;
//        }

//        [FunctionName(nameof(HttpFunction))]
//        public IActionResult Run(
//            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
//            ILogger log)
//        {
//            log.LogInformation("C# HTTP trigger function processed a request.");

//            var responseMessage = $"SqlConnection : {_settings.SqlConnection}, KeyVaultUrl : {_settings.KeyVaultUrl}";

//            return new OkObjectResult(responseMessage);
//        }
//    }
//}
