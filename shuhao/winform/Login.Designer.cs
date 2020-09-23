namespace winform_test1
{
    partial class Login
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
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.tb_userid = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_reg = new System.Windows.Forms.Button();
            this.rbtn_client = new System.Windows.Forms.RadioButton();
            this.rbtn_admin = new System.Windows.Forms.RadioButton();
            this.rbtn_op = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(93, 67);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(41, 12);
            this.lbl_userid.TabIndex = 0;
            this.lbl_userid.Text = "账号：";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(93, 118);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(41, 12);
            this.lbl_pwd.TabIndex = 1;
            this.lbl_pwd.Text = "密码：";
            // 
            // tb_userid
            // 
            this.tb_userid.Location = new System.Drawing.Point(163, 64);
            this.tb_userid.Name = "tb_userid";
            this.tb_userid.Size = new System.Drawing.Size(142, 21);
            this.tb_userid.TabIndex = 2;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(165, 115);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(140, 21);
            this.tb_pwd.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(95, 228);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(230, 228);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(75, 23);
            this.btn_reg.TabIndex = 5;
            this.btn_reg.Text = "注册";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // rbtn_client
            // 
            this.rbtn_client.AutoSize = true;
            this.rbtn_client.Location = new System.Drawing.Point(95, 174);
            this.rbtn_client.Name = "rbtn_client";
            this.rbtn_client.Size = new System.Drawing.Size(47, 16);
            this.rbtn_client.TabIndex = 6;
            this.rbtn_client.TabStop = true;
            this.rbtn_client.Text = "客户";
            this.rbtn_client.UseVisualStyleBackColor = true;
            // 
            // rbtn_admin
            // 
            this.rbtn_admin.AutoSize = true;
            this.rbtn_admin.Location = new System.Drawing.Point(165, 174);
            this.rbtn_admin.Name = "rbtn_admin";
            this.rbtn_admin.Size = new System.Drawing.Size(59, 16);
            this.rbtn_admin.TabIndex = 7;
            this.rbtn_admin.TabStop = true;
            this.rbtn_admin.Text = "管理员";
            this.rbtn_admin.UseVisualStyleBackColor = true;
            // 
            // rbtn_op
            // 
            this.rbtn_op.AutoSize = true;
            this.rbtn_op.Location = new System.Drawing.Point(246, 174);
            this.rbtn_op.Name = "rbtn_op";
            this.rbtn_op.Size = new System.Drawing.Size(59, 16);
            this.rbtn_op.TabIndex = 8;
            this.rbtn_op.TabStop = true;
            this.rbtn_op.Text = "操作员";
            this.rbtn_op.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 326);
            this.Controls.Add(this.rbtn_op);
            this.Controls.Add(this.rbtn_admin);
            this.Controls.Add(this.rbtn_client);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_userid);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_userid);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox tb_userid;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.RadioButton rbtn_client;
        private System.Windows.Forms.RadioButton rbtn_admin;
        private System.Windows.Forms.RadioButton rbtn_op;
    }
}

