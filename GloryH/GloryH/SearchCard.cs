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
    public partial class SearchCard : Form
    {
        public SearchCard()
        {
            InitializeComponent();
        }
        DBHelper dBHelper = new DBHelper();
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SearchC();
        }
        public void SearchC()
        {
            string sql = "select * from parkcardinfo ";
            if (comboBox1.Text.Equals("车主姓名"))
            {
                
                string index1 = index.Text;
                sql = sql + "where name like '%" + index1 + "%' ";
                if (radioButton2.Checked)
                {
                    sql = sql + "and state = 1 ";
                    if (radioButton5.Checked)
                    {
                        sql = sql + "and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + "and sex = '女'";
                    }
                }
                if (radioButton1.Checked)
                {
                    sql = sql + "and state = 0 ";
                    if (radioButton5.Checked)
                    {
                        sql = sql + "and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + "and sex = '女'";
                    }
                }
            
                

            }
            else if (comboBox1.Text.Equals("停车证号"))
            {
               
                string index1 = index.Text;
                sql = sql + "where card_value like'%" + index1 + "%'";
                if (radioButton2.Checked)
                {
                    sql = sql + "and state = 1 ";
                    if (radioButton5.Checked)
                    {
                        sql = sql + "and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + "and sex = '女'";
                    }
                }
                if (radioButton1.Checked)
                {
                    sql = sql + "and state = 0 ";
                    if (radioButton5.Checked)
                    {
                        sql = sql + "and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + "and sex = '女'";
                    }
                }
               
            }
            else
            {
                
                if (radioButton2.Checked)
                {
                    sql = sql + "where state = 1";
                    if (radioButton5.Checked)
                    {
                        sql = sql + " and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + " and sex = '女'";
                    }
                }
                if (radioButton1.Checked)
                {
                    sql = sql + "where state = 0 ";
                    if (radioButton5.Checked)
                    {
                        sql = sql + " and sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + " and sex = '女'";
                    }
                }
                if (radioButton3.Checked)
                {
                    if (radioButton5.Checked)
                    {
                        sql = sql + " where sex = '男'";
                    }
                    if (radioButton6.Checked)
                    {
                        sql = sql + " where sex = '女'";
                    }
                }

            }
            
            DataTable dt = new DataTable();
            dt = dBHelper.SEA(sql);
            dataGridView2.DataSource = dt;
        }
        public void reLoad_method()
        {
            //窗体数据初始化方法，fuForm_Load中的全部操作，调用此方法可实现数据的刷新
            SearchC();
        }
        private void Index_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("车主姓名") || comboBox1.SelectedItem.Equals("停车证号"))
            {
                index.Visible = true;
            }
            else
            {
                index.Visible = false;
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(id.ToString());
                EditInfo ei = new EditInfo(id, this);
                ei.Owner = this;
                ei.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中且只选中一行数据进行此操作！");
            }
        }

        private void SearchCard_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SearchC();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            CardAdd ei = new CardAdd(1,this);
            ei.Owner = this;
            ei.ShowDialog();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                int id = int.Parse(row.Cells["id"].Value.ToString());
               
                    DialogResult result = MessageBox.Show("确定要注销该停车证吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DelCard(id);
                    
                }
                
            }
            MessageBox.Show("执行成功！");
            SearchC();
        }
        public void DelCard(int id)
        {
            string sql = "delete from parkcardinfo where id= " + id;
            dBHelper.DEL(sql);
        }

       
        
    }
}
