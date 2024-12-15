using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
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
