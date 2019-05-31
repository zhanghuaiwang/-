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
    public partial class UserControl3 : System.Windows.Forms.UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }
        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0,0,0,0);
            g.FillRectangle(new SolidBrush(Color.Black),r);
            
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
        }
    }
}
