
namespace Saving_Account_Management
{
    partial class CN_ThongTin
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
            this.gb_CNThongTin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_CNThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_CNThongTin
            // 
            this.gb_CNThongTin.Controls.Add(this.label1);
            this.gb_CNThongTin.Location = new System.Drawing.Point(12, 12);
            this.gb_CNThongTin.Name = "gb_CNThongTin";
            this.gb_CNThongTin.Size = new System.Drawing.Size(1880, 762);
            this.gb_CNThongTin.TabIndex = 0;
            this.gb_CNThongTin.TabStop = false;
            this.gb_CNThongTin.Text = "Thông tin cá nhân";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị các thông tin của nhân viên đang sử dụng ứng dụng";
            // 
            // CN_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_CNThongTin);
            this.Name = "CN_ThongTin";
            this.Text = "CN_ThongTin";
            this.gb_CNThongTin.ResumeLayout(false);
            this.gb_CNThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_CNThongTin;
    }
}