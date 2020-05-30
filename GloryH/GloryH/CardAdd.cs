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
    public partial class CardAdd : Form
    {
        int search = 0;
        SearchCard searchCard = new SearchCard();
        DBHelper dBHelper = new DBHelper();
        public CardAdd()
        {
            InitializeComponent();
        }
        public CardAdd(int d,SearchCard searchCard)
        {
            search = d;
            InitializeComponent();
            this.searchCard = searchCard;
        }
        private void CardAdd_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (card_value1.TextLength == 0)
            {
                MessageBox.Show("请输入停车证号！");
                return;
            }
            else if (car_number1.TextLength == 0)
            {
                MessageBox.Show("请输入车牌号！");
                return;
            }
            else if (car_user1.TextLength == 0)
            {
                MessageBox.Show("请输入车主姓名！");
                return;
            }
            else if (idcard1.TextLength == 0)
            {
                MessageBox.Show("请输入身份证号！");
                return;
            }
            else if (!sex1.Checked && !sex2.Checked)
            {
                MessageBox.Show("请选择性别！");
                return;
            }
            else
            {
                AddCard();
            }
            if (search==1)
            {
                SearchCard searchCard = (SearchCard)this.Owner;
                searchCard.reLoad_method();
                this.Hide();
            }
        }
        public void AddCard()
        {
            string card_value = card_value1.Text;
            string car_user = car_user1.Text;
            string car_number = car_number1.Text;
            string idcard = idcard1.Text;
            string sex="男";
            if (sex1.Checked)
            {
                sex = "男";
            }
            if (sex2.Checked)
            {
                sex = "女";
            }
            DialogResult r = MessageBox.Show("您要办理的停车证信息如下：\n卡号："+card_value+"\n姓名："+car_user+"\n性别："+sex+"\n车牌号："+car_number+"\n身份证号："+idcard, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                string sql = "insert into parkcardinfo(card_value,name,carnumber,idcard,sex) values('" + card_value + "','" + car_user + "','" + car_number + "','" + idcard + "','" + sex + "')";
                dBHelper.ADD(sql);
                card_value1.Text = "";
                car_number1.Text = "";

                car_user1.Text = "";
                idcard1.Text = "";
                MessageBox.Show("办理成功，请提醒持有人妥善保管！");
            }
            

        }
    }
}
