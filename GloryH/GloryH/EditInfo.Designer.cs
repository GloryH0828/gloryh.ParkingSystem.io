namespace GloryH
{
    partial class EditInfo
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
            this.idcard = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.ComboBox();
            this.carnumber = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sex1 = new System.Windows.Forms.RadioButton();
            this.sex2 = new System.Windows.Forms.RadioButton();
            this.card_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.button1.Location = new System.Drawing.Point(436, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 38);
            this.button1.TabIndex = 40;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // idcard
            // 
            this.idcard.Font = new System.Drawing.Font("宋体", 14.5F);
            this.idcard.Location = new System.Drawing.Point(323, 313);
            this.idcard.Name = "idcard";
            this.idcard.Size = new System.Drawing.Size(131, 30);
            this.idcard.TabIndex = 39;
            // 
            // state
            // 
            this.state.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.state.Font = new System.Drawing.Font("宋体", 14.5F);
            this.state.FormattingEnabled = true;
            this.state.Items.AddRange(new object[] {
            "正常状态",
            "挂失状态"});
            this.state.Location = new System.Drawing.Point(635, 316);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(131, 27);
            this.state.TabIndex = 38;
            this.state.SelectedIndexChanged += new System.EventHandler(this.State_SelectedIndexChanged);
            // 
            // carnumber
            // 
            this.carnumber.Font = new System.Drawing.Font("宋体", 14.5F);
            this.carnumber.Location = new System.Drawing.Point(635, 231);
            this.carnumber.Name = "carnumber";
            this.carnumber.Size = new System.Drawing.Size(131, 30);
            this.carnumber.TabIndex = 37;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 14.5F);
            this.name.Location = new System.Drawing.Point(635, 154);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(131, 30);
            this.name.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label7.Location = new System.Drawing.Point(208, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "车主性别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label6.Location = new System.Drawing.Point(520, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "车主姓名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label5.Location = new System.Drawing.Point(520, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "车牌号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label4.Location = new System.Drawing.Point(208, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "身份证号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label3.Location = new System.Drawing.Point(520, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "证件状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.label2.Location = new System.Drawing.Point(208, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "停车证号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(421, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "信息编辑";
            // 
            // sex1
            // 
            this.sex1.AutoSize = true;
            this.sex1.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex1.Location = new System.Drawing.Point(323, 231);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(47, 24);
            this.sex1.TabIndex = 42;
            this.sex1.TabStop = true;
            this.sex1.Text = "男";
            this.sex1.UseVisualStyleBackColor = true;
            this.sex1.CheckedChanged += new System.EventHandler(this.Sex1_CheckedChanged);
            // 
            // sex2
            // 
            this.sex2.AutoSize = true;
            this.sex2.Font = new System.Drawing.Font("宋体", 14.5F);
            this.sex2.Location = new System.Drawing.Point(390, 231);
            this.sex2.Name = "sex2";
            this.sex2.Size = new System.Drawing.Size(47, 24);
            this.sex2.TabIndex = 43;
            this.sex2.TabStop = true;
            this.sex2.Text = "女";
            this.sex2.UseVisualStyleBackColor = true;
            this.sex2.CheckedChanged += new System.EventHandler(this.Sex2_CheckedChanged);
            // 
            // card_value
            // 
            this.card_value.AutoSize = true;
            this.card_value.Font = new System.Drawing.Font("宋体", 14.5F);
            this.card_value.Location = new System.Drawing.Point(323, 157);
            this.card_value.Name = "card_value";
            this.card_value.Size = new System.Drawing.Size(0, 20);
            this.card_value.TabIndex = 44;
            // 
            // EditInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 620);
            this.Controls.Add(this.card_value);
            this.Controls.Add(this.sex2);
            this.Controls.Add(this.sex1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idcard);
            this.Controls.Add(this.state);
            this.Controls.Add(this.carnumber);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditInfo";
            this.Text = "EditInfo";
            this.Load += new System.EventHandler(this.EditInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idcard;
        private System.Windows.Forms.ComboBox state;
        private System.Windows.Forms.TextBox carnumber;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sex1;
        private System.Windows.Forms.RadioButton sex2;
        private System.Windows.Forms.Label card_value;
    }
}