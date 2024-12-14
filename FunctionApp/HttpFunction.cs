using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.Azure.WebJobs;
//using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Azure.Functions.Worker;

namespace FunctionApp
{
    public class HttpFunction
    {
        private readonly ILogger<HttpFunction> _logger;
        private readonly MySettings _settings;

        public HttpFunction(ILogger<HttpFunction> logger, IOptions<MySettings> optionsAccessor)
        {
            _logger = logger;
            _settings = optionsAccessor.Value;
        }

        [Function(nameof(HttpFunction))]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var responseMessage = $"SqlConnection : {_settings.SqlConnection}, KeyVaultUrl : {_settings.KeyVaultUrl}";

            return new OkObjectResult(responseMessage);
        }
    }
}
