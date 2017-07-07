## Storing Secrets in Azure Key Vault with ASP.NET Core
How to Store Secrets in Azure Key Vault Using ASP.NET Core

Read the full tutorial here : https://www.humankode.com/asp-net-core/how-to-store-secrets-in-azure-key-vault-using-net-core

Remember to add azurekeyvault.json to your project (the file has been excluded with .gitignore)
```json
{
  "azureKeyVault": {
    "vault": "keyvault-name",
    "clientId": "",
    "clientSecret": ""
  } 
}
```