namespace WinFormConnectToSqlServer_Project
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.account = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(11, 99);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(29, 12);
            this.account.TabIndex = 0;
            this.account.Text = "账号";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(11, 148);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(29, 12);
            this.password.TabIndex = 1;
            this.password.Text = "密码";
            // 
            // accountText
            // 
            this.accountText.Location = new System.Drawing.Point(46, 96);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(100, 21);
            this.accountText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(46, 145);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(100, 21);
            this.passwordText.TabIndex = 3;
            // 
            // searchBut
            // 
            this.searchBut.Location = new System.Drawing.Point(152, 99);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(131, 68);
            this.searchBut.TabIndex = 4;
            this.searchBut.Text = "登录";
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 292);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.accountText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button searchBut;
    }
}

