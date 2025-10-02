namespace WinFormConnectToSqlServer_Project
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordText = new System.Windows.Forms.TextBox();
            this.accountText = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.Label();
            this.comfirmPasswordText = new System.Windows.Forms.TextBox();
            this.comfirmPassword = new System.Windows.Forms.Label();
            this.nickNameText = new System.Windows.Forms.TextBox();
            this.nickName = new System.Windows.Forms.Label();
            this.RegisterBut = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordText.Location = new System.Drawing.Point(133, 96);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(160, 21);
            this.passwordText.TabIndex = 7;
            // 
            // accountText
            // 
            this.accountText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountText.Location = new System.Drawing.Point(133, 44);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(160, 21);
            this.accountText.TabIndex = 6;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("千图小兔体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.password.Location = new System.Drawing.Point(47, 93);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(50, 24);
            this.password.TabIndex = 5;
            this.password.Text = "密码";
            // 
            // account
            // 
            this.account.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("千图小兔体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.account.Location = new System.Drawing.Point(47, 41);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(50, 24);
            this.account.TabIndex = 4;
            this.account.Text = "账号";
            // 
            // comfirmPasswordText
            // 
            this.comfirmPasswordText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comfirmPasswordText.Location = new System.Drawing.Point(133, 140);
            this.comfirmPasswordText.Name = "comfirmPasswordText";
            this.comfirmPasswordText.Size = new System.Drawing.Size(160, 21);
            this.comfirmPasswordText.TabIndex = 9;
            // 
            // comfirmPassword
            // 
            this.comfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comfirmPassword.AutoSize = true;
            this.comfirmPassword.Font = new System.Drawing.Font("千图小兔体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.comfirmPassword.Location = new System.Drawing.Point(47, 140);
            this.comfirmPassword.Name = "comfirmPassword";
            this.comfirmPassword.Size = new System.Drawing.Size(90, 24);
            this.comfirmPassword.TabIndex = 8;
            this.comfirmPassword.Text = "确认密码";
            // 
            // nickNameText
            // 
            this.nickNameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nickNameText.Location = new System.Drawing.Point(133, 194);
            this.nickNameText.Name = "nickNameText";
            this.nickNameText.Size = new System.Drawing.Size(160, 21);
            this.nickNameText.TabIndex = 11;
            // 
            // nickName
            // 
            this.nickName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nickName.AutoSize = true;
            this.nickName.Font = new System.Drawing.Font("千图小兔体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nickName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nickName.Location = new System.Drawing.Point(47, 191);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(50, 24);
            this.nickName.TabIndex = 10;
            this.nickName.Text = "昵称";
            // 
            // RegisterBut
            // 
            this.RegisterBut.Location = new System.Drawing.Point(97, 319);
            this.RegisterBut.Name = "RegisterBut";
            this.RegisterBut.Size = new System.Drawing.Size(162, 59);
            this.RegisterBut.TabIndex = 12;
            this.RegisterBut.Text = "注册";
            this.RegisterBut.UseVisualStyleBackColor = true;
            this.RegisterBut.Click += new System.EventHandler(this.RegisterBut_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.Location = new System.Drawing.Point(97, 246);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(35, 16);
            this.male.TabIndex = 13;
            this.male.TabStop = true;
            this.male.Text = "男";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(224, 246);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(35, 16);
            this.female.TabIndex = 14;
            this.female.TabStop = true;
            this.female.Text = "女";
            this.female.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 390);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.RegisterBut);
            this.Controls.Add(this.nickNameText);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.comfirmPasswordText);
            this.Controls.Add(this.comfirmPassword);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.accountText);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.TextBox comfirmPasswordText;
        private System.Windows.Forms.Label comfirmPassword;
        private System.Windows.Forms.TextBox nickNameText;
        private System.Windows.Forms.Label nickName;
        private System.Windows.Forms.Button RegisterBut;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
    }
}