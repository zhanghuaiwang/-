using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.cons;
using WindowsFormsApp3.Helper;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //huatu(g);
        }
        int count = 10;
        List<Rectangle> r_lis = new List<Rectangle>();
        Rectangle r1;
        //private void huatu(Graphics g) {
        //    r_lis.Clear();
        //    int max_pw1 = panel1.Width;
        //    int max_ph1 = panel1.Height/9;
        //    for (int i = 0; i < count; i++)
        //    {

        //        Rectangle r = new Rectangle(10, max_ph1*i+10, max_pw1-20, max_ph1);
        //        if (r1.X == r.X && r1.Y == r.Y)
        //        {
        //            g.FillRectangle(Brushes.Red, r);
        //        }
        //        StringFormat sf= new StringFormat();
        //        sf.LineAlignment = StringAlignment.Center;
        //        sf.Alignment = StringAlignment.Center; //居中

        //        g.DrawString("不是固定的", new Font(this.Font, FontStyle.Bold), Brushes.Black, r,sf);
                
        //        g.DrawRectangle(new Pen(Brushes.Blue), r);
        //        r_lis.Add(r);
        //    }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //huatu1(g);
        }
        List<Rectangle> r_lis1 = new List<Rectangle>();
        Rectangle r2;

        //public void huatu1(Graphics g) {
        //    r_lis1.Clear();
        //    int max_pw1 = panel2.Width / 3;
        //    int max_ph1 = panel2.Height / 3;
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Rectangle r = new Rectangle(max_pw1 * j + 10, max_ph1*i+10, max_pw1 - 20, max_ph1);
        //            if (r2.X == r.X && r2.Y == r.Y)
        //                g.FillRectangle(Brushes.Red, r);
        //            {
        //            }
        //            StringFormat sf = new StringFormat();
        //            sf.LineAlignment = StringAlignment.Center;
        //            sf.Alignment = StringAlignment.Center; //居中
        //            g.DrawString("不是固定的", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
        //            g.DrawRectangle(new Pen(Brushes.Blue), r);
        //            r_lis1.Add(r);

        //        }
        //    }
        //}

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //foreach (Rectangle r in r_lis)
            //{
            //    if (r.Contains(e.X, e.Y))
            //    {
            //        this.r1 = r;
            //        break;
            //    }
            //}
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //foreach (Rectangle r in r_lis1)
            //{
            //    if (r.Contains(e.X, e.Y))
            //    {
            //        this.r2 = r;
            //        break;
            //    }
            //}
        }

        private void myPanel2_Paint(object sender, PaintEventArgs e)
        {
            int ccc = 1 > 2? 2 : 1;
            int a = 5 / 4;
            Graphics g = e.Graphics;
            zidingyi z = new zidingyi();
            z.height = this.panel1.Height;
            z.width = this.panel1.Width;
            Rectangle r = new Rectangle(z.height / 10, z.width / 10, z.height / 3, z.width / 3);
            for (int i = 0; i < 4; i++)
            {
                g.DrawRectangle(new Pen(Color.GreenYellow), r);
                g.FillRectangle(Brushes.GreenYellow, r);
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center; //居中
                g.DrawString("下一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
            }
        }

        private void userControl5_Load(object sender, EventArgs e)
        {

        }

        private void userControl311_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

           
        }

        private void userControl311_Click(object sender, EventArgs e)
        {

        }

        private void userControl310_Load(object sender, EventArgs e)
        {
        }

        private void userControl310_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("哈哈");

        }

        private void userControl310_Load_1(object sender, EventArgs e)
        {
            Binding b = new Binding("name", "a", "userControl310");

            string[] a = {"a","b","c" };
            userControl310.DataBindings.Add(b);
        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
