<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Ecommer.Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="js/jquery-1.8.3.min.js"></script>
    <link href="cms/admin/css/cssAdmin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <div class="logo">
                <a href="/Admin.aspx">
                    <img src="pic/Logo/Logo_NS.jpg" />
                </a>
            </div>
            <div class="accountMenu">
                Hello:
                <asp:Literal ID="ltrTenDangNhap" runat="server"></asp:Literal>
                |<asp:LinkButton ID="lbtDangxuat" runat="server" OnClick="lbtDangxuat_Click">Logout</asp:LinkButton>

            </div>
        </div>
        <%--phan menu chinh--%>
        <div class="MenuChinh">
            <%-- <a href="/Admin.aspx" title="Home">Home</a>--%>
            <ul>
                <li><a class="<%=DanhDau("SanPham") %>" href="/Admin.aspx?modul=SanPham" title="SanPham">Sản Phẩm</a> </li>
                <li><a class="<%=DanhDau("TaiKhoan") %>" href="/Admin.aspx?modul=TaiKhoan" title="Account">Tài Khoản</a></li>
                <li><a class="<%=DanhDau("QuangCao") %>" href="/Admin.aspx?modul=QuangCao" title="Advertisement">Quảng Cáo</a></li>
                <li><a class="<%=DanhDau("Tintuc") %>" href="/Admin.aspx?modul=TinTuc" title="News">Tin Tức</a></li>
                <li><a class="<%=DanhDau("KhachHang") %>" href="/Admin.aspx?modul=KhachHang" title="Custommer">Khách Hàng</a></li>
                <li><a class="<%=DanhDau("Menu") %>" href="/Admin.aspx?modul=Menu" title="Menu">Menu</a></li>
            </ul>      
        </div>
        <%--phan noi dung trang--%>
        <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
    </form>
</body>

</html>
