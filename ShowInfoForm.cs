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
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm(ModelForEF loginInfo)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            loginAccount.Text = loginInfo.username + "欢迎进入本系统!";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ShowInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ShowInfoForm_Load(object sender, EventArgs e)
        {
            using (MyDbContext database = new MyDbContext())
            {
                List<ModelForEF> allUsers = database.modelForEfInfo.ToList();
                dataGridView1.DataSource = allUsers;
            }
        }
    }
}
