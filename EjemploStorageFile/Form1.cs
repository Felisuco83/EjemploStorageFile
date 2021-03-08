using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploStorageFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnleerfile_Click(object sender, EventArgs e)
        {
            //NECESITAMOS LA CLAVE DE ACCESO A STORAGE
            string key = CloudConfigurationManager.GetSetting("storagecnstring");
            //NECESITAMOS ACCEDER A TODA LA CUENTA CLOUD STORAGE PARA PODER ACCEDER A FILES
            CloudStorageAccount account = CloudStorageAccount.Parse(key);
            CloudFileClient client = account.CreateCloudFileClient();
            CloudFileShare fileshare = client.GetShareReference("ejemplo");
            CloudFileDirectory raiz = fileshare.GetRootDirectoryReference();
            CloudFile file = raiz.GetFileReference("clientessimples.json");
            string contenido = await file.DownloadTextAsync();
            this.txtcontenido.Text = contenido;
        }
    }
}
