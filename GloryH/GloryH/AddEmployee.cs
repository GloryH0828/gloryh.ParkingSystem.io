using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GloryH
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void Parking_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string username = username1.Text;
            string name = name1.Text;
            int age = int.Parse(age1.Value.ToString());
            string sex = "男";
            if (sex1.Checked)
            {
                sex = "男";
            }
            if (sex2.Checked)
            {
                sex = "女";
            }
            if (username.Length == 0)
            {
                MessageBox.Show("请输入用户名！");
            }
            else
            {
                if (name.Length == 0)
                {
                    MessageBox.Show("请输入员工姓名！");
                }
                else
                {
                    if (!sex1.Checked && !sex2.Checked)
                    {
                        MessageBox.Show("请选择员工性别！");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("您要添加的员工信息如下：\n用户名："+username+"\n姓名："+name+"\n年龄："+age+"\n性别："+sex+"\n确定要添加吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            string sql = "insert into employee(username,name,age,sex) values('" + username + "','" + name + "',"+age+",'" + sex + "')";
                            DBHelper dBHelper = new DBHelper();
                            dBHelper.ADD(sql);
                            MessageBox.Show("已将该员工信息添加至数据库，默认密码为000");
                            Employee searchParking = (Employee)this.Owner;
                            searchParking.reLoad_method();
                        }
                    }
                }
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
       
    }
}
