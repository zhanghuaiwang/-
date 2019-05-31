namespace WindowsFormsApp3
{
    partial class forForm
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
            this.userControl1 = new WindowsFormsApp3.cons.UserControl();
            this.SuspendLayout();
            // 
            // userControl1
            // 
            this.userControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.userControl1.Location = new System.Drawing.Point(0, 0);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(139, 113);
            this.userControl1.TabIndex = 0;
            this.userControl1.Load += new System.EventHandler(this.userControl1_Load);
            // 
            // forForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 549);
            this.Controls.Add(this.userControl1);
            this.Name = "forForm";
            this.Text = "forForm";
            this.ResumeLayout(false);

        }

        #endregion

        private cons.UserControl userControl1;
    }
}