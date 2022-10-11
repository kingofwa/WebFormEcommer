<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BlogDetail.ascx.cs" Inherits="Ecommer.cms.display.Blog.BlogDetail" %>
 <asp:PlaceHolder ID="plLoadControl" runat="server"></asp:PlaceHolder>



<div class="single-blog-wrapper">

        <!-- Single Blog Post Thumb -->
        <div class="single-blog-post-thumb">
            <img src="img/bg-img/bg-7.jpg" alt="">
        </div>

        <!-- Single Blog Content Wrap -->
        <div class="single-blog-content-wrapper d-flex">

            <!-- Blog Content -->
            <div class="single-blog--text">
                <h2><asp:Literal ID="ltrTieuDeTin" runat="server"></asp:Literal></h2>

                <asp:Literal ID="ltrDetailBlog" runat="server"></asp:Literal>
            </div>

            <!-- Related Blog Post -->
            <div class="related-blog-post">
                <!-- Single Related Blog Post -->
                <asp:Literal ID="ltrTicTucLienQuan" runat="server"></asp:Literal>
            </div>

        </div>
    </div>