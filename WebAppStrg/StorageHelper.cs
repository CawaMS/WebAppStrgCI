using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.WindowsAzure;

using Microsoft.Azure;

using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace WebAppStrg
{
    public class StorageHelper
    {
        string connectionString = CloudConfigurationManager.GetSettingFromSecret("ImageStore");

        CloudStorageAccount sa = CloudStorageAccount.Parse(connectionString);

        public void addBlob(string filePath)
        {

        }

        public void downloadBlob(string fileName, string outputPath)
        {

        }
    }
}