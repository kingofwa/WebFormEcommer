using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin
{
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        string modul = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            switch (modul)
            {
                case "Product":
                    plAdminLoadControl.Controls.Add(LoadControl("Product/ProductLoadControl.ascx"));
                    break;

                case "Account":
                    plAdminLoadControl.Controls.Add(LoadControl("Account/AccountLoadControl.ascx"));
                    break;

                case "Advertisement":
                    plAdminLoadControl.Controls.Add(LoadControl("Advertisement/AdvertisementLoadControl.ascx"));
                    break;

                case "News":
                    plAdminLoadControl.Controls.Add(LoadControl("News/NewsLoadControl.ascx"));
                    break;

                case "Custommer":
                    plAdminLoadControl.Controls.Add(LoadControl("Custommer/CustommerLoadControl.ascx"));
                    break;

                case "Menu":
                    plAdminLoadControl.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
                    break;

                default:
                    plAdminLoadControl.Controls.Add(LoadControl("Product/ProductLoadControl.ascx"));
                    break;

            }
        }
    }
}