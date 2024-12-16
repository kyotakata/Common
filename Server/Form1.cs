using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        private ServerModel _Model;

        public Form1()
        {
            InitializeComponent();

            _Model = new ServerModel();
            this.Text = "IPC通信サービス開始";


            if (_Model.GetState() == CommunicationState.Opened)
            {
                this.Text = "IPC通信サービス使用可能";
            }
        }
    }
}
