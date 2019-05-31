namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl311 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl310 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl39 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl38 = new WindowsFormsApp3.cons.UserControl3();
            this.myPanel3 = new WindowsFormsApp3.cons.MyPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.myPanel2 = new WindowsFormsApp3.cons.MyPanel();
            this.myPanel1 = new WindowsFormsApp3.cons.MyPanel();
            this.userControl37 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl36 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl35 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl34 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl33 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl32 = new WindowsFormsApp3.cons.UserControl3();
            this.userControl31 = new WindowsFormsApp3.cons.UserControl3();
            this.panel1.SuspendLayout();
            this.myPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.myPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userControl311);
            this.panel1.Controls.Add(this.userControl310);
            this.panel1.Controls.Add(this.userControl39);
            this.panel1.Controls.Add(this.userControl38);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(159, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 65);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // userControl311
            // 
            this.userControl311.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userControl311.Location = new System.Drawing.Point(30, 13);
            this.userControl311.Name = "userControl311";
            this.userControl311.Size = new System.Drawing.Size(134, 40);
            this.userControl311.TabIndex = 4;
            this.userControl311.Load += new System.EventHandler(this.userControl311_Load);
            this.userControl311.Click += new System.EventHandler(this.userControl311_Click);
            // 
            // userControl310
            // 
            this.userControl310.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl310.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userControl310.Location = new System.Drawing.Point(198, 13);
            this.userControl310.Name = "userControl310";
            this.userControl310.Size = new System.Drawing.Size(134, 40);
            this.userControl310.TabIndex = 3;
            this.userControl310.Load += new System.EventHandler(this.userControl310_Load_1);
            this.userControl310.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userControl310_MouseClick);
            // 
            // userControl39
            // 
            this.userControl39.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl39.Location = new System.Drawing.Point(534, 13);
            this.userControl39.Name = "userControl39";
            this.userControl39.Size = new System.Drawing.Size(134, 40);
            this.userControl39.TabIndex = 2;
            // 
            // userControl38
            // 
            this.userControl38.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.userControl38.Location = new System.Drawing.Point(369, 13);
            this.userControl38.Name = "userControl38";
            this.userControl38.Size = new System.Drawing.Size(134, 40);
            this.userControl38.TabIndex = 1;
            // 
            // myPanel3
            // 
            this.myPanel3.Content = null;
            this.myPanel3.Content2 = null;
            this.myPanel3.Content3 = null;
            this.myPanel3.Controls.Add(this.dataGridView1);
            this.myPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanel3.Image = null;
            this.myPanel3.Location = new System.Drawing.Point(159, 0);
            this.myPanel3.Name = "myPanel3";
            this.myPanel3.Size = new System.Drawing.Size(685, 151);
            this.myPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // myPanel2
            // 
            this.myPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.myPanel2.Content = "";
            this.myPanel2.Content2 = null;
            this.myPanel2.Content3 = null;
            this.myPanel2.Image = null;
            this.myPanel2.Location = new System.Drawing.Point(159, 0);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(685, 447);
            this.myPanel2.TabIndex = 1;
            this.myPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel2_Paint);
            // 
            // myPanel1
            // 
            this.myPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.myPanel1.Content = null;
            this.myPanel1.Content2 = null;
            this.myPanel1.Content3 = null;
            this.myPanel1.Controls.Add(this.userControl37);
            this.myPanel1.Controls.Add(this.userControl36);
            this.myPanel1.Controls.Add(this.userControl35);
            this.myPanel1.Controls.Add(this.userControl34);
            this.myPanel1.Controls.Add(this.userControl33);
            this.myPanel1.Controls.Add(this.userControl32);
            this.myPanel1.Controls.Add(this.userControl31);
            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.myPanel1.Image = null;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(159, 497);
            this.myPanel1.TabIndex = 0;
            // 
            // userControl37
            // 
            this.userControl37.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl37.Location = new System.Drawing.Point(12, 210);
            this.userControl37.Name = "userControl37";
            this.userControl37.Size = new System.Drawing.Size(134, 40);
            this.userControl37.TabIndex = 6;
            // 
            // userControl36
            // 
            this.userControl36.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl36.Location = new System.Drawing.Point(12, 79);
            this.userControl36.Name = "userControl36";
            this.userControl36.Size = new System.Drawing.Size(134, 40);
            this.userControl36.TabIndex = 5;
            // 
            // userControl35
            // 
            this.userControl35.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl35.Location = new System.Drawing.Point(12, 139);
            this.userControl35.Name = "userControl35";
            this.userControl35.Size = new System.Drawing.Size(134, 40);
            this.userControl35.TabIndex = 4;
            // 
            // userControl34
            // 
            this.userControl34.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl34.Location = new System.Drawing.Point(12, 432);
            this.userControl34.Name = "userControl34";
            this.userControl34.Size = new System.Drawing.Size(134, 40);
            this.userControl34.TabIndex = 3;
            // 
            // userControl33
            // 
            this.userControl33.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl33.Location = new System.Drawing.Point(12, 360);
            this.userControl33.Name = "userControl33";
            this.userControl33.Size = new System.Drawing.Size(134, 40);
            this.userControl33.TabIndex = 2;
            // 
            // userControl32
            // 
            this.userControl32.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl32.Location = new System.Drawing.Point(12, 276);
            this.userControl32.Name = "userControl32";
            this.userControl32.Size = new System.Drawing.Size(134, 40);
            this.userControl32.TabIndex = 1;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.SystemColors.Highlight;
            this.userControl31.Location = new System.Drawing.Point(12, 21);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(134, 40);
            this.userControl31.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 497);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.myPanel3);
            this.Controls.Add(this.myPanel2);
            this.Controls.Add(this.myPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.myPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.myPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private cons.MyPanel myPanel1;
        private cons.MyPanel myPanel2;
        private cons.UserControl3 userControl31;
        private cons.UserControl3 userControl37;
        private cons.UserControl3 userControl36;
        private cons.UserControl3 userControl35;
        private cons.UserControl3 userControl34;
        private cons.UserControl3 userControl33;
        private cons.UserControl3 userControl32;
        private cons.MyPanel myPanel3;
        private System.Windows.Forms.Panel panel1;
        private cons.UserControl3 userControl311;
        private cons.UserControl3 userControl310;
        private cons.UserControl3 userControl39;
        private cons.UserControl3 userControl38;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

