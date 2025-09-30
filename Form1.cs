using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormConnectToSqlServer_Project.EFCore;

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
            #region NoticeUesrToInput
            if (String.IsNullOrEmpty(accountText.Text))
                MessageBox.Show("请输入账号");
            else
                return;
            if (String.IsNullOrEmpty(passwordText.Text))
                MessageBox.Show("请输入密码");
            else
                return;
            #endregion


            using (MyDbContext database = new MyDbContext())
            {
                List<ModelForEF> result = database.modelForEfInfo.Where(m => m.username == accountText.Text && m.password == passwordText.Text).ToList();
                if(result.Count == 1)
                    MessageBox.Show("登录成功");
                else
                    MessageBox.Show("登录失败");
            }
        }
    }
}
