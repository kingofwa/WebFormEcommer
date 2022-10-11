using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.display
{
    public partial class DisplayLoadControl : System.Web.UI.UserControl
    {
        private string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            switch (modul)
            {
                case "Shop":
                    plLoadControl.Controls.Add(LoadControl("Shop/ShopLoadControl.ascx"));
                    break;

                case "Contact":
                    plLoadControl.Controls.Add(LoadControl("Contact/ContactLoadControl.ascx"));
                    break;

                case "Blog":
                    plLoadControl.Controls.Add(LoadControl("Blog/BlogLoadControl.ascx"));
                    break;

                default:
                    plLoadControl.Controls.Add(LoadControl("Home/HomeLoadControl.ascx"));
                    break;

            }

        }
    }
}