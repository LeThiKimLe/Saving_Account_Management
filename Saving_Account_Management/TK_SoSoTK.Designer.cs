
namespace Saving_Account_Management
{
    partial class TK_SoSoTK
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
            this.gb_TKSoSoTK = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_TKSoSoTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_TKSoSoTK
            // 
            this.gb_TKSoSoTK.Controls.Add(this.label1);
            this.gb_TKSoSoTK.Location = new System.Drawing.Point(14, 9);
            this.gb_TKSoSoTK.Name = "gb_TKSoSoTK";
            this.gb_TKSoSoTK.Size = new System.Drawing.Size(1880, 762);
            this.gb_TKSoSoTK.TabIndex = 1;
            this.gb_TKSoSoTK.TabStop = false;
            this.gb_TKSoSoTK.Text = "Thống kê Số sổ Tiết kiệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hiển thị số sổ lập được theo ngày, tháng, năm, biểu đồ";
            // 
            // TK_SoSoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1909, 780);
            this.Controls.Add(this.gb_TKSoSoTK);
            this.Name = "TK_SoSoTK";
            this.Text = "TK_SoSoTK";
            this.gb_TKSoSoTK.ResumeLayout(false);
            this.gb_TKSoSoTK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox gb_TKSoSoTK;
    }
}