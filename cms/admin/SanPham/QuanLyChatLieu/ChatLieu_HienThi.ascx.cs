﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.SanPham.QuanLyChatLieu
{
    public partial class ChatLieu_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayChatLieu();
        }

        private void LayChatLieu()
        {
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.ChatLieu.Thongtin_Chatlieu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrChatLieu.Text += @"
                <tr id='maDong_" + dt.Rows[i]["ChatLieuID"] + @"'>
                           <td class='cotMa'>" + dt.Rows[i]["ChatLieuID"] + @"</td>
                           <td class='cotTen'>" + dt.Rows[i]["TenChatLieu"] + @"</td>
                           <td class='cotCongCu'>
               
                               <a href='Admin.aspx?modul=SanPham&modulphu=ChatLieu&thaotac=ChinhSua&id=" + dt.Rows[i]["ChatLieuID"] + @"' class='sua' title='Sửa'></a>
                               <a href='javascript:XoaChatLieu(" + dt.Rows[i]["ChatLieuID"] + @")' class='xoa' title='Xóa'></a>
                           </td>
                </tr>
                ";
            }

        }
    }
}