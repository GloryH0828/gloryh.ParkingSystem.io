namespace GloryH
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.图书管理系统 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.新书入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆停入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆驶出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车位信息检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停车证管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停车证检索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停车证办理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.员工管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收费标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // 图书管理系统
            // 
            resources.ApplyResources(this.图书管理系统, "图书管理系统");
            this.图书管理系统.Name = "图书管理系统";
            this.图书管理系统.Click += new System.EventHandler(this.Label1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新书入库ToolStripMenuItem,
            this.车位信息检索ToolStripMenuItem,
            this.停车证管理ToolStripMenuItem,
            this.员工管理ToolStripMenuItem,
            this.收费标准ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip2_ItemClicked);
            // 
            // 新书入库ToolStripMenuItem
            // 
            this.新书入库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆停入ToolStripMenuItem,
            this.车辆驶出ToolStripMenuItem});
            this.新书入库ToolStripMenuItem.Name = "新书入库ToolStripMenuItem";
            resources.ApplyResources(this.新书入库ToolStripMenuItem, "新书入库ToolStripMenuItem");
            this.新书入库ToolStripMenuItem.Click += new System.EventHandler(this.新书入库ToolStripMenuItem_Click);
            // 
            // 车辆停入ToolStripMenuItem
            // 
            this.车辆停入ToolStripMenuItem.Name = "车辆停入ToolStripMenuItem";
            resources.ApplyResources(this.车辆停入ToolStripMenuItem, "车辆停入ToolStripMenuItem");
            this.车辆停入ToolStripMenuItem.Click += new System.EventHandler(this.车辆停入ToolStripMenuItem_Click);
            // 
            // 车辆驶出ToolStripMenuItem
            // 
            this.车辆驶出ToolStripMenuItem.Name = "车辆驶出ToolStripMenuItem";
            resources.ApplyResources(this.车辆驶出ToolStripMenuItem, "车辆驶出ToolStripMenuItem");
            this.车辆驶出ToolStripMenuItem.Click += new System.EventHandler(this.车辆驶出ToolStripMenuItem_Click);
            // 
            // 车位信息检索ToolStripMenuItem
            // 
            this.车位信息检索ToolStripMenuItem.Name = "车位信息检索ToolStripMenuItem";
            resources.ApplyResources(this.车位信息检索ToolStripMenuItem, "车位信息检索ToolStripMenuItem");
            this.车位信息检索ToolStripMenuItem.Click += new System.EventHandler(this.车位信息检索ToolStripMenuItem_Click);
            // 
            // 停车证管理ToolStripMenuItem
            // 
            this.停车证管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.停车证检索ToolStripMenuItem,
            this.停车证办理ToolStripMenuItem});
            this.停车证管理ToolStripMenuItem.Name = "停车证管理ToolStripMenuItem";
            resources.ApplyResources(this.停车证管理ToolStripMenuItem, "停车证管理ToolStripMenuItem");
            this.停车证管理ToolStripMenuItem.Click += new System.EventHandler(this.停车证管理ToolStripMenuItem_Click);
            // 
            // 停车证检索ToolStripMenuItem
            // 
            this.停车证检索ToolStripMenuItem.Name = "停车证检索ToolStripMenuItem";
            resources.ApplyResources(this.停车证检索ToolStripMenuItem, "停车证检索ToolStripMenuItem");
            this.停车证检索ToolStripMenuItem.Click += new System.EventHandler(this.停车证检索ToolStripMenuItem_Click);
            // 
            // 停车证办理ToolStripMenuItem
            // 
            this.停车证办理ToolStripMenuItem.Name = "停车证办理ToolStripMenuItem";
            resources.ApplyResources(this.停车证办理ToolStripMenuItem, "停车证办理ToolStripMenuItem");
            this.停车证办理ToolStripMenuItem.Click += new System.EventHandler(this.停车证办理ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            resources.ApplyResources(this.退出ToolStripMenuItem, "退出ToolStripMenuItem");
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // 员工管理ToolStripMenuItem
            // 
            this.员工管理ToolStripMenuItem.Name = "员工管理ToolStripMenuItem";
            resources.ApplyResources(this.员工管理ToolStripMenuItem, "员工管理ToolStripMenuItem");
            this.员工管理ToolStripMenuItem.Click += new System.EventHandler(this.员工管理ToolStripMenuItem_Click);
            // 
            // 收费标准ToolStripMenuItem
            // 
            this.收费标准ToolStripMenuItem.Name = "收费标准ToolStripMenuItem";
            resources.ApplyResources(this.收费标准ToolStripMenuItem, "收费标准ToolStripMenuItem");
            this.收费标准ToolStripMenuItem.Click += new System.EventHandler(this.收费标准ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            resources.ApplyResources(this.修改密码ToolStripMenuItem, "修改密码ToolStripMenuItem");
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // index
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.图书管理系统);
            this.Controls.Add(this.menuStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "index";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 图书管理系统;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 新书入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆停入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆驶出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停车证管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停车证办理ToolStripMenuItem;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 车位信息检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停车证检索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收费标准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
    }
}

