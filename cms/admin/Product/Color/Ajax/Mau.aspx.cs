﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.Product.Color.Ajax
{
    public partial class Mau : System.Web.UI.Page
    {
        string handle = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //Code kiểm tra đăng nhập tại đây sau đó mới thực hiện các thao tác dưới
            //Kiểm tra nếu đã đăng nhập thì mới cho vào trang này
            //if (Session["DangNhap"] != null && Session["DangNhap"].ToString() == "1")
            //{
            //    //Đã đăng nhập
            //}
            //else
            //{
            //    //Nếu chưa đăng nhập --> return để dừng không cho thực hiện các câu lệnh bên dưới
            //    return;
            //}
            if (Request.Params["handle"] != null)
            {
                handle = Request.Params["handle"];
            }

            switch (handle)
            {
                case "XoaMau":
                    XoaMau();
                    break;

            }
        }

        private void XoaMau()
        {
            string MauID = "";
            if (Request.Params["MauID"] != null)
            {
                MauID = Request.Params["MauID"];

                //Thực hiện code xóa
                //B2: Xóa dữ liệu trên sqlserver
                Rikai_Ecommer.Mau.Mau_Delete(MauID);

                // Trả về thông báo 1 thực hiện thành công 2 thực hiện không thành công
                Response.Write("1");
            }
        }
    }
}