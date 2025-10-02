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
            {
                MessageBox.Show("请输入账号");
                return;
            }
                
            if (String.IsNullOrEmpty(passwordText.Text))
            {
                MessageBox.Show("请输入密码");
                return;
            }

            #endregion

            //提前声明好一个数据库的存储
            Task.Run(() =>
            {
                using (MyDbContext database = new MyDbContext())
                {
                    //查询数据 
                    ModelForEF result = database.modelForEfInfo.FirstOrDefault(u => u.username == accountText.Text && u.password == passwordText.Text);
                    if(result == null)
                    {
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("用户名或密码错误" );
                        }));
                    }
                    else
                    {
                        //查询到数据
                        Invoke(new Action(() =>
                        {
                            MessageBox.Show("欢迎你，" + result.nickname);
                        }));
                    }
                }
            });
            
                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}
