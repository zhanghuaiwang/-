using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3.cons
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public UserControl()
        {
            InitializeComponent();
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(0, 0, this.Width, this.Height);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center; //居中
            g.DrawString("下一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);

            //g.DrawString("第一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf);
            Color c;
            int a = 1;
            if (a == 1)
            {
                c = Color.Blue;
            }
            else { c = Color.GreenYellow; };
            g.DrawRectangle(new Pen(c), r);
            StringFormat sf1 = new StringFormat();
            sf1.LineAlignment = StringAlignment.Near;
            sf1.Alignment = StringAlignment.Center; //居中
            g.DrawString("上一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf1);
            StringFormat sf2 = new StringFormat();
            sf2.LineAlignment = StringAlignment.Near;
            sf2.Alignment = StringAlignment.Far; //居中
            g.DrawString("第一页", new Font(this.Font, FontStyle.Bold), Brushes.Black, r, sf2);
            a += 1;

        }
    }
}
