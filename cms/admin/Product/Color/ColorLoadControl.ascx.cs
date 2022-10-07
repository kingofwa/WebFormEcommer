using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.Product.Color
{
    public partial class ColorLoadControl : System.Web.UI.UserControl
    {
        private string handle = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["handle"] != null)
                handle = Request.QueryString["handle"];
            switch (handle)
            {
                case "CreateNew":
                case "Edit":
                    plColorLoadControl.Controls.Add(LoadControl("AddColor.ascx"));
                    break;

                case "HienThi":
                    plColorLoadControl.Controls.Add(LoadControl("ShowColor.ascx"));
                    break;

                default:
                    plColorLoadControl.Controls.Add(LoadControl("ShowColor.ascx"));
                    break;

            }
        }
    }
}