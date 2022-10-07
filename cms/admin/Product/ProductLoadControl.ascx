<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProductLoadControl.ascx.cs" Inherits="Ecommer.cms.admin.Product.ProductLoadControl" %>
<div class="container">
    <div style="clear:both;height:20px"></div>
    <div class="cotTrai">
        <div class="head">
            Quản lý
        </div>
        <ul>
            <li><a class="<%=DanhDau("Product","Category","") %>" href="Admin.aspx?modul=Product&submodul=Category">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Products","") %>" href="Admin.aspx?modul=Product&submodul=Products">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Color","") %>" href="Admin.aspx?modul=Product&submodul=Color">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Ingredient","") %>" href="Admin.aspx?modul=Product&submodul=Ingredient">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Size","") %>" href="Admin.aspx?modul=Product&submodul=Size">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","GroupProduct","") %>" href="Admin.aspx?modul=Product&submodul=GroupProduct">Nhóm Sản Phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Auction","") %>" href="Admin.aspx?modul=Product&submodul=Auction">Phiên đấu giá</a></li>
            <li><a class="<%=DanhDau("Product","Oder","") %>" href="Admin.aspx?modul=Product&submodul=Oder">Đơn hàng</a></li>
        </ul>
        <div class="head">
            Thêm mới
        </div>
        <ul>
            <li><a class="<%=DanhDau("Product","Category","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Category&handle=CreateNew">Danh mục sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Products","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Products&handle=CreateNew">Danh sách sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Color","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Color&handle=CreateNew">Màu sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Ingredient","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Ingredient&handle=CreateNew">Chất liệu sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Size","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Size&handle=CreateNew">Size sản phẩm</a></li>
            <li><a class="<%=DanhDau("Product","GroupProduct","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=GroupProduct&handle=CreateNew">Nhóm Sản Phẩm</a></li>
            <li><a class="<%=DanhDau("Product","Auction","CreateNew") %>" href="Admin.aspx?modul=Product&submodul=Auction&handle=CreateNew">Phiên đấu giá</a></li>
        </ul>
    </div>
    <div class="cotPhai">
        <asp:PlaceHolder ID="plProductLoadControl" runat="server"></asp:PlaceHolder>
    </div>
    <div class="cb"></div>

</div>



