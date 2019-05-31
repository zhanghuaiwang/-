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
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        public DataTable main_tb { get; set; }
        public DataTable detail_tb { get; set; }

        public List<CellInfo> cel_lis = new List<CellInfo>();

        private Color _txt_Color = Color.Black;
        public Color Txt_Color
        {
            get
            {
                return _txt_Color;
            }
            set
            {
                _txt_Color = value;
            }
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            Form frm = this.Parent as Form;
            if (frm != null && frm.Visible == true)
            {
                //cel_lis= cel_lis.DeSerializableObject("user_lis");
          
                frm.FormClosing += Frm_Closeing;
            }
        }

        public void Frm_Closeing(object sender, EventArgs e)
        {

            //cel_lis.SerializableObject("user_lis");
        }

        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (main_tb == null) return;
                int top = 10;
                Graphics g = e.Graphics;
                foreach (DataRow r in main_tb.Rows)
                {
                    string str = r[0].ToString();

                    SizeF sizef = g.MeasureString(str, this.Font);


                    g.DrawString(str, this.Font, new SolidBrush(this.Txt_Color), 0, top);

                    top += (int)sizef.Height + 10;

                }


            }
            catch (Exception)
            {

            }

        }

        private void myPanel2_Paint(object sender, PaintEventArgs e)
        {
            if (detail_tb == null) return;

            int top = 10;
            Graphics g = e.Graphics;
            foreach (DataRow r in detail_tb.Rows)
            {
                string str = r[0].ToString();

                SizeF sizef = g.MeasureString(str, this.Font);

                g.DrawString(str, this.Font, new SolidBrush(this.Txt_Color), 0, top);

                top += (int)sizef.Height + 10;
            }
        }





    }

    [Serializable]
    public class CellInfo : IDraw
    {



        public string Content { get; set; }
        public int left { get; set; }
        public int wid { get; set; }
        Color IDraw.Back_Clor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        Color IDraw.Fore_Clor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IDraw.Close()
        {
            throw new NotImplementedException();
        }

        void IDraw.Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDraw
    {
        Color Back_Clor { get; set; }
        Color Fore_Clor { get; set; }
        void Draw(Graphics g);
        void Close();
    }

}
