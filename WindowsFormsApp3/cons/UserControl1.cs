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
    public partial class UserControl1 : System.Windows.Forms.UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public Color f_Color { get; set; }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            g.FillRectangle(new SolidBrush(f_Color), 0, 0, this.Width, this.Height);
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
        }
    }
}
