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

   

    public partial class index : Form
    {

        int d = 1;
        string username;
        public index()
        {
            InitializeComponent();
        }
        public index(int d,string username)
        {
            InitializeComponent();
            this.d = d;
            this.username = username;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (d == 0)
            {
                员工管理ToolStripMenuItem.Visible = true;
                收费标准ToolStripMenuItem.Visible = true;

            }
            else
            {
                员工管理ToolStripMenuItem.Visible = false;
                收费标准ToolStripMenuItem.Visible = false;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void 新书入库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        
        protected override void OnResize(EventArgs e)

        {

            base.OnResize(e);

            int x = (int)(0.5 * (this.Width - panel1.Width));

            int y = (int)(0.5 * (this.Height - panel1.Height));

            panel1.Location = new System.Drawing.Point(x, y);
            int x1 = (int)(0.5 * (this.Width - label1.Width));

            int y1 = (int)(0.5 * (this.Height - label1.Height));

            label1.Location = new System.Drawing.Point(x1, y1);

        }
       

        private void 旧书销毁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 借记卡管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 图书租赁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 车辆停入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            CarIn carin = new CarIn();
            carin.MdiParent = this;
            carin.Parent = this.panel1;
            label1.Visible = false;
            carin.FormBorderStyle = FormBorderStyle.None;
            carin.Show();
        }

       

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 车辆驶出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            Carout carin = new Carout();
            carin.MdiParent = this;
            carin.Parent = this.panel1;
            label1.Visible = false;

            carin.FormBorderStyle = FormBorderStyle.None;
            carin.Show();
        }

        private void 停车证管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 车位信息检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            SearchParking searchParking = new SearchParking();
            searchParking.MdiParent = this;
            searchParking.Parent = this.panel1;
            label1.Visible = false;

            searchParking.FormBorderStyle = FormBorderStyle.None;
            searchParking.Show();
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login inde = new login();
            this.Hide();
            inde.Show();
        }

        private void 停车证办理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            CardAdd cardAdd = new CardAdd();
            cardAdd.MdiParent = this;
            cardAdd.Parent = this.panel1;
            label1.Visible = false;

            cardAdd.FormBorderStyle = FormBorderStyle.None;
            cardAdd.Show();
           
        }

        private void 停车证挂失ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 停车证检索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            SearchCard cardAdd = new SearchCard();
            cardAdd.MdiParent = this;
            cardAdd.Parent = this.panel1;
            label1.Visible = false;

            cardAdd.FormBorderStyle = FormBorderStyle.None;
            cardAdd.Show();
        }
        public void reLoad_method()
        {
            //窗体数据初始化方法，fuForm_Load中的全部操作，调用此方法可实现数据的刷新
            login lo = new login();
            this.Hide();
            lo.Show();
        }

        private void 员工管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            Employee cost = new Employee();
            cost.MdiParent = this;
            cost.Parent = this.panel1;
            label1.Visible = false;

            cost.FormBorderStyle = FormBorderStyle.None;
            cost.Show();
        }

        private void 收费标准ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            Cost cost = new Cost();
            cost.MdiParent = this;
            cost.Parent = this.panel1;
            label1.Visible = false;

            cost.FormBorderStyle = FormBorderStyle.None;
            cost.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.IsMdiContainer = true;
            Password cost = new Password(d,username,this);
            cost.MdiParent = this;
            cost.Parent = this.panel1;
            label1.Visible = false;
           
            
            
            cost.FormBorderStyle = FormBorderStyle.None;
            cost.Show();
        }
    }
}
