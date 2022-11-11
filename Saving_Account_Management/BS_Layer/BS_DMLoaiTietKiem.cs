using Saving_Account_Management.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DMLoaiTietKiem
    {
        DB_Connect db = null;
        public BS_DMLoaiTietKiem()
        {
            db = new DB_Connect();
        }
        public DataSet LayDanhSachLoaiTietKiem()
        {
            db.new_comm();
            string sql = "select * from LOAI_TIET_KIEM";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}

