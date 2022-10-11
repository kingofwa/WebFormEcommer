using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.display.Blog
{
    public partial class BlogDetail : System.Web.UI.UserControl
    {
        private string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
                id = Request.QueryString["id"];

            if (!IsPostBack)
                LayChiTietTinTuc(id);
            ltrTicTucLienQuan.Text = LayTatCaDanhSachTinTucTruTinTucHienTai(id);

        }

        private void LayChiTietTinTuc(string id)
        {
            CapNhatLuotXemTin(id);

            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.TinTuc.Thongtin_Tintuc_by_id(id);
            if (dt.Rows.Count > 0)
            {
                ltrTieuDeTin.Text = dt.Rows[0]["TieuDe"].ToString();
                //ltrNgayDang.Text = ((DateTime)dt.Rows[0]["NgayDang"]).ToString("dd/MM/yyyy");
                //ltrLuotXem.Text = dt.Rows[0]["LuotXem"].ToString();
                ltrDetailBlog.Text =  dt.Rows[0]["ChiTiet"].ToString();
            }
        }

        private void CapNhatLuotXemTin(string id)
        {
            Rikai_Ecommer.TinTuc.CapNhatLuotXemTinTuc(id);
        }

        private string LayTatCaDanhSachTinTucTruTinTucHienTai(string MaTT)
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.TinTuc.Thongtin_TinTuc_by_matintuc_tatca(MaTT);

            string link = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                link = "Default.aspx?modul=Blog&modulphu=BlogDetail&id=" + dt.Rows[i]["TinTucID"];

                s += @" 
                        <div class='single-related-blog-post'>
                                <img  src='/pic/tintuc/" + dt.Rows[i]["AnhDaiDien"] + @"' alt='" + dt.Rows[i]["TieuDe"] + @"' />
                                <a href='" + link + @"'>
                                    <h5>  " + dt.Rows[i]["TieuDe"] + @" </h5>
                                 </a>
                        </div>";

            }
            return s;
        }
    }
}