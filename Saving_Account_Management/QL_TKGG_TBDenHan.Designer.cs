
namespace Saving_Account_Management
{
    partial class QL_TKGG_TBDenHan
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
            this.gb_TKGG_TBDenHan = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TKGG_TBDenHan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TKGG_TBDenHan
            // 
            this.gb_TKGG_TBDenHan.Controls.Add(this.label1);
            this.gb_TKGG_TBDenHan.Location = new System.Drawing.Point(14, 9);
            this.gb_TKGG_TBDenHan.Name = "gb_TKGG_TBDenHan";
            this.gb_TKGG_TBDenHan.Size = new System.Drawing.Size(1880, 762);
            this.gb_TKGG_TBDenHan.TabIndex = 2;
            this.gb_TKGG_TBDenHan.TabStop = false;
            this.gb_TKGG_TBDenHan.Text = "Thông báo Sổ đến hạn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1043, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị danh sách các sổ đến hạn trả góp, số ngày trễ hạn, tên khách hàng, số đi" +
    "ện thoại,\r\n nếu quá 60 ngày thì thông báo sổ đã tất toán, là đã phát sinh giao d" +
    "ịch tất toán, đánh dấu đóng sổ";
            // 
            // QL_TKGG_TBDenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_TKGG_TBDenHan);
            this.Name = "QL_TKGG_TBDenHan";
            this.Text = "QL_TKGG_TBDenHan";
            this.gb_TKGG_TBDenHan.ResumeLayout(false);
            this.gb_TKGG_TBDenHan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_TKGG_TBDenHan;
    }
}