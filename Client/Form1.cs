using Common;
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

namespace Client
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// クライアントモデル
        /// </summary>
        private ClientModel _Model;


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Model = new ClientModel();

            // プロセス間通信でサーバに指示を出し、結果を受け取る
            var result = _Model.ExecuteServerSide();

            button1.Text = result.ToString();

        }
    }
}
