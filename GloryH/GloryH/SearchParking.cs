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
    public partial class SearchParking : Form
    {
        public SearchParking()
        {
            InitializeComponent();
        }
        DBHelper dBHelper = new DBHelper();

        private void SearchParking_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SearchP();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            SearchP();
        }
        public void SearchP()
        {
            DataTable dt = new DataTable();
            string sql = "select * from parking ";
            
            if("车位编号".Equals(comboBox1.SelectedItem))
            {
                
                sql = sql + " where parking_id like'%"+carnum.Text+"%'";
                if (radioButton1.Checked)
                {
                    sql = sql + "and state=1";
                }
                if (radioButton2.Checked)
                {
                    sql = sql + "and state=0";
                }
            }else if ("全部".Equals(comboBox1.SelectedItem))
            {
                if (radioButton1.Checked)
                {
                    sql = sql + "where state=1";
                }
                if (radioButton2.Checked)
                {
                    sql = sql + "where state=0";
                }
            }
            dt = dBHelper.SEA(sql);
            dataGridView1.DataSource=dt;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.Equals("车位编号"))
            {
                carnum.Visible = true;
            }
            else
            {
                carnum.Visible = false;
            }
        }
        public void reLoad_method()
        {
            //窗体数据初始化方法，fuForm_Load中的全部操作，调用此方法可实现数据的刷新
            SearchP();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SearchP();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SearchP();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
                Add ed = new Add();
                ed.Owner = this;
                ed.ShowDialog();
            
           
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                
                Edit ed = new Edit(id,this);
                ed.Owner = this;
                ed.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选中且只选中一行数据进行此操作！");
            }
            
        }

        private void Del_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = int.Parse(row.Cells["id"].Value.ToString());
                if (int.Parse(row.Cells["state"].Value.ToString()) == 1)
                {
                   DialogResult result= MessageBox.Show(id+"号停车位正在使用中，确定要删除吗？","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DelParking(id);
                        
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show( "确定要删除"+id + "号停车位吗？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        DelParking(id);
                    }
                }
            }
            MessageBox.Show("执行成功！");
            SearchP();
        }
        public void DelParking(int id)
        {
            string sql = "delete from parking where id= "+id;
            dBHelper.DEL(sql);
            
        }
    }
} 
