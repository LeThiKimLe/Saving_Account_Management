
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
            this.dataGridView_ChiNhanh = new System.Windows.Forms.DataGridView();
            this.Col_MaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DiaChiCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_SLNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TenGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ = new System.Windows.Forms.Label();
            this.gb_DMChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_DMChiNhanh
            // 
            this.gb_DMChiNhanh.Controls.Add(this.label_);
            this.gb_DMChiNhanh.Controls.Add(this.dataGridView_ChiNhanh);
            this.gb_DMChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb_DMChiNhanh.Location = new System.Drawing.Point(10, 7);
            this.gb_DMChiNhanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMChiNhanh.Name = "gb_DMChiNhanh";
            this.gb_DMChiNhanh.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_DMChiNhanh.Size = new System.Drawing.Size(1410, 619);
            this.gb_DMChiNhanh.TabIndex = 2;
            this.gb_DMChiNhanh.TabStop = false;
            // 
            // dataGridView_ChiNhanh
            // 
            this.dataGridView_ChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaCN,
            this.Col_TenCN,
            this.Col_DiaChiCN,
            this.Col_SLNV,
            this.Col_TenGD});
            this.dataGridView_ChiNhanh.Location = new System.Drawing.Point(38, 116);
            this.dataGridView_ChiNhanh.Name = "dataGridView_ChiNhanh";
            this.dataGridView_ChiNhanh.Size = new System.Drawing.Size(941, 150);
            this.dataGridView_ChiNhanh.TabIndex = 1;
            this.dataGridView_ChiNhanh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChiNhanh_CellContentClick);
            // 
            // Col_MaCN
            // 
            this.Col_MaCN.HeaderText = "Mã Chi Nhánh";
            this.Col_MaCN.Name = "Col_MaCN";
            // 
            // Col_TenCN
            // 
            this.Col_TenCN.HeaderText = "Tên Chi ";
            this.Col_TenCN.Name = "Col_TenCN";
            this.Col_TenCN.Width = 200;
            // 
            // Col_DiaChiCN
            // 
            this.Col_DiaChiCN.HeaderText = "Địa Chỉ ";
            this.Col_DiaChiCN.Name = "Col_DiaChiCN";
            this.Col_DiaChiCN.Width = 300;
            // 
            // Col_SLNV
            // 
            this.Col_SLNV.HeaderText = "Số Lượng Nhân Viên";
            this.Col_SLNV.Name = "Col_SLNV";
            // 
            // Col_TenGD
            // 
            this.Col_TenGD.HeaderText = "Tên Giám Đốc";
            this.Col_TenGD.Name = "Col_TenGD";
            this.Col_TenGD.Width = 200;
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_.Location = new System.Drawing.Point(399, 40);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(243, 24);
            this.label_.TabIndex = 2;
            this.label_.Text = "THÔNG TIN CHI NHÁNH";
            // 
            // DM_ChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.gb_DMChiNhanh);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DM_ChiNhanh";
            this.Text = "DM_ChiNhanh";
            this.gb_DMChiNhanh.ResumeLayout(false);
            this.gb_DMChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiNhanh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.GroupBox gb_DMChiNhanh;
        private System.Windows.Forms.DataGridView dataGridView_ChiNhanh;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DiaChiCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_SLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TenGD;
    }
}