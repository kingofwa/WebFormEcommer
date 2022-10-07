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
                    Logo
                </div>
                <div class="accountMenu">
                    Thoong tin tai khoan
                </div>
            </div>
            <%--phan menu chinh--%>
            <div class="MenuChinh">
                <ul>
                    <li>
                        <a href="/Admin.aspx" title="Home">Home</a>
                        <a href="/Admin.aspx?modul=Product" title="Product">Product</a>
                        <a href="/Admin.aspx?modul=Account" title="Account">Account</a>

                        <a href="/Admin.aspx?modul=Advertisement" title="Advertisement">Advertisement</a>
                        <a href="/Admin.aspx?modul=News" title="News">News</a>

                        <a href="/Admin.aspx?modul=Custommer" title="Custommer">Custommer</a>
                        <a href="/Admin.aspx?modul=Menu" title="Menu">Menu</a>
                    </li>
                </ul>
            </div>
            <%--phan noi dung trang--%>
            <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
        </form>
    </body>

</html>
