using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.display.Blog
{
    public partial class ListBlog : System.Web.UI.UserControl
    {
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                id = Request.QueryString["id"];
               
            }
            if (!IsPostBack)
            {
                ltrNhomTinTuc.Text = LayTatCaDanhSachTinTucTheoDanhMuc(id);
                FashionBlog.Text = LayDanhMucTinTuc();
            }

        }

        private string LayDanhMucTinTuc()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.DanhMucTin.Thongtin_DanhmucTin_by_id(id);
            s = (string)dt.Rows[0]["TenDM"];
            return s;
        }


        private string LayTatCaDanhSachTinTucTheoDanhMuc(string MaDM)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.TinTuc.Thongtin_TinTuc_by_madm_tatca(MaDM);

            string link = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=Blog&modulphu=BlogDetail&id=" + dt.Rows[i]["TinTucID"];

                s += @" 
                <div class='col-12 col-lg-6 col-md-3'>
                    <div class='single-blog-area mb-50'>
                        <img class='imganh' src='/pic/tintuc/" + dt.Rows[i]["AnhDaiDien"] + @"' alt='" + dt.Rows[i]["TieuDe"] + @"' />
                        <div class='post-title'>
                            <a href='" + link + @"'> " + dt.Rows[i]["TieuDe"] + @"</a>
                        </div>
                        <div class='hover-content'>
                            <div class='hover-post-title'>
                                <a href='" + link + @"'> " + dt.Rows[i]["MoTa"] + @"</a>
                            </div>
                            <a href='" + link + @"'> Continue reading<i class='fa fa-angle-right'></i></a>
                        </div>
                    </div>
                </div>";


            }
            return s;
        }
    }
}