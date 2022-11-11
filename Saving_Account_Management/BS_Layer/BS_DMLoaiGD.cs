using Saving_Account_Management.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DMLoaiGD
    {

        DB_Connect db = null;
        public BS_DMLoaiGD()
        {
            db = new DB_Connect();
        }
        public DataSet LayDanhSachLoaiGiaoDich()
        {
            db.new_comm();
            string sql = "SELECT * FROM LOAI_GIAO_DICH";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
    }
}
