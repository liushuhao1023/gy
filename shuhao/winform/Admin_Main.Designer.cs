namespace winform_test1
{
    partial class Admin_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.物料查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备监控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.物料查询ToolStripMenuItem,
            this.设备监控ToolStripMenuItem,
            this.参数设置ToolStripMenuItem,
            this.设备操作ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.订单查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 物料查询ToolStripMenuItem
            // 
            this.物料查询ToolStripMenuItem.Name = "物料查询ToolStripMenuItem";
            this.物料查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.物料查询ToolStripMenuItem.Text = "物料查询";
            this.物料查询ToolStripMenuItem.Click += new System.EventHandler(this.物料查询ToolStripMenuItem_Click);
            // 
            // 设备监控ToolStripMenuItem
            // 
            this.设备监控ToolStripMenuItem.Name = "设备监控ToolStripMenuItem";
            this.设备监控ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设备监控ToolStripMenuItem.Text = "设备监控";
            this.设备监控ToolStripMenuItem.Click += new System.EventHandler(this.设备监控ToolStripMenuItem_Click);
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            this.参数设置ToolStripMenuItem.Click += new System.EventHandler(this.参数设置ToolStripMenuItem_Click);
            // 
            // 设备操作ToolStripMenuItem
            // 
            this.设备操作ToolStripMenuItem.Name = "设备操作ToolStripMenuItem";
            this.设备操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设备操作ToolStripMenuItem.Text = "设备操作";
            this.设备操作ToolStripMenuItem.Click += new System.EventHandler(this.设备操作ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            this.库存管理ToolStripMenuItem.Click += new System.EventHandler(this.库存管理ToolStripMenuItem_Click);
            // 
            // 订单查询ToolStripMenuItem
            // 
            this.订单查询ToolStripMenuItem.Name = "订单查询ToolStripMenuItem";
            this.订单查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.订单查询ToolStripMenuItem.Text = "订单查询";
            this.订单查询ToolStripMenuItem.Click += new System.EventHandler(this.订单查询ToolStripMenuItem_Click);
            // 
            // Admin_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "管理员界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 物料查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备监控ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单查询ToolStripMenuItem;
    }
}