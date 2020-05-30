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
    public partial class Password : Form
    {
        int d;
        string username;
        DBHelper dBHelper = new DBHelper();
        index in3 =new index();
        public Password()
        {
            InitializeComponent();
        }
        public Password(int d,string username , index inde)
        {
            InitializeComponent();
            this.d = d;
            this.username = username;
            this.in3 = inde;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string old1 = old.Text;
            string new11 = new1.Text;
            string new21 = new2.Text;
            string sql;
            if (old1.Length==0)
            {
                MessageBox.Show("请输入旧密码！");

            }
            else
            {
                if (new11.Length==0)
                {
                    MessageBox.Show("请输入新密码！");
                }
                else
                {
                    if (new21.Length==0)
                    {
                        MessageBox.Show("请再次输入新密码！");
                    }
                    else
                    {
                        if (new11.Equals(new21))
                        {
                            if (d == 0)
                            {
                                sql = "select * from admin where username ='" + username + "'";
                                DataTable dt = dBHelper.SEA(sql);
                                DataRowCollection coldrow = dt.Rows;
                                DataRow dataRow;
                                dataRow = coldrow[0];
                                if (old1.Equals(dataRow[2].ToString()))
                                {
                                    DialogResult result = MessageBox.Show("确定要将密码修改为"+new11+"吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (result == DialogResult.OK)
                                    {
                                        sql="update admin set password ='"+new11+"' where username ='"+username+"'";
                                        int r=dBHelper.UPD(sql);
                                        MessageBox.Show("密码修改成功,请重新登录!");
                                        
                                        in3.reLoad_method();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("旧密码输入有误，请重新输入");
                                }
                            }
                            if (d == 1)
                            {
                                sql = "select * from employee where username ='" + username + "'";
                                DataTable dt = dBHelper.SEA(sql);
                                DataRowCollection coldrow = dt.Rows;
                                DataRow dataRow;
                                dataRow = coldrow[0];
                                if (old1.Equals(dataRow[3].ToString()))
                                {
                                    DialogResult result = MessageBox.Show("确定要将密码修改为" + new11 + "吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (result == DialogResult.OK)
                                    {
                                        sql = "update employee set password ='" + new11 + "' where username ='" + username + "'";
                                        int r = dBHelper.UPD(sql);
                                        MessageBox.Show("密码修改成功,请重新登录!");
                                        in3.reLoad_method();
                                        this.Hide();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("旧密码输入有误，请重新输入");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("两次密码输入不一致！");
                        }
                       
                    }
                }
            }
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
