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
    public partial class Employee : Form
    {
        DBHelper dBHelper = new DBHelper();
        public Employee()
        {
            InitializeComponent();
        }
        
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedItem.Equals("全部")||comboBox1.SelectedItem.Equals(null))
            {
                index.Visible = false;
            }
            else
            {
                index.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchEmployee();
        }
        public void SearchEmployee()
        {
            string sql = "select * from employee ";

            if ("姓名".Equals(comboBox1.SelectedItem))
            {
                string index1 = index.Text;
                sql = sql + "where name like '%" + index1 + "%'";
                DataTable dt = new DataTable();
                dt = dBHelper.SEA(sql);
                dataGridView2.DataSource = dt;
            }
            else if ("用户名".Equals(comboBox1.SelectedItem))
            {
                string index1 = index.Text;
                sql = sql + "where username like '%" + index1 + "%'";
                DataTable dt = new DataTable();
                dt = dBHelper.SEA(sql);
                dataGridView2.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = dBHelper.SEA(sql);
                dataGridView2.DataSource = dt;
            }
        }
        public void reLoad_method()
        {
            //窗体数据初始化方法，fuForm_Load中的全部操作，调用此方法可实现数据的刷新
            SearchEmployee();
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int id = int.Parse(row.Cells["id"].Value.ToString());

                DialogResult result = MessageBox.Show("确定要重置用户名为" + row.Cells["username"].Value.ToString() + "的员工的登陆密码吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string sql = "update employee set password ='000' where id =" + id;
                    int r = dBHelper.UPD(sql);
                    MessageBox.Show("已将用户名为" + row.Cells["username"].Value.ToString() + "的员工密码重置为000");
                }

            }
            SearchEmployee();
        }

        private void Add_Click(object sender, EventArgs e)
        {

            AddEmployee ed = new AddEmployee();
            ed.Owner = this;
            ed.ShowDialog();

        }

        private void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int id = int.Parse(row.Cells["id"].Value.ToString());

                DialogResult result = MessageBox.Show("确定要删除用户名为" + row.Cells["username"].Value.ToString() + "的员工吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string sql = "delete from employee where id =" + id;
                     dBHelper.DEL(sql);
                    MessageBox.Show("已将用户名为" + row.Cells["username"].Value.ToString() + "的员工删除");
                }

            }
            SearchEmployee();
        }
    }
}
