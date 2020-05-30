namespace GloryH
{
    partial class Add
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
            this.button1 = new System.Windows.Forms.Button();
            this.begin_time1 = new System.Windows.Forms.TextBox();
            this.state1 = new System.Windows.Forms.ComboBox();
            this.car_number1 = new System.Windows.Forms.TextBox();
            this.car_user1 = new System.Windows.Forms.TextBox();
            this.card_value1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parking_id1 = new System.Windows.Forms.TextBox();
            this.timeBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.button1.Location = new System.Drawing.Point(392, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 40;
            this.button1.Text = "确认添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // begin_time1
            // 
            this.begin_time1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.begin_time1.Location = new System.Drawing.Point(286, 325);
            this.begin_time1.Name = "begin_time1";
            this.begin_time1.Size = new System.Drawing.Size(131, 30);
            this.begin_time1.TabIndex = 39;
            this.begin_time1.Visible = false;
            this.begin_time1.TextChanged += new System.EventHandler(this.Begin_time1_TextChanged);
            // 
            // state1
            // 
            this.state1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.state1.FormattingEnabled = true;
            this.state1.Items.AddRange(new object[] {
            "使用中",
            "空闲中"});
            this.state1.Location = new System.Drawing.Point(629, 133);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(131, 27);
            this.state1.TabIndex = 38;
            this.state1.SelectedIndexChanged += new System.EventHandler(this.State1_SelectedIndexChanged);
            // 
            // car_number1
            // 
            this.car_number1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.car_number1.Location = new System.Drawing.Point(629, 266);
            this.car_number1.Name = "car_number1";
            this.car_number1.Size = new System.Drawing.Size(131, 30);
            this.car_number1.TabIndex = 37;
            this.car_number1.Visible = false;
            this.car_number1.TextChanged += new System.EventHandler(this.Car_number1_TextChanged);
            // 
            // car_user1
            // 
            this.car_user1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.car_user1.Location = new System.Drawing.Point(629, 199);
            this.car_user1.Name = "car_user1";
            this.car_user1.Size = new System.Drawing.Size(131, 30);
            this.car_user1.TabIndex = 36;
            this.car_user1.Visible = false;
            this.car_user1.TextChanged += new System.EventHandler(this.Car_user1_TextChanged);
            // 
            // card_value1
            // 
            this.card_value1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.card_value1.Location = new System.Drawing.Point(286, 202);
            this.card_value1.Name = "card_value1";
            this.card_value1.Size = new System.Drawing.Size(131, 30);
            this.card_value1.TabIndex = 35;
            this.card_value1.Visible = false;
            this.card_value1.TextChanged += new System.EventHandler(this.Card_value1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label7.Location = new System.Drawing.Point(139, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "停车证号：";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label6.Location = new System.Drawing.Point(473, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "车主姓名：";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(493, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "车牌号：";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(139, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "停入时间：";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(473, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "车位状态：";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(139, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "车位编号：";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(331, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "停车位信息添加";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // parking_id1
            // 
            this.parking_id1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.parking_id1.Location = new System.Drawing.Point(286, 133);
            this.parking_id1.Name = "parking_id1";
            this.parking_id1.Size = new System.Drawing.Size(131, 30);
            this.parking_id1.TabIndex = 42;
            this.parking_id1.TextChanged += new System.EventHandler(this.Parking_id1_TextChanged);
            // 
            // timeBox1
            // 
            this.timeBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.timeBox1.FormattingEnabled = true;
            this.timeBox1.Items.AddRange(new object[] {
            "当前时间",
            "手动输入"});
            this.timeBox1.Location = new System.Drawing.Point(286, 270);
            this.timeBox1.Name = "timeBox1";
            this.timeBox1.Size = new System.Drawing.Size(131, 27);
            this.timeBox1.TabIndex = 43;
            this.timeBox1.Visible = false;
            this.timeBox1.SelectedIndexChanged += new System.EventHandler(this.TimeBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label8.Location = new System.Drawing.Point(139, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "输入时间：";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 608);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.timeBox1);
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
            this.Name = "Add";
            this.Text = "停车位信息添加";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox begin_time1;
        private System.Windows.Forms.ComboBox state1;
        private System.Windows.Forms.TextBox car_number1;
        private System.Windows.Forms.TextBox car_user1;
        private System.Windows.Forms.TextBox card_value1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parking_id1;
        private System.Windows.Forms.ComboBox timeBox1;
        private System.Windows.Forms.Label label8;
    }
}