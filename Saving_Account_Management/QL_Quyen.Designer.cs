﻿
namespace Saving_Account_Management
{
    partial class QL_Quyen
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
            this.gb_QLQuyen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_QLQuyen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_QLQuyen
            // 
            this.gb_QLQuyen.Controls.Add(this.label1);
            this.gb_QLQuyen.Location = new System.Drawing.Point(12, 12);
            this.gb_QLQuyen.Name = "gb_QLQuyen";
            this.gb_QLQuyen.Size = new System.Drawing.Size(1880, 762);
            this.gb_QLQuyen.TabIndex = 0;
            this.gb_QLQuyen.TabStop = false;
            this.gb_QLQuyen.Text = "Quản lý Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị danh sách quyền, các nút xóa, sửa, thêm quyền";
            // 
            // QL_Quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_QLQuyen);
            this.Name = "QL_Quyen";
            this.Text = "QL_Quyen";
            this.gb_QLQuyen.ResumeLayout(false);
            this.gb_QLQuyen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gb_QLQuyen;
        private System.Windows.Forms.Label label1;
    }
}