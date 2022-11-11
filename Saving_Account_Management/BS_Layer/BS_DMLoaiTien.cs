using Saving_Account_Management.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DMLoaiTien
    {
        DB_Connect db = null;
        public BS_DMLoaiTien()
        {
            db = new DB_Connect();
        }
        public DataSet LayDanhSachLoaiTien()
        {
            db.new_comm();
            string sql = "select * from LOAI_TIEN";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

    }
}
