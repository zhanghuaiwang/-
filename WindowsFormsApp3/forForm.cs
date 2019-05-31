using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.cons;

namespace WindowsFormsApp3
{
    public partial class forForm : System.Windows.Forms.Form
    {
        public forForm()
        {
            InitializeComponent();
        }

        private void userControl1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                UserControl uc = new UserControl();
                
            }
        }
    }
}
