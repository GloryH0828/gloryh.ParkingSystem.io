namespace GloryH
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.adminlogin = new System.Windows.Forms.Button();
            this.employeelogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入工号和密码以验证身份";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(186, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(186, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工密码：";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Italic);
            this.username.Location = new System.Drawing.Point(306, 144);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(171, 30);
            this.username.TabIndex = 3;
            this.username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Italic);
            this.password.Location = new System.Drawing.Point(306, 203);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(171, 30);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            this.password.UseWaitCursor = true;
            // 
            // adminlogin
            // 
            this.adminlogin.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.adminlogin.Location = new System.Drawing.Point(190, 307);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(128, 28);
            this.adminlogin.TabIndex = 5;
            this.adminlogin.Text = "管理员登录";
            this.adminlogin.UseVisualStyleBackColor = true;
            this.adminlogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // employeelogin
            // 
            this.employeelogin.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Bold);
            this.employeelogin.Location = new System.Drawing.Point(349, 307);
            this.employeelogin.Name = "employeelogin";
            this.employeelogin.Size = new System.Drawing.Size(128, 28);
            this.employeelogin.TabIndex = 6;
            this.employeelogin.Text = "员工登录";
            this.employeelogin.UseVisualStyleBackColor = true;
            this.employeelogin.Click += new System.EventHandler(this.Employeelogin_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeelogin);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.Button employeelogin;
    }
}