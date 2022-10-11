using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.display.Blog
{
    public partial class BlogLoadControl : System.Web.UI.UserControl
    {
        private string modulphu = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modulphu"] != null)
                modulphu = Request.QueryString["modulphu"];
            switch (modulphu)
            {
                case "ListBlog":
                    plLoadControl.Controls.Add(LoadControl("ListBlog.ascx"));
                    break;

                case "BlogDetail":
                    plLoadControl.Controls.Add(LoadControl("BlogDetail.ascx"));
                    break;

            }
        }
    }
}