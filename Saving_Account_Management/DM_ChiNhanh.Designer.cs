
namespace Saving_Account_Management
{
    partial class DM_ChiNhanh
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
            this.gb_DMChiNhanh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_DMChiNhanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_DMChiNhanh
            // 
            this.gb_DMChiNhanh.Controls.Add(this.label1);
            this.gb_DMChiNhanh.Location = new System.Drawing.Point(14, 9);
            this.gb_DMChiNhanh.Name = "gb_DMChiNhanh";
            this.gb_DMChiNhanh.Size = new System.Drawing.Size(1880, 762);
            this.gb_DMChiNhanh.TabIndex = 2;
            this.gb_DMChiNhanh.TabStop = false;
            this.gb_DMChiNhanh.Text = "Danh mục Chi Nhánh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị danh sách chi nhánh, địa điểm số nhân viên, tên giám đốc";
            // 
            // DM_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_DMChiNhanh);
            this.Name = "DM_ChiNhanh";
            this.Text = "DM_ChiNhanh";
            this.gb_DMChiNhanh.ResumeLayout(false);
            this.gb_DMChiNhanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_DMChiNhanh;
    }
}