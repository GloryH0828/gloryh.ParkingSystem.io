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
    public partial class CarIn : Form
    {
        DBHelper dBHelper = new DBHelper();
             
        public CarIn()
        {
            InitializeComponent();
        }


        private void CarIn_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        string cardvalue, carnumber, caruser;
        private void Button1_Click(object sender, EventArgs e)
        {
            Search();
            SearchParking();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE parking SET card_value = '"+cardvalue+"', car_number='"+carnumber+"',car_user='"+caruser+"',state=1,begin_time='"+DateTime.Now+"' WHERE parking_id = '"+comboBox1.Text+"'";
            int result = dBHelper.UPD(sql);
            MessageBox.Show("该车辆已成功停入"+comboBox1.Text+"号车位");
            SearchParking();
        }

        private void Type1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void SearchParking()
        {
            comboBox1.Items.Clear();
            string sql = "select parking_id from parking where state=0 ";
            DataTable dt1 = dBHelper.SEA(sql);

            DataRowCollection dr = dt1.Rows;
            DataRow dataRow3;
            for (int i = 0; i < dr.Count; i++)
            {

                dataRow3 = dr[i];
                comboBox1.Items.Add(dataRow3[0].ToString());
            }
        }
        public void Search()
        {
            string type = type1.Text;
            string verify2 = verify1.Text;
            DataTable dt = new DataTable("车辆相关信息");
            DataTable dt1 = new DataTable();
            string sql = "";
            if ("".Equals(verify2) || verify2 == null)
            {
                MessageBox.Show("请输入" + type);
            }
            else
            {
                if ("车牌号".Equals(type))
                {
                    sql = "select * from parkcardinfo where carnumber ='" + verify2 + "'";
                    dt = dBHelper.SEA(sql);
                    DataRowCollection dr1 = dt.Rows;
                    DataRow dataRow1;
                    if (dt.Rows.Count > 0)
                    {
                        dataRow1 = dr1[0];
                        cardvalue = dataRow1[1].ToString();
                        caruser = dataRow1[2].ToString();
                        carnumber = dataRow1[4].ToString();
                    }
                    dataGridView1.DataSource = dt;
                    label4.Visible = true;
                    dataGridView1.Visible = true;
                    sql = "select * from parking where card_value= '"+cardvalue+"'";
                    dt1 = dBHelper.SEA(sql);
                    if (dt1.Rows.Count !=0) {
                        MessageBox.Show("该车辆已停入停车场");
                    }
                    else
                    {
                        MessageBox.Show("检索到" + dt.Rows.Count + "条信息");
                    }
                    
                    // dt.Rows[5]
                    if (dt.Rows.Count > 0)
                    {
                        label4.Visible = true;
                        dataGridView1.Visible = true;
                        label3.Visible = true;
                        comboBox1.Visible = true;
                        button2.Visible = true;

                        SearchParking();
                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "未检索到相关信息";
                    }
                }
                else
                {
                    sql = "select * from parkcardinfo where card_value ='" + verify2 + "'";
                    dt = dBHelper.SEA(sql);
                    DataRowCollection dr1 = dt.Rows;
                    DataRow dataRow1;
                    if (dt.Rows.Count > 0)
                    {
                        dataRow1 = dr1[0];
                        cardvalue = dataRow1[1].ToString();
                        caruser = dataRow1[2].ToString();
                        carnumber = dataRow1[4].ToString();
                    }

                    // MessageBox.Show(cardvalue + ".." + carnumber + ".." + caruser);
                    dataGridView1.DataSource = dt;

                    sql = "select * from parking where card_value= '" + cardvalue + "'";
                    dt1 = dBHelper.SEA(sql);
                    if (dt1.Rows.Count != 0)
                    {
                        MessageBox.Show("该车辆已停入停车场");
                    }
                    else
                    {
                        MessageBox.Show("检索到" + dt.Rows.Count + "条信息");
                    }
                    // dt.Rows[5]
                    if (dt.Rows.Count > 0)
                    {
                        label4.Visible = true;
                        dataGridView1.Visible = true;
                        label3.Visible = true;
                        comboBox1.Visible = true;
                        button2.Visible = true;
                        SearchParking();

                    }
                    else
                    {
                        label4.Visible = true;
                        label4.Text = "未检索到相关信息";
                    }
                }

            }
        }
    }
}
