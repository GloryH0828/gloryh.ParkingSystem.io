namespace GloryH
{
    partial class AddEmployee
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
            this.username1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.age1 = new System.Windows.Forms.NumericUpDown();
            this.sex1 = new System.Windows.Forms.RadioButton();
            this.sex2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.age1)).BeginInit();
            this.SuspendLayout();
            // 
            // username1
            // 
            this.username1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.username1.Location = new System.Drawing.Point(534, 163);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(131, 30);
            this.username1.TabIndex = 58;
            this.username1.TextChanged += new System.EventHandler(this.Parking_id1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.button1.Location = new System.Drawing.Point(456, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 57;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // name1
            // 
            this.name1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.name1.Location = new System.Drawing.Point(534, 252);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(131, 30);
            this.name1.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label7.Location = new System.Drawing.Point(416, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "年龄：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label6.Location = new System.Drawing.Point(416, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(416, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "性别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(396, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(411, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "员工信息添加";
            // 
            // age1
            // 
            this.age1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.age1.Location = new System.Drawing.Point(534, 338);
            this.age1.Name = "age1";
            this.age1.Size = new System.Drawing.Size(131, 30);
            this.age1.TabIndex = 59;
            this.age1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex1.Location = new System.Drawing.Point(534, 435);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(47, 24);
            this.sex1.TabIndex = 60;
            this.sex1.TabStop = true;
            this.sex1.Text = "男";
            this.sex1.UseVisualStyleBackColor = true;
            // 
            // sex2
            // 
            this.sex2.AutoSize = true;
            this.sex2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex2.Location = new System.Drawing.Point(604, 435);
            this.sex2.Name = "sex2";
            this.sex2.Size = new System.Drawing.Size(47, 24);
            this.sex2.TabIndex = 61;
            this.sex2.TabStop = true;
            this.sex2.Text = "女";
            this.sex2.UseVisualStyleBackColor = true;
            this.sex2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 641);
            this.Controls.Add(this.sex2);
            this.Controls.Add(this.sex1);
            this.Controls.Add(this.age1);
            this.Controls.Add(this.username1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "AddEmployeecs";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.age1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown age1;
        private System.Windows.Forms.RadioButton sex1;
        private System.Windows.Forms.RadioButton sex2;
    }
}