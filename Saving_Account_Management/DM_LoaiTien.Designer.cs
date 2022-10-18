
namespace Saving_Account_Management
{
    partial class DM_LoaiTien
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
            this.gb_DMLoaiTien = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DMLoaiTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DMLoaiTien
            // 
            this.gb_DMLoaiTien.Controls.Add(this.label1);
            this.gb_DMLoaiTien.Location = new System.Drawing.Point(14, 9);
            this.gb_DMLoaiTien.Name = "gb_DMLoaiTien";
            this.gb_DMLoaiTien.Size = new System.Drawing.Size(1880, 762);
            this.gb_DMLoaiTien.TabIndex = 2;
            this.gb_DMLoaiTien.TabStop = false;
            this.gb_DMLoaiTien.Text = "Danh mục Loại Tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị danh mục loại tiền có thể gửi tiết kiệm tại ngân hàng\r\n\r\n";
            // 
            // DM_LoaiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_DMLoaiTien);
            this.Name = "DM_LoaiTien";
            this.Text = "DM_LoaiTien";
            this.gb_DMLoaiTien.ResumeLayout(false);
            this.gb_DMLoaiTien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_DMLoaiTien;
    }
}