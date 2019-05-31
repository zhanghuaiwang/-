namespace WindowsFormsApp3.cons
{
    partial class UserControl2
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.myPanel1 = new WindowsFormsApp3.cons.MyPanel();
            this.myPanel2 = new WindowsFormsApp3.cons.MyPanel();
            this.SuspendLayout();
            // 
            // myPanel1
            // 
            this.myPanel1.Content = null;
            this.myPanel1.Content2 = null;
            this.myPanel1.Content3 = null;
            this.myPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.myPanel1.Image = null;
            this.myPanel1.Location = new System.Drawing.Point(0, 0);
            this.myPanel1.Name = "myPanel1";
            this.myPanel1.Size = new System.Drawing.Size(228, 619);
            this.myPanel1.TabIndex = 0;
            this.myPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel1_Paint);
            // 
            // myPanel2
            // 
            this.myPanel2.Content = null;
            this.myPanel2.Content2 = null;
            this.myPanel2.Content3 = null;
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel2.Image = null;
            this.myPanel2.Location = new System.Drawing.Point(228, 0);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(822, 619);
            this.myPanel2.TabIndex = 1;
            this.myPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.myPanel2_Paint);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myPanel2);
            this.Controls.Add(this.myPanel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1050, 619);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyPanel myPanel1;
        private MyPanel myPanel2;
    }
}
