using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Saving_Account_Management.DB_Layer
{
    public class DB_Connect
    {

        public void myConnect()
        {
            Conn.Open();
        }
        //combobox sự kiện selectindexchange
        public void myClose()
        {
            Conn.Close();
        }

        public DataTable createTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, Conn);
            ds.Fill(dt);
            return dt;
        }






    }
}
