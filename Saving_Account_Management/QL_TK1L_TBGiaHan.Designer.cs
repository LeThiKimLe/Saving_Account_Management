
namespace Saving_Account_Management
{
    partial class QL_TK1L_TBGiaHan
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
            this.gb_TK1L_TBGiaHan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TK1L_TBGiaHan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TK1L_TBGiaHan
            // 
            this.gb_TK1L_TBGiaHan.Controls.Add(this.label1);
            this.gb_TK1L_TBGiaHan.Location = new System.Drawing.Point(14, 9);
            this.gb_TK1L_TBGiaHan.Name = "gb_TK1L_TBGiaHan";
            this.gb_TK1L_TBGiaHan.Size = new System.Drawing.Size(1880, 762);
            this.gb_TK1L_TBGiaHan.TabIndex = 2;
            this.gb_TK1L_TBGiaHan.TabStop = false;
            this.gb_TK1L_TBGiaHan.Text = "Thông báo Gia hạn sổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1354, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị các sổ đã đến hạn nhưng khách hàng chưa muốn tất toán, gia hạn thêm 1 kỳ" +
    " nữa giống như kỳ cũ, gốc mới= gốc cũ + lãi";
            // 
            // QL_TK1L_TBGiaHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_TK1L_TBGiaHan);
            this.Name = "QL_TK1L_TBGiaHan";
            this.Text = "QL_TK1L_TBGiaHan";
            this.gb_TK1L_TBGiaHan.ResumeLayout(false);
            this.gb_TK1L_TBGiaHan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_TK1L_TBGiaHan;
    }
}