using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommer.cms.admin.Product
{
    public partial class ProductLoadControl : System.Web.UI.UserControl
    {
        private string submodul = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["submodul"] != null)
                submodul = Request.QueryString["submodul"];
            switch (submodul)
            {
                case "Category":
                    plProductLoadControl.Controls.Add(LoadControl("Category/CategoryLoadControl.ascx"));
                    break;

                case "Color":
                    plProductLoadControl.Controls.Add(LoadControl("Color/ColorLoadControl.ascx"));
                    break;

                case "Ingredient":
                    plProductLoadControl.Controls.Add(LoadControl("Ingredient/IngredientLoadControl.ascx"));
                    break;

                case "Size":
                    plProductLoadControl.Controls.Add(LoadControl("Size/SizeLoadControl.ascx"));
                    break;

                case "Products":
                    plProductLoadControl.Controls.Add(LoadControl("Products/ProductsLoadControl.ascx"));
                    break;

                case "GroupProduct":
                    plProductLoadControl.Controls.Add(LoadControl("GroupProduct/GroupProductLoadControl.ascx"));
                    break;

                case "Auction":
                    plProductLoadControl.Controls.Add(LoadControl("Auction/AuctionLoadControl.ascx"));
                    break;

                case "Oder":
                    plProductLoadControl.Controls.Add(LoadControl("Oder/OderLoadControl.ascx"));
                    break;

                default:
                    plProductLoadControl.Controls.Add(LoadControl("Products/ProductsLoadControl.ascx"));
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nameModul"></param>
        /// <param name="nameSubmodul"></param>
        /// <param name="nameHandle"></param>
        /// <returns></returns>
        protected string DanhDau(string nameModul, string nameSubmodul, string nameHandle)
        {
            string s = "";

            /*Lấy giá trị querystring modul, modulphu, thaotac*/
            string modul = "";
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];

            string submodul = "";
            if (Request.QueryString["submodul"] != null)
                submodul = Request.QueryString["submodul"];

            string handles = "";
            if (Request.QueryString["handle"] != null)
                handles = Request.QueryString["handle"];

            /*So sánh nếu querystring bằng tên modul, modulphu, thaotac truyền vào thì trả về current --> đánh dấu là menu hiện tại*/
            if (modul == nameModul && submodul == nameSubmodul && handles == nameHandle)
                s = "current";
            return s;
        }
    }
}