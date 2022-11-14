using System.Data.SqlClient;
using System.Data;
using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management.BS_Layer
{
    internal class BS_DSSoTK
    {
        DB_Connect db = null;
        string err;

        public BS_DSSoTK()
        {
            db = new DB_Connect();
        }

        public DataSet LayDanhSachSoTK()
        {
            db.new_comm();
            string sql = "SELECT * FROM TAI_KHOAN_TIET_KIEM";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayDanhChuSoHuu(string maSoTK)
        {
            db.new_comm();
            string sql = "select MaKhachHang, HoTen, MaDinhDanh from CHI_TIET_SO where MaSoTK = '" + maSoTK +"'";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }


        // TODO: Nhớ fix lại
        public DataSet TimKiemMaSoTK(string maSoTK)
        {
            DB_Connect conn = new DB_Connect();
            string temp = "SELECT* FROM TAI_KHOAN_TIET_KIEM WHERE MaSoTK LIKE '%" + maSoTK + "%'";
            DataSet ds = conn.ExecuteQueryDataSet(temp, CommandType.Text);
            return ds;
        }

        public DataSet TimKiemSoHuu(string hoTen)
        {
            DB_Connect conn = new DB_Connect();
            string temp =
            "select * from TAI_KHOAN_TIET_KIEM, " +
                "(SELECT TAI_KHOAN_TIET_KIEM.MaSoTK " +
                    "FROM TAI_KHOAN_TIET_KIEM, CHI_TIET_SO " +
                    "where TAI_KHOAN_TIET_KIEM.MaSoTK = CHI_TIET_SO.MaSoTK " +
                    "and CHI_TIET_SO.HoTen like '%" + hoTen + "%') as temp " +
                    "where TAI_KHOAN_TIET_KIEM.MaSoTK = temp.MaSoTK ";
            DataSet ds = conn.ExecuteQueryDataSet(temp, CommandType.Text);
            return ds;
        }

        public DataSet TenHinhThucTK()
        {
            DB_Connect conn = new DB_Connect();
            string temp = "select * from TenHinhThuc";
            DataSet ds = conn.ExecuteQueryDataSet(temp, CommandType.Text);
            return ds;
        }

        public DataSet TimKiemTheoHinhThucTK(string tenHinhThuc)
        {
            DB_Connect conn = new DB_Connect();
            string temp = "select * from TAI_KHOAN_TIET_KIEM RIGHT join " + tenHinhThuc 
                + " on TAI_KHOAN_TIET_KIEM.MaSoTK = " + tenHinhThuc + ".MaSoTK";

            DataSet ds = conn.ExecuteQueryDataSet(temp, CommandType.Text);
            return ds;
        }


        public bool SuaKhachHang(string maKhachHang, string hoTen, string sdt, string diaChi, string maDinhDanh,
                                 string noiCap, string ngaySinh, string ngayCap, string image)
        {
            string sqlString = "SuaKhachHang";
            db.new_comm();
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            db.comm.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            db.comm.Parameters.Add("@ngaySinh", SqlDbType.VarChar).Value = ngaySinh;
            db.comm.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            db.comm.Parameters.Add("@maDinhDanh", SqlDbType.VarChar).Value = maDinhDanh;
            db.comm.Parameters.Add("@ngayCap", SqlDbType.VarChar).Value = ngayCap;
            db.comm.Parameters.Add("@noiCap", SqlDbType.NVarChar).Value = noiCap;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diaChi;
            db.comm.Parameters.Add("@imageFolderPath", SqlDbType.NVarChar).Value = image;
            var result = db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
            return result;
        }
    }
}
