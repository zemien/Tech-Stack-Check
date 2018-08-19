using System;

namespace TechStackCheck.AzureStorage.Table
{
    public class AzureTableSettings
    {
        public AzureTableSettings(string storageAccountConnectionString)
        {
            if (string.IsNullOrEmpty(storageAccountConnectionString))
                throw new ArgumentNullException(nameof(storageAccountConnectionString));

            this.StorageAccountConnectionString = storageAccountConnectionString;
        }

        public string StorageAccountConnectionString { get; }
    }
}
