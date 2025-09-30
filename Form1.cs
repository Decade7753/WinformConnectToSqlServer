using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormConnectToSqlServer_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //把所有的控件都初始化
            InitializeComponent();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("账号:" + accountText.Text + "\n密码:" + passwordText.Text);
        }
    }
}
