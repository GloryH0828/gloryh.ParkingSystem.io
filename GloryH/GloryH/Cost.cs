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
    public partial class Cost : Form
    {
        DBHelper dBHelper = new DBHelper();
        public Cost()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Cost_Load(object sender, EventArgs e)
        {
            string sql = "select * from parkmoney where id=1";
            DataTable dt = new DataTable();
            dt = dBHelper.SEA(sql);
            DataRowCollection coldrow = dt.Rows;
            DataRow dataRow;
            dataRow = coldrow[0];
            hour1.Text = dataRow[1].ToString();
            day1.Text = dataRow[2].ToString();
            month1.Text = dataRow[4].ToString();
            year1.Text = dataRow[3].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(hour1.Text);
            int month = int.Parse(month1.Text);
            int day = int.Parse(day1.Text);
            int year = int.Parse(year1.Text);
            string sql = "UPDATE parkmoney SET hour = "+ hour + ", day=" + day + ",month=" + month + ",year=" + year + " WHERE id = 1";
            int result = dBHelper.UPD(sql);
            MessageBox.Show("修改成功！");
        }
    }
}
