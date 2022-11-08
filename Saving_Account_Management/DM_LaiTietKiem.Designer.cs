
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
            this.dataGridView_LoaiTK = new System.Windows.Forms.DataGridView();
            this.Col_MaLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaHTGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaHTTraLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_KyHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_LaiSuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_LoaiTK = new System.Windows.Forms.Label();
            this.gb_DMLaiTietKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMLaiTietKiem
            // 
            this.gb_DMLaiTietKiem.Controls.Add(this.label_LoaiTK);
            this.gb_DMLaiTietKiem.Controls.Add(this.dataGridView_LoaiTK);
            this.gb_DMLaiTietKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMLaiTietKiem.Location = new System.Drawing.Point(10, 7);
            this.gb_DMLaiTietKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMLaiTietKiem.Name = "gb_DMLaiTietKiem";
            this.gb_DMLaiTietKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMLaiTietKiem.Size = new System.Drawing.Size(1410, 619);
            this.gb_DMLaiTietKiem.TabIndex = 2;
            this.gb_DMLaiTietKiem.TabStop = false;
            // 
            // dataGridView_LoaiTK
            // 
            this.dataGridView_LoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoaiTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaLoaiTK,
            this.Col_MaHTGui,
            this.Col_MaHTTraLai,
            this.Col_KyHan,
            this.Col_LaiSuat});
            this.dataGridView_LoaiTK.Location = new System.Drawing.Point(48, 118);
            this.dataGridView_LoaiTK.Name = "dataGridView_LoaiTK";
            this.dataGridView_LoaiTK.Size = new System.Drawing.Size(892, 150);
            this.dataGridView_LoaiTK.TabIndex = 0;
            // 
            // Col_MaLoaiTK
            // 
            this.Col_MaLoaiTK.HeaderText = "Mã Loại Tiết Kiệm";
            this.Col_MaLoaiTK.Name = "Col_MaLoaiTK";
            this.Col_MaLoaiTK.Width = 150;
            // 
            // Col_MaHTGui
            // 
            this.Col_MaHTGui.HeaderText = "Mã Hình Thức Gửi";
            this.Col_MaHTGui.Name = "Col_MaHTGui";
            this.Col_MaHTGui.Width = 150;
            // 
            // Col_MaHTTraLai
            // 
            this.Col_MaHTTraLai.HeaderText = "Mã Hình Thức Trả Lãi";
            this.Col_MaHTTraLai.Name = "Col_MaHTTraLai";
            this.Col_MaHTTraLai.Width = 150;
            // 
            // Col_KyHan
            // 
            this.Col_KyHan.HeaderText = "Kỳ Hạn";
            this.Col_KyHan.Name = "Col_KyHan";
            this.Col_KyHan.Width = 200;
            // 
            // Col_LaiSuat
            // 
            this.Col_LaiSuat.HeaderText = "Lãi Suất";
            this.Col_LaiSuat.Name = "Col_LaiSuat";
            this.Col_LaiSuat.Width = 200;
            // 
            // label_LoaiTK
            // 
            this.label_LoaiTK.AutoSize = true;
            this.label_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_LoaiTK.Location = new System.Drawing.Point(357, 40);
            this.label_LoaiTK.Name = "label_LoaiTK";
            this.label_LoaiTK.Size = new System.Drawing.Size(281, 24);
            this.label_LoaiTK.TabIndex = 1;
            this.label_LoaiTK.Text = "THÔNG TIN LOẠI TIẾT KIỆM";
            // 
            // DM_LaiTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMLaiTietKiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DM_LaiTietKiem";
            this.Text = "DM_LaiTietKiem";
            this.gb_DMLaiTietKiem.ResumeLayout(false);
            this.gb_DMLaiTietKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoaiTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMLaiTietKiem;
        private System.Windows.Forms.Label label_LoaiTK;
        private System.Windows.Forms.DataGridView dataGridView_LoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHTGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHTTraLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_KyHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_LaiSuat;
    }
}