
namespace Saving_Account_Management
{
    partial class QL_PhanNhom
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
            this.gb_PhanNhom = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_PhanNhom.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_PhanNhom
            // 
            this.gb_PhanNhom.Controls.Add(this.label1);
            this.gb_PhanNhom.Location = new System.Drawing.Point(14, 9);
            this.gb_PhanNhom.Name = "gb_PhanNhom";
            this.gb_PhanNhom.Size = new System.Drawing.Size(1880, 762);
            this.gb_PhanNhom.TabIndex = 3;
            this.gb_PhanNhom.TabStop = false;
            this.gb_PhanNhom.Text = "Phân nhóm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị các nhóm người dùng và các nhân viên thuộc nhóm đó, có các nút thực hiện" +
    " thêm hoặc xóa nhân viên khỏi nhóm";
            // 
            // QL_PhanNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_PhanNhom);
            this.Name = "QL_PhanNhom";
            this.Text = "QL_PhanNhom";
            this.gb_PhanNhom.ResumeLayout(false);
            this.gb_PhanNhom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_PhanNhom;
    }
}