using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.KhachHang
{
    public partial class KhachHang_HienThi : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LayKhachHang();
        }

        private void LayKhachHang()
        {
            DataTable dt = new DataTable();
            dt = Rikai_Ecommer.KhachHang.Thongtin_Khachhang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ltrKhachHang.Text += @"
<tr id='maDong_" + dt.Rows[i]["MaKH"] + @"'>
           <td class='cotMa'>" + dt.Rows[i]["MaKH"] + @"</td>
           <td class='cotTen'>" + dt.Rows[i]["TenKH"] + @"</td>
           <td class='cotAnh'>" + dt.Rows[i]["DiaChiKH"] + @"</td>
           <td class='cotThuTu'>" + dt.Rows[i]["sdtKH"] + @"</td>
           <td class='cotEmail'>" + dt.Rows[i]["EmailKH"] + @"</td>
</tr>
";
            }

        }
    }
}