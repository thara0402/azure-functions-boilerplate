# Azure Functions Boilerplate
[![Build and deploy](https://github.com/thara0402/azure-functions-boilerplate/actions/workflows/main_gunners-style-func.yml/badge.svg)](https://github.com/thara0402/azure-functions-boilerplate/actions/workflows/main_gunners-style-func.yml)

## Secret Manager

```json
{
  "WebApi": {
    "StorageConnection": "UseDevelopmentStorage=true"
  }
}
```
## Azurite
```shell
$ docker run --rm -it -p 10000:10000 -p 10001:10001 -p 10002:10002 -v c:/azurite:/data mcr.microsoft.com/azure-storage/azurite:3.12.0
```

## Use Key Vault from App Service with Azure Managed Identity
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
