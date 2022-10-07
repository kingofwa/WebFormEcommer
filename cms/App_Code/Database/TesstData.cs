using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Ecommer.cms.App_Code.Database
{
    public class TesstData
    {
        public static DataTable Thongtin_Danhmuc_by_MaDMCha(string MaDMCha)
        {
            OleDbCommand cmd = new OleDbCommand("thongtin_danhmuc_by_MaDMCha");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaDMCha", MaDMCha);
            return SQLDatabase.GetData(cmd);
        }
    }
}