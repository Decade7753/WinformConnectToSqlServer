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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void RegisterBut_Click(object sender, EventArgs e)
        {
            string username = accountText.Text;
            string password = passwordText.Text;
            string nickname = nickNameText.Text;    
            string confirmPassword = comfirmPasswordText.Text;
            bool gender = male.Checked ? true : false;

            if(password == confirmPassword)
            {
                using (MyDbContext dataBase = new MyDbContext())
                {
                    // Check if the username already exists
                    ModelForEF existingUser = dataBase.modelForEfInfo.Where(x=>x.username == username).FirstOrDefault();
                    if (existingUser != null)
                    {
                        MessageBox.Show("用户名已存在，请选择其他用户名");
                        return;
                    }
                    // Create a new user
                    ModelForEF newUser = new ModelForEF();
                    newUser.username = username;
                    newUser.password = password;
                    newUser.nickname = nickname;
                    newUser.age = 0; // Default age
                    newUser.gender = gender? "男" : "女";

                    // Add the new user to the database
                    dataBase.modelForEfInfo.Add(newUser);
                    dataBase.Entry(newUser).State = System.Data.Entity.EntityState.Added;
                    dataBase.SaveChanges();

                    MessageBox.Show("注册成功!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入");
            }
        }
    }
}
