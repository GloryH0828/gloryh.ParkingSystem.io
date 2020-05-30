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
    public partial class Edit : Form
    {
        int id;
        SearchParking searchParking;
        DBHelper dBHelper = new DBHelper();
        public Edit()
        {
            InitializeComponent();
        }
        public Edit( int id,SearchParking searchParking)
        {
            InitializeComponent();
            this.id = id;
            this.searchParking = searchParking; 
        }
        public void SearchById( int id)
        {
            DataTable dt = new DataTable();
            string sql = "select * from parking where id=" +id;
            dt = dBHelper.SEA(sql);
           
            DataRow dataRow1 = dt.Rows[0];
           // MessageBox.Show(dataRow1[1].ToString);
            //parking_id1.Text = "";
               parking_id1.Text = dataRow1["parking_id"].ToString();
                card_value1.Text= dataRow1["card_value"].ToString();
               car_number1.Text= dataRow1["car_number"].ToString();
               car_user1.Text= dataRow1["car_user"].ToString();
               begin_time1.Text = dataRow1["begin_time"].ToString();
            if (Convert.ToInt32(dataRow1["state"].ToString()) == 1)
            {
                state1.SelectedItem="使用中";
            }
            if (Convert.ToInt32(dataRow1["state"].ToString()) == 0)
            {
                state1.SelectedItem = "空闲中";
            }

        }
        private void Edit_Load(object sender, EventArgs e)
        {
            SearchById(id);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditOK();
            
            SearchParking searchParking = (SearchParking)this.Owner;
            searchParking.reLoad_method();
            this.Hide();
        }
        public void EditOK()
        {
            int parking_id = Convert.ToInt32(parking_id1.Text);
            string card_value = card_value1.Text;
            string car_number = car_number1.Text;
            string car_user = car_user1.Text;
            string begin_time = begin_time1.Text;
            int state = 0;
            if (state1.Text.Equals("使用中"))
            {
                state = 1;
            }
            string sql = "UPDATE parking SET card_value = '" + card_value + "', car_number='" + car_number + "',car_user='" + car_user + "',state="+state+",begin_time='" + Convert.ToDateTime(begin_time) + "' WHERE parking_id = " + Convert.ToInt32(parking_id) ;
            int result = dBHelper.UPD(sql);
            MessageBox.Show("修改成功!");
        }
    }
}
