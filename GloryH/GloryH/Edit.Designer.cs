namespace GloryH
{
    partial class Edit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.card_value1 = new System.Windows.Forms.TextBox();
            this.car_user1 = new System.Windows.Forms.TextBox();
            this.car_number1 = new System.Windows.Forms.TextBox();
            this.state1 = new System.Windows.Forms.ComboBox();
            this.begin_time1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.parking_id1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(366, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "信息编辑";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(153, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "车位编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(153, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "车位状态：";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(153, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "停入时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(465, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "车牌号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label6.Location = new System.Drawing.Point(465, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "车主姓名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label7.Location = new System.Drawing.Point(465, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "停车证号：";
            // 
            // card_value1
            // 
            this.card_value1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.card_value1.Location = new System.Drawing.Point(580, 136);
            this.card_value1.Name = "card_value1";
            this.card_value1.Size = new System.Drawing.Size(131, 30);
            this.card_value1.TabIndex = 21;
            // 
            // car_user1
            // 
            this.car_user1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.car_user1.Location = new System.Drawing.Point(580, 206);
            this.car_user1.Name = "car_user1";
            this.car_user1.Size = new System.Drawing.Size(131, 30);
            this.car_user1.TabIndex = 22;
            // 
            // car_number1
            // 
            this.car_number1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.car_number1.Location = new System.Drawing.Point(580, 287);
            this.car_number1.Name = "car_number1";
            this.car_number1.Size = new System.Drawing.Size(131, 30);
            this.car_number1.TabIndex = 23;
            // 
            // state1
            // 
            this.state1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.state1.FormattingEnabled = true;
            this.state1.Items.AddRange(new object[] {
            "使用中",
            "空闲中"});
            this.state1.Location = new System.Drawing.Point(268, 215);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(131, 27);
            this.state1.TabIndex = 24;
            // 
            // begin_time1
            // 
            this.begin_time1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.begin_time1.Location = new System.Drawing.Point(268, 295);
            this.begin_time1.Name = "begin_time1";
            this.begin_time1.Size = new System.Drawing.Size(131, 30);
            this.begin_time1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.button1.Location = new System.Drawing.Point(381, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // parking_id1
            // 
            this.parking_id1.AutoSize = true;
            this.parking_id1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.parking_id1.Location = new System.Drawing.Point(268, 146);
            this.parking_id1.Name = "parking_id1";
            this.parking_id1.Size = new System.Drawing.Size(0, 20);
            this.parking_id1.TabIndex = 27;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 618);
            this.Controls.Add(this.parking_id1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.begin_time1);
            this.Controls.Add(this.state1);
            this.Controls.Add(this.car_number1);
            this.Controls.Add(this.car_user1);
            this.Controls.Add(this.card_value1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "车位信息编辑";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox card_value1;
        private System.Windows.Forms.TextBox car_user1;
        private System.Windows.Forms.TextBox car_number1;
        private System.Windows.Forms.ComboBox state1;
        private System.Windows.Forms.TextBox begin_time1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label parking_id1;
    }
}