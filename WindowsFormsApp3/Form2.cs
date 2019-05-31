using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.BLL;
using WindowsFormsApp3.Helper;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //zidingyi z = new zidingyi();
            ////数据总数
            //int a = 10;
            ////
            //int forjshuliang = 1 / 2;
            //int ccc = 1 > 2 ? 2 : 1;
            //int count = 1 % 2;
            //int b = 0;
            //z.height = this.myPanel1.Height / 2;
            //z.width = this.myPanel1.Width / 2;
            //int c=5/4;
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Rectangle r = new Rectangle(z.width * j + 10, z.height * i+10+ (i * 10), z.width-10, z.height);
            //        g.DrawRectangle(new Pen(Color.GreenYellow), r);
            //        g.FillRectangle(Brushes.GreenYellow, r);
            //        StringFormat sf = new StringFormat();
            //        sf.LineAlignment = StringAlignment.Center;
            //        sf.Alignment = StringAlignment.Center; //居中
            //        g.DrawString("下一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
            //        sf.LineAlignment = StringAlignment.Far;
            //        sf.Alignment = StringAlignment.Center; 
            //        g.DrawString("上一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
            //        sf.LineAlignment = StringAlignment.Near;
            //        sf.Alignment = StringAlignment.Center; 
            //        g.DrawString("第一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
            //    }
            //}

        }
        StudentBll sb = new StudentBll();

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
