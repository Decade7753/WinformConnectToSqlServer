namespace WinFormConnectToSqlServer_Project
{
    partial class ShowInfoForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginAccount = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nickName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operation = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.nickName,
            this.Gender,
            this.operation});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(800, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // loginAccount
            // 
            this.loginAccount.AutoSize = true;
            this.loginAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginAccount.Location = new System.Drawing.Point(0, 0);
            this.loginAccount.Name = "loginAccount";
            this.loginAccount.Size = new System.Drawing.Size(41, 12);
            this.loginAccount.TabIndex = 1;
            this.loginAccount.Text = "label1";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "username";
            this.Username.HeaderText = "用户名";
            this.Username.Name = "Username";
            // 
            // nickName
            // 
            this.nickName.DataPropertyName = "nickname";
            this.nickName.HeaderText = "昵称";
            this.nickName.Name = "nickName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            // 
            // operation
            // 
            this.operation.HeaderText = "操作";
            this.operation.Name = "operation";
            this.operation.Text = "编辑";
            this.operation.UseColumnTextForButtonValue = true;
            // 
            // ShowInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginAccount);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowInfoForm";
            this.Text = "ShowInfoForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShowInfoForm_FormClosed);
            this.Load += new System.EventHandler(this.ShowInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label loginAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn nickName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewButtonColumn operation;
    }
}