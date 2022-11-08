
namespace Saving_Account_Management
{
    partial class FormDangNhap
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
            this.gbDangNhap = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.gbDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDangNhap
            // 
            this.gbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.gbDangNhap.Controls.Add(this.lbError);
            this.gbDangNhap.Controls.Add(this.btnSignIn);
            this.gbDangNhap.Controls.Add(this.tbPassWord);
            this.gbDangNhap.Controls.Add(this.tbUserName);
            this.gbDangNhap.Controls.Add(this.label2);
            this.gbDangNhap.Controls.Add(this.label1);
            this.gbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDangNhap.Location = new System.Drawing.Point(133, 62);
            this.gbDangNhap.Name = "gbDangNhap";
            this.gbDangNhap.Size = new System.Drawing.Size(607, 336);
            this.gbDangNhap.TabIndex = 0;
            this.gbDangNhap.TabStop = false;
            this.gbDangNhap.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(217, 95);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(341, 34);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassWord
            // 
            this.tbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassWord.Location = new System.Drawing.Point(217, 172);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(341, 34);
            this.tbPassWord.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderSize = 3;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Location = new System.Drawing.Point(403, 255);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(155, 49);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(44, 232);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(270, 20);
            this.lbError.TabIndex = 5;
            this.lbError.Text = "Tên đăng nhập hoặc mật khẩu sai !";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Saving_Account_Management.Properties.Resources.Bankimg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.gbDangNhap);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.gbDangNhap.ResumeLayout(false);
            this.gbDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDangNhap;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}