using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.Product.Category
{
    public partial class CategoryLoadControl : System.Web.UI.UserControl
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
                    plCategoryLoadControl.Controls.Add(LoadControl("AddCategory.ascx"));
                    break;
                case "Show":
                    plCategoryLoadControl.Controls.Add(LoadControl("ShowCategory.ascx"));
                    break;

                default:
                    plCategoryLoadControl.Controls.Add(LoadControl("ShowCategory.ascx"));
                    break;

            }
        }
    }
}