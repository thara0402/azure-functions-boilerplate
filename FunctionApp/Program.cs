using Azure.Identity;
using FunctionApp;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Reflection;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly());

builder.Services
    .Configure<MySettings>(builder.Configuration.GetSection("Function"))
    .AddApplicationInsightsTelemetryWorkerService()
    .ConfigureFunctionsApplicationInsights();

if (builder.Configuration["AzureWebJobsStorage"] != "UseDevelopmentStorage=true")
{
    var keyVaultUrl = builder.Configuration["Function:KeyVaultUrl"];
    if (!string.IsNullOrEmpty(keyVaultUrl))
    {
        builder.Configuration.AddAzureKeyVault(new Uri(keyVaultUrl), new DefaultAzureCredential());
    }
}

builder.Build().Run();
