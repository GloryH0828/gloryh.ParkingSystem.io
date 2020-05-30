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
   
    public partial class Add : Form
    {
        
        DBHelper dBHelper = new DBHelper();
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            
        }

        private void State1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state1.Text.Equals("使用中"))
            {
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                state = 1;
                card_value1.Visible = true;
                car_number1.Visible = true;
                car_user1.Visible = true;
                timeBox1.Visible = true;
               
            }
            if (state1.Text.Equals("空闲中"))
            {
                state = 0;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                card_value1.Visible = false;
                car_number1.Visible = false;
                car_user1.Visible = false;
                timeBox1.Visible = false;
                begin_time1.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddParking();
            SearchParking searchParking = (SearchParking)this.Owner;
            searchParking.reLoad_method();
            this.Hide();
        }
        int state = 0;
        public void AddParking()
        {
            string parking_id = parking_id1.Text;
            string card_value = card_value1.Text;
            string car_user = card_value1.Text;
            string car_number = car_number1.Text;
            
            string sql = "insert into parking(parking_id,card_value,car_user,car_number,state,begin_time) values("+Convert.ToInt32(parking_id)+",'"+card_value+"','"+car_user+"','"+car_number+"',"+state+",'"+Convert.ToDateTime(begin_time)+"')";
            dBHelper.ADD(sql);
            MessageBox.Show("添加成功！");
        }
        string begin_time;
        private void TimeBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeBox1.Text.Equals("当前时间"))
            {
                begin_time1.Visible = false;
                label8.Visible = false;
                begin_time = DateTime.Now.ToString();
            }
            if (timeBox1.Text.Equals("手动输入"))
            {
                begin_time1.Visible = true;
                label8.Visible = true;
                begin_time = begin_time1.Text;
            }
        }

        private void Begin_time1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Car_number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Car_user1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Card_value1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Parking_id1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
