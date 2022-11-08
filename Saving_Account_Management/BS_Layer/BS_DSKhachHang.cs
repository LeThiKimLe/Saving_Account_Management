using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DSKhachHang
    {
        DB_Connect db = null;
        public BS_DSKhachHang()
        {
            db = new DB_Connect();
        }
        public DataSet LayDanhSachKhachHang()
        {
            db.new_comm();
            //string sql = "SELECT MaKhachHang,HoTen,NgaySinh,SDT,MaDinhDanh,NgayCap,NoiCap,DiaChi,DangSuDung FROM KHACH_HANG ";
            string sql = "SELECT * FROM KHACH_HANG ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string TenNV, string DiaChi, string MaPB, string SDT, ref string err)
        {
            string sqlString = "THEM_NHAN_VIEN";
            db.new_comm();
            db.comm.Parameters.Add("@maNV", SqlDbType.Char).Value = MaNV;
            db.comm.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = TenNV;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = DiaChi;
            db.comm.Parameters.Add("@maPB", SqlDbType.Char).Value = MaPB;
            db.comm.Parameters.Add("@soDT", SqlDbType.Char).Value = SDT;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = "XOA_NHAN_VIEN";
            db.new_comm();
            db.comm.Parameters.Add("@maNV", SqlDbType.Char).Value = MaNV;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }
        public bool CapNhatNhanVien(string MaNV, string TenNV, string DiaChi, string MaPB, string SDT, ref string err)
        {
            string sqlString = "CAP_NHAT_NHAN_VIEN";
            db.new_comm();
            db.comm.Parameters.Add("@maNV", SqlDbType.Char).Value = MaNV;
            db.comm.Parameters.Add("@tenNV", SqlDbType.NVarChar).Value = TenNV;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = DiaChi;
            db.comm.Parameters.Add("@maPB", SqlDbType.Char).Value = MaPB;
            db.comm.Parameters.Add("@soDT", SqlDbType.Char).Value = SDT;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public DataSet getPB()
        {
            string sqlString = "SELECT * from dbo.LAY_PHONG_BAN()";
            db.new_comm();
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public string get_PB_Name(string MaPB)
        {
            string sqlString = "SELECT dbo.LAY_TEN_PHONG_BAN(@maPB)";
            db.new_comm();
            db.comm.Parameters.AddWithValue("@maPB", MaPB);
            string kq = db.ExecuteQueryScalar<string>(sqlString, CommandType.Text);
            return kq;
        }

    }
}
