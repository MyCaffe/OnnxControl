using Onnx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnnxControl.app.Test
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void getModelFile(string strUrl, string strPath)
        {
            if (!File.Exists(strPath))
            {
                using (WebClient client = new WebClient())
                {
                    Trace.WriteLine("Downloading '" + strUrl + "' - this may take awhile...");
                    client.DownloadFile(strUrl, strPath);
                }
            }
        }

        private void btnLoadInceptionV1(object sender, EventArgs e)
        {
            PersistOnnx persist = new PersistOnnx();

            string strTestPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MyCaffe\\test_data\\models\\onnx_b";
            if (!Directory.Exists(strTestPath))
                Directory.CreateDirectory(strTestPath);

            string strModelFileSmall = strTestPath + "\\inception-v1-9.onnx";
            string strDownloadPathSmall = "https://github.com/onnx/models/raw/main/vision/classification/inception_and_googlenet/inception_v1/model/inception-v1-9.onnx";
            string strDownloadPath = strDownloadPathSmall;
            string strModelFile = strModelFileSmall;

            getModelFile(strDownloadPath, strModelFile);

            ModelProto model = persist.Load(strModelFile);

            Trace.WriteLine("Loaded model file '" + strModelFile + "'...");
            Trace.WriteLine("Version = " + model.IrVersion.ToString());
            Trace.WriteLine("Producer Name = " + model.ProducerName);
            Trace.WriteLine("Producer Version = " + model.ProducerVersion);
            Trace.WriteLine("Model Version = " + model.ModelVersion.ToString());
            Trace.WriteLine("Description = " + model.DocString);
            Trace.WriteLine("Domain = " + model.Domain);
        }

        private void btnLoadInceptionV2(object sender, EventArgs e)
        {
            PersistOnnx persist = new PersistOnnx();

            string strTestPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\MyCaffe\\test_data\\models\\onnx_b";
            if (!Directory.Exists(strTestPath))
                Directory.CreateDirectory(strTestPath);

            string strModelFileSmall = strTestPath + "\\inception-v2-9.onnx";
            string strDownloadPathSmall = "https://github.com/onnx/models/raw/main/vision/classification/inception_and_googlenet/inception_v2/model/inception-v2-9.onnx";
            string strDownloadPath = strDownloadPathSmall;
            string strModelFile = strModelFileSmall;

            getModelFile(strDownloadPath, strModelFile);

            ModelProto model = persist.Load(strModelFile);

            Trace.WriteLine("Loaded model file '" + strModelFile + "'...");
            Trace.WriteLine("Version = " + model.IrVersion.ToString());
            Trace.WriteLine("Producer Name = " + model.ProducerName);
            Trace.WriteLine("Producer Version = " + model.ProducerVersion);
            Trace.WriteLine("Model Version = " + model.ModelVersion.ToString());
            Trace.WriteLine("Description = " + model.DocString);
            Trace.WriteLine("Domain = " + model.Domain);
        }
    }
}
