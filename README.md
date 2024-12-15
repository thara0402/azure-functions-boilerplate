# Azure Functions Boilerplate
[![Build and deploy](https://github.com/thara0402/azure-functions-boilerplate/actions/workflows/main_gunners-style-func.yml/badge.svg)](https://github.com/thara0402/azure-functions-boilerplate/actions/workflows/main_gunners-style-func.yml)

## Secret Manager

```json
{
  "Function": {
    "SqlConnection": "SQL Connection for Secret Manager."
  }
}
```
## local.settings.json

```json
{
    "IsEncrypted": false,
    "Values": {
      "AzureWebJobsStorage": "UseDevelopmentStorage=true",
      "FUNCTIONS_WORKER_RUNTIME": "dotnet-isolated",
      "StorageBindingConnection": "UseDevelopmentStorage=true"
    }
}
```

## Azurite
```shell
$ docker run --rm -it -p 10000:10000 -p 10001:10001 -p 10002:10002 -v c:/azurite:/data mcr.microsoft.com/azure-storage/azurite:3.33.0
```

## Use Key Vault from Functions with Azure Managed Identity
```shell
$ az functionapp identity assign --name "<Function Apps Name>" --resource-group "<Resource Group Name>"
{
  "principalId": "xxx",
  "tenantId": "yyy",
  "type": "SystemAssigned",
  "userAssignedIdentities": null
}

$ az keyvault set-policy --name "<Key Vault Name>" --object-id "xxx" --secret-permissions get list
```
