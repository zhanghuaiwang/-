using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Frmmin : Form
    {
        public Frmmin()
        {
            InitializeComponent();
        }

        private void Frmmin_Load(object sender, EventArgs e)
        {
            DataTable main_tb = new DataTable();
            DataTable detail_tb = new DataTable();

            main_tb.Columns.Add("aas");
            detail_tb.Columns.Add("aas");

            main_tb.Rows.Add("asd");
            detail_tb.Rows.Add("asd");
            main_tb.Rows.Add("asd2");
            detail_tb.Rows.Add("asd2");
            main_tb.Rows.Add("asd3");
            detail_tb.Rows.Add("asd3");


            this.userControl21.main_tb = main_tb;
            this.userControl21.detail_tb = detail_tb;
        }
    }
}
