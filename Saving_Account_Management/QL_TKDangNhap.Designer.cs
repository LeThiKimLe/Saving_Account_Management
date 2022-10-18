
namespace Saving_Account_Management
{
    partial class QL_TKDangNhap
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
            this.gb_TKDangNhap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TKDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TKDangNhap
            // 
            this.gb_TKDangNhap.Controls.Add(this.label1);
            this.gb_TKDangNhap.Location = new System.Drawing.Point(14, 9);
            this.gb_TKDangNhap.Name = "gb_TKDangNhap";
            this.gb_TKDangNhap.Size = new System.Drawing.Size(1880, 762);
            this.gb_TKDangNhap.TabIndex = 5;
            this.gb_TKDangNhap.TabStop = false;
            this.gb_TKDangNhap.Text = "Tài khoản Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị danh sách tài khoản đăng nhập của nhân viên";
            // 
            // QL_TKDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_TKDangNhap);
            this.Name = "QL_TKDangNhap";
            this.Text = "QL_TKDangNhap";
            this.gb_TKDangNhap.ResumeLayout(false);
            this.gb_TKDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gb_TKDangNhap;
        private System.Windows.Forms.Label label1;
    }
}