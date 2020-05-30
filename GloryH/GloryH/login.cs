using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GloryH
{
    public partial class login : Form
    {
        string connectionString = "server=localhost;user id=root;database=dbtest;password=123";
        public login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pwd = password.Text;
            if ("".Equals(user) || user == null)
            {
                MessageBox.Show("用户名不得为空！");
            }
            else
            {
                if ("".Equals(pwd) || pwd == null)
                {
                    MessageBox.Show("密码不得为空！");
                }
                else
                {
                    DataTable dt = new DataTable();
                    string sql = "select * from admin where username=" + user;
                    DBHelper dBHelper = new DBHelper();
                    dt=dBHelper.SEA(sql);
                    DataRowCollection coldrow = dt.Rows;
                    DataRow dataRow;
                    for (int i = 0; i < coldrow.Count; i++)
                    {
                        dataRow = coldrow[i];

                        if (pwd.Equals(dataRow[2]))
                        {
                           
                                MessageBox.Show("管理员您好，恭喜你登陆成功！");
                                index inde = new index(0,user);
                                this.Hide();
                                inde.Show();
                          
                        }
                        else
                        {
                            MessageBox.Show("密码错误，请重新输入！");
                        }


                    }
                    if (coldrow.Count == 0)
                    {
                        MessageBox.Show("未查询到该管理员信息，请重新输入！");
                    }

                }
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Employeelogin_Click(object sender, EventArgs e)
        {
            

            string user = username.Text;
            string pwd = password.Text;
            if ("".Equals(user) || user == null)
            {
                MessageBox.Show("用户名不得为空！");
            }
            else
            {
                if ("".Equals(pwd) || pwd == null)
                {
                    MessageBox.Show("密码不得为空！");
                }
                else
                {
                    string sql = "select * from employee where username=" + user;
                   
                    
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        DataSet ds = new DataSet();
                        connection.Open();
                        MySqlDataAdapter adp = new MySqlDataAdapter(sql,connection);
                        adp.Fill(ds, "ds");
                        connection.Close();
                        DataTable dataTable = ds.Tables["ds"];
                        DataRowCollection coldrow = dataTable.Rows;
                        DataRow dataRow;
                        for(int i = 0; i < coldrow.Count; i++)
                        {
                            dataRow = coldrow[i];
                            
                                if (pwd.Equals(dataRow[3]))
                                {
                                    if (Convert.ToInt32(dataRow[4])==1)
                                    {
                                        MessageBox.Show("您好，"+dataRow[1]+"，恭喜你登陆成功！");
                                    index inde = new index(1,user);
                                    this.Hide();
                                    inde.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("您已被限制登录！状态："+ Convert.ToInt32(dataRow[4]));
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("密码错误，请重新输入！");
                                }
                            
                           
                        }
                        if (coldrow.Count == 0)
                        {
                            MessageBox.Show("未查询到该员工信息，请重新输入！");
                        }
                    }
                }
            }
        }
    }
}
