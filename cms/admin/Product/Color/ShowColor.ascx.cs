﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.Product.Color
{
    public partial class ShowColor : System.Web.UI.UserControl
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayMau();
        }

        private void LayMau()
        {
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.Mau.Thongtin_Mau();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrMau.Text += @"
        <tr id='maDong_" + dt.Rows[i]["MauID"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["MauID"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["TenMau"] + @"</td>
           <td class='cotCongCu'>
     
               <a href='/Admin.aspx?modul=Product&submodul=Color&handle=Edit&id=" + dt.Rows[i]["MauID"] + @"' class='sua' title='Sửa'></a>
               <a href='javascript:XoaMau(" + dt.Rows[i]["MauID"] + @")' class='xoa' title='Xóa'></a>
           </td>
        </tr>
        ";
            }

        }
    }
}