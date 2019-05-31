using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaleClient.Forms
{
    public partial class frmChooseSup : Form
    {
        private Font label_font;
        private Color no_choose_color;
        private Color choose_color;
        private Color finish_color;
        public frmChooseSup()
        {
            InitializeComponent();
            //

            cons.AddClickAct.Add(pictureBox2);
            cons.AddClickAct.Add(pnlPre);
            cons.AddClickAct.Add(pnlNext);
            label_font = new Font("宋体", 20f, FontStyle.Regular);
            no_choose_color = Color.FromArgb(50, 205, 50);
            choose_color = Color.FromArgb(255, 255, 255);
            finish_color = Color.FromArgb(46, 139, 87);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private model.bi_t_supcust_info item = null;
        private DataTable tb = new DataTable();
        List<model.bi_t_supcust_info> lst = new List<model.bi_t_supcust_info>();
        public model.bi_t_supcust_info Choose(string bc_no)
        {
            IBll.ISaleData bll = new Bll.SaleData();
            this.lst = bll.GetSupcustList("S", bc_no);
            tb.Columns.Add("supcust_no");
            tb.Columns.Add("sup_name");

            foreach (model.bi_t_supcust_info item in this.lst)
            {
                var row = tb.NewRow();
                tb.Rows.Add(row);
                row["supcust_no"] = item.supcust_no;
                row["sup_name"] = item.sup_name;
            }

            //
            this.ShowDialog();
            return this.item;
        }


        private int page_size = 9;
        private int page_index = 1;
        //private int row_height = 50;
        private void frmChooseSup_Shown(object sender, EventArgs e)
        {
            this.ShowData();
        }

        private void pnlPre_Click(object sender, EventArgs e)
        {
            int page_count = tb.Rows.Count / page_size;
            if (tb.Rows.Count % page_size != 0)
            {
                page_count++;
            }
            if (page_index > 1)
            {
                page_index--;
            }
            this.ShowData();
            myPanel1.Refresh();
        }

        private void pnlNext_Click(object sender, EventArgs e)
        {
            int page_count = tb.Rows.Count / page_size;
            if (tb.Rows.Count % page_size != 0)
            {
                page_count++;
            }
            if (page_index < page_count)
            {
                page_index++;
            }
            this.ShowData();
            myPanel1.Refresh();
        }
        private DataTable dtpage_index = new DataTable();
        private void ShowData()
        {
            var t = tb.Clone();
            for (int i = (page_index - 1) * page_size; i < page_index * page_size; i++)
            {
                if (i < tb.Rows.Count)
                {
                    t.Rows.Add(tb.Rows[i].ItemArray);
                }
                else
                {

                }
            }
            dtpage_index = t;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frmChooseSup_FormClosed(object sender, FormClosedEventArgs e)
        {
            tb = null;
            lst = null;
        }
        List<Rectangle> r_lis = new List<Rectangle>();
        Rectangle r1;
        private void myPanel1_Paint(object sender, PaintEventArgs e)
        {
            r_lis.Clear();
            Graphics g = e.Graphics;
            //数据总数
            int dgvcount = this.dtpage_index.Rows.Count;
            if (dgvcount == 0)
            {
                return;
            }
            int height = this.myPanel1.Height / 3 - 15;
            int width = this.myPanel1.Width / 3 - 10;
            int fori = 3;
            int forj = 3;
            if (dgvcount <= 3)
            {
                fori = 1;
            }
            fori = dgvcount > 6 ? 3 : 2;
            for (int i = 0; i < 3; i++)
            {
                int forjshuliang = dgvcount / 3;
                if (i == forjshuliang)
                {
                    forj = dgvcount - (i * 3);
                }
                for (int j = 0; j < forj; j++)
                {
                    Rectangle r = new Rectangle(width * j + 12, height * i + 10 + (i * 10), width - 20, height-10);
                    g.DrawRectangle(new Pen(no_choose_color), r);
                    g.FillRectangle(new SolidBrush(no_choose_color), r);
                    if (r1.X == r.X && r1.Y == r.Y)
                    {
                        g.DrawRectangle(new Pen(choose_color), r);
                        g.FillRectangle(new SolidBrush(choose_color), r);
                        DataRow dr = this.dtpage_index.Rows[(i * 3) + j];
                        string supcust_no = dr["supcust_no"].ToString();
                        foreach (model.bi_t_supcust_info item in this.lst)
                        {
                            if (supcust_no == item.supcust_no)
                            {
                                this.item = item;
                                this.Close();
                                break;
                            }
                        }
                    }
                    SizeF center_supcust_no = g.MeasureString(this.dtpage_index.Rows[(i * 3) + j]["supcust_no"].ToString(), label_font);
                    if (this.dtpage_index.Rows[(i * 3) + j][1].ToString().Length > 6)
                    {
                        g.DrawString(this.dtpage_index.Rows[(i * 3) + j]["supcust_no"].ToString(), label_font, Brushes.White, width * j + ((width - center_supcust_no.Width) / 2), height * i + 30 + (i * 10));
                        SizeF center_sup_name = g.MeasureString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString().Substring(0, 6), label_font);
                        g.DrawString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString().Substring(0, 6), label_font, Brushes.White, width * j + ((width - center_sup_name.Width) / 2), height * i + 80 + (i * 10));
                        SizeF center_sup_name1 = g.MeasureString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString().Substring(7), label_font);
                        g.DrawString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString().Substring(7), label_font, Brushes.White, width * j + ((width - center_sup_name1.Width) / 2), height * i + 110 + (i * 10));

                    }
                    else
                    {
                        SizeF center_sup_name = g.MeasureString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString(), label_font);
                        g.DrawString(this.dtpage_index.Rows[(i * 3) + j]["supcust_no"].ToString(), label_font, Brushes.White, width * j + ((width - center_supcust_no.Width) / 2), height * i + 50 + (i * 10));
                        g.DrawString(this.dtpage_index.Rows[(i * 3) + j]["sup_name"].ToString(), label_font, Brushes.White, width * j + ((width - center_sup_name.Width) / 2), height * i + 110 + (i * 10));
                    }
                    r_lis.Add(r);

                }
            }



        }

        private void myPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in r_lis)
            {
                if (r.Contains(e.X, e.Y))
                {
                    this.r1 = r;
                    myPanel1.Refresh();
                    break;
                }
            }
        }


    }
}
