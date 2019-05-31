namespace WindowsFormsApp3
{
    partial class Frmmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.class11 = new WindowsFormsApp3.cons.Class1();
            this.userControl21 = new WindowsFormsApp3.cons.UserControl2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // class11
            // 
            this.class11.Location = new System.Drawing.Point(401, 51);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(241, 21);
            this.class11.TabIndex = 0;
            // 
            // userControl21
            // 
            this.userControl21.detail_tb = null;
            this.userControl21.Location = new System.Drawing.Point(438, 230);
            this.userControl21.main_tb = null;
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(160, 175);
            this.userControl21.TabIndex = 2;
            this.userControl21.Txt_Color = System.Drawing.Color.Empty;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 450);
            this.panel1.TabIndex = 3;
            // 
            // Frmmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.class11);
            this.Name = "Frmmin";
            this.Text = "Frmmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cons.Class1 class11;
        private cons.UserControl2 userControl21;
        private System.Windows.Forms.Panel panel1;
    }
}