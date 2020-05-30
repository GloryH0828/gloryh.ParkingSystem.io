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
    public partial class Carout : Form
    {
       
        public Carout()
        {
            InitializeComponent();
        }


        private void Verify1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cost();
            Out();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Search();
        }
       
        DBHelper dBHelper = new DBHelper();
        public void Out()
        {
            int parkid = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value.ToString());
            string sql = "UPDATE parking SET card_value = '', car_number='',car_user='',state=0 WHERE parking_id ="+parkid;
            int result = dBHelper.UPD(sql);
            MessageBox.Show("该车辆已成功驶出" +parkid + "号车位");
        }
        public void Cost()
        {
            DataTable dt = new DataTable();
            int cost = 0;
            DateTime time= new DateTime();
            time = Convert.ToDateTime(dataGridView1.Rows[0].Cells[6].Value.ToString());
            DateTime now = new DateTime();
            now = DateTime.Now;
            string sql = "select * from parkmoney where id = 1";
            dt = dBHelper.SEA(sql);
            DataRowCollection dr1 = dt.Rows;
            DataRow dataRow1;
            dataRow1 = dr1[0];
            cost = (now.Year - time.Year) * Convert.ToInt32(dataRow1[3].ToString()) + (now.Month - time.Month) * Convert.ToInt32(dataRow1[4].ToString()) +
                (now.Day - time.Day) * Convert.ToInt32(dataRow1[2].ToString()) + (now.Hour - time.Hour) * Convert.ToInt32(dataRow1[1].ToString());
            MessageBox.Show("停入时间："+time+"\n停车费用为"+cost+"元");


        }
        public void Search()
        {
            DataTable dt = new DataTable("相关信息");
            string type = type1.Text;
            string verify2 = verify1.Text;
            string sql = "";
            if ("".Equals(verify2) || verify2 == null)
            {
                MessageBox.Show("请输入" + type);
            }
            else
            {
                if ("车牌号".Equals(type))
                {
                    sql = "select * from parking where car_number ='" + verify2 + "'";
                    dt = dBHelper.SEA(sql);
                    DataRowCollection dr1 = dt.Rows;
                    DataRow dataRow1;
                    if (dt.Rows.Count > 0)
                    {
                        dataRow1 = dr1[0];
                        
                    }
                    dataGridView1.DataSource = dt;
                    label4.Visible = true;
                    dataGridView1.Visible = true;
                    MessageBox.Show("检索到" + dt.Rows.Count + "条信息");
                    // dt.Rows[5]
                    if (dt.Rows.Count > 0)
                    {
                        label4.Visible = true;
                        dataGridView1.Visible = true;
                        button2.Visible = true;

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "未检索到相关信息";
                    }
                }
                else
                {
                    sql = "select * from parking where card_value ='" + verify2 + "'";
                    dt = dBHelper.SEA(sql);
                    DataRowCollection dr1 = dt.Rows;
                    DataRow dataRow1;
                    if (dt.Rows.Count > 0)
                    {
                        dataRow1 = dr1[0];
                        
                    }

                    // MessageBox.Show(cardvalue + ".." + carnumber + ".." + caruser);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("检索到" + dt.Rows.Count + "条信息");
                    // dt.Rows[5]
                    if (dt.Rows.Count > 0)
                    {
                        label4.Visible = true;
                        dataGridView1.Visible = true;
                        button2.Visible = true;
                       

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "未检索到相关信息";
                    }
                }

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
