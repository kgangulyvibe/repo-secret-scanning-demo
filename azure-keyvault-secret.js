// Example JavaScript file with Azure Key Vault secret leaked
const keyVaultSecret = "https://myvault.vault.azure.net/secrets/mysecret/1234567890abcdef";
const secretValue = "ThisIsASuperSecretValueFromKeyVault";

console.log("Leaked Azure Key Vault Secret URI:", keyVaultSecret);
console.log("Leaked Secret Value:", secretValue);
