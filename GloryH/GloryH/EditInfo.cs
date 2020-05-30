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
    public partial class EditInfo : Form
    {
        int id;
        DBHelper dBHelper = new DBHelper();
        SearchCard searchCard;
        public EditInfo()
        {
            InitializeComponent();
        }
     
        public EditInfo(int id, SearchCard searchCard)
        {
            InitializeComponent();
            this.id = id;
            this.searchCard = searchCard;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditinfoOK();
           SearchCard searchCard = (SearchCard)this.Owner;
            searchCard.reLoad_method();
            this.Hide();
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            SearchInfoById(id);
        }
        public void SearchInfoById(int id)
        {
           // MessageBox.Show(id.ToString());
            string sql = "select * from parkcardinfo where id = "+id;
            DataTable dt = new DataTable();
            dt= dBHelper.SEA(sql);
            DataRow dataRow1 = dt.Rows[0];
            card_value.Text= dataRow1["card_value"].ToString();
            name.Text = dataRow1["name"].ToString();
            carnumber.Text = dataRow1["carnumber"].ToString();
            idcard.Text = dataRow1["idcard"].ToString();
            if (dataRow1["sex"].ToString().Equals("男"))
            {
                sex1.Checked = true;
            }
            else
            {
                sex2.Checked = true;
            }
            int state1 = int.Parse(dataRow1["state"].ToString());
            if (state1 == 0)
            {
                state.SelectedItem = "正常状态";
            }
            if (state1 == 1)
            {
                state.SelectedItem = "挂失状态";
            }
        }
        public void EditinfoOK()
        {
            string name1 = name.Text;
            string carnumber1 = carnumber.Text;
            string idcard1 = idcard.Text;
            string sql = "UPDATE parkcardinfo SET  carnumber='" + carnumber1 + "',name='" + name1 + "',state=" + state2 + ",sex='" + sex3 + "',idcard='"+idcard1+"' WHERE id = "+id;
            int result = dBHelper.UPD(sql);
            MessageBox.Show("修改成功!");
        }
        int state2 = 0;
        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (state.SelectedItem.Equals("正常状态"))
            {
                state2 = 0;
            }
            if (state.SelectedItem.Equals("挂失状态"))
            {
                state2 = 1;
            }
        }
        string sex3 = "男";
        private void Sex1_CheckedChanged(object sender, EventArgs e)
        {
            sex3 = "男";
        }

        private void Sex2_CheckedChanged(object sender, EventArgs e)
        {
            sex3 = "女";
        }
    }
}
