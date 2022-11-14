using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Saving_Account_Management.BS_Layer;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_TacVuSoTK : Form
    {
        private BS_DSSoTK action = new BS_DSSoTK();
        public QL_TacVuSoTK()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            dgv_SoTK.DataSource = action.LayDanhSachSoTK().Tables[0];

            disable();
            rdb_TimKiemMa.Checked = true;
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


    }
}
