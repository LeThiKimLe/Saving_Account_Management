using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.DB_Layer;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_DSKhachHang : Form
    {
        private BS_DSKhachHang action = new BS_DSKhachHang();
        public QL_DSKhachHang()
        {
            InitializeComponent();
                Load_Data();

        }

        DB_Connect conn = new DB_Connect();
        private void Load_Data()
        {
            conn.myConnect();
            //string sql = "SELECT MaKhachHang,HoTen,NgaySinh,SDT,MaDinhDanh,NgayCap,NoiCap,DiaChi,DangSuDung FROM KHACH_HANG ";
            string sql = "SELECT * FROM KHACH_HANG ";

            dgv_KhachHang.DataSource = conn.ExecuteQueryDataSet(sql, CommandType.Text).Tables[0];
            disable();
            rdb_TimKiemMa.Enabled = true;
        }

        private void disable()
        {
            this.txt_MaKH.Enabled = false;
            this.txt_HoTen.Enabled = false;
            this.txt_NgaySinh.Enabled = false;
            this.txt_Sdt.Enabled = false;
            this.txt_DiaChi.Enabled = false;
            this.txt_MaDinhDanh.Enabled = false;
            this.txt_NgayCap.Enabled = false;
            this.txt_NoiCap.Enabled = false;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdb_TimKiemMa.Checked == true)
            {

            }
            else if (rdb_TimKiemTen.Checked == true)
            {

            }
            else
            {
                
            }
        }

        private void QL_DSKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgv_KhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_MaKH.Text = dgv_KhachHang.Rows[r].Cells[0].Value.ToString();
            this.txt_HoTen.Text = dgv_KhachHang.Rows[r].Cells[1].Value.ToString();
            this.txt_NgaySinh.Text = dgv_KhachHang.Rows[r].Cells[2].Value.ToString();
            this.txt_Sdt.Text = dgv_KhachHang.Rows[r].Cells[3].Value.ToString();
            this.txt_DiaChi.Text = dgv_KhachHang.Rows[r].Cells[4].Value.ToString();
            this.txt_MaDinhDanh.Text = dgv_KhachHang.Rows[r].Cells[5].Value.ToString();
            this.txt_NgayCap.Text = dgv_KhachHang.Rows[r].Cells[6].Value.ToString();
            this.txt_NoiCap.Text = dgv_KhachHang.Rows[r].Cells[7].Value.ToString();
            if ((bool)dgv_KhachHang.Rows[r].Cells[8].Value == true)
            {
                cb_TinhTrangSD.Checked = true;
            }
            else
            {
                cb_TinhTrangSD.Checked = false;
            }
        }

        
    }

}
