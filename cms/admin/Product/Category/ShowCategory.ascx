<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowCategory.ascx.cs" Inherits="Ecommer.cms.admin.Product.Category.ShowCategory" %>
<div class="head">
    Các danh mục sản phẩm đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=Product&submodul=Category&handle=CreateNew">Thêm mới danh mục</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbDanhMuc">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên danh mục</th>
           <th class="cotAnh">Ảnh đại diện</th>
           <th class="cotThuTu">Thứ tự</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrDanhMuc" runat="server"></asp:Literal>
   </table>
</div>

<script type="text/javascript">
    debugger
    function XoaDanhMuc(MaDM)
    {
        if(confirm("Bạn chắc chắn muốn xóa danh mục này"))
        {
            debugger
            //Viết code xóa danh mục tại đây
            $.post("cms/admin/Product/Category/Ajax/CategoryAjax.aspx",
                {
                    "ThaoTac":"XoaDanhMuc",
                    "MaDM": MaDM
                },
                function (data, status)
                {
                    //alert("Data :" + data + "\n Status :" + status);
                    if(data==1)
                    {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MaDM).slideUp();

                    }
                });
        }
    }
</script>
