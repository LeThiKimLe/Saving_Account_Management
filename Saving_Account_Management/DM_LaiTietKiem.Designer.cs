
namespace Saving_Account_Management
{
    partial class DM_LaiTietKiem
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
            this.gb_DMLaiTietKiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DMLaiTietKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DMLaiTietKiem
            // 
            this.gb_DMLaiTietKiem.Controls.Add(this.label1);
            this.gb_DMLaiTietKiem.Location = new System.Drawing.Point(14, 9);
            this.gb_DMLaiTietKiem.Name = "gb_DMLaiTietKiem";
            this.gb_DMLaiTietKiem.Size = new System.Drawing.Size(1880, 762);
            this.gb_DMLaiTietKiem.TabIndex = 2;
            this.gb_DMLaiTietKiem.TabStop = false;
            this.gb_DMLaiTietKiem.Text = "Danh mục Lãi tiết kiệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị các loại tiết kiệm, kỳ hạn, lãi suất của mỗi loại";
            // 
            // DM_LaiTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_DMLaiTietKiem);
            this.Name = "DM_LaiTietKiem";
            this.Text = "DM_LaiTietKiem";
            this.gb_DMLaiTietKiem.ResumeLayout(false);
            this.gb_DMLaiTietKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_DMLaiTietKiem;
    }
}