using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;

namespace Client
{
    public partial class WindowsClient : Form
    {

        public WindowsClient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
        }

        void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string err = e.Exception.Message + Environment.NewLine + e.Exception.StackTrace;
            if (e.Exception.InnerException != null)
                err += Environment.NewLine + e.Exception.InnerException.Message + Environment.NewLine + e.Exception.InnerException.StackTrace;
            txtRet.Text = err;
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            SerClient proxy3 = new SerClient("MyCoolEndpoint");
            string ret = proxy3.DoSomething("Salutations");
            txtRet.Text = ret;
        }




    }
}
