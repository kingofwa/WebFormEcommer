﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.SanPham.QuanLySize
{
    public partial class Size_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LaySize();
        }

        private void LaySize()
        {
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.Size.Thongtin_Size();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrSize.Text += @"
<tr id='maDong_" + dt.Rows[i]["SizeID"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["SizeID"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["TenSize"] + @"</td>
           <td class='cotCongCu'>
              
               <a href='Admin.aspx?modul=SanPham&modulphu=Size&thaotac=ChinhSua&id=" + dt.Rows[i]["SizeID"] + @"' class='sua' title='Sửa'></a>
               <a href='javascript:XoaSize(" + dt.Rows[i]["SizeID"] + @")' class='xoa' title='Xóa'></a>
           </td>
</tr>
";
            }

        }
    }
}