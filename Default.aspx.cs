using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer
{
    public partial class Default : System.Web.UI.Page
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ltrDanhMucTinTuc.Text = LayDanhMucTinTuc();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string LayDanhMucTinTuc()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.DanhMucTin.Thongtin_DanhmucTin_by_MaDMCha("0");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += @"<li><a href='/Default.aspx?modul=Blog&modulphu=ListBlog&id=" + dt.Rows[i]["MaDM"] + @"' title='" + dt.Rows[i]["TenDM"] + @"'>" + dt.Rows[i]["TenDM"] + @"</a></li>";
            }
            return s;
        }
    }
}