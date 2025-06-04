# Example Python file with Azure Storage Account Key leaked
import os

AZURE_STORAGE_KEY = "DefaultEndpointsProtocol=https;AccountName=demoaccount;AccountKey=AbCdEfGhIjKlMnOpQrStUvWxYz1234567890abcdefghijklmn==;EndpointSuffix=core.windows.net"

print("Leaked Azure Storage Key:", AZURE_STORAGE_KEY)
