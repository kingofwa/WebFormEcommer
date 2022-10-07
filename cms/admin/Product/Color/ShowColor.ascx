<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShowColor.ascx.cs" Inherits="Ecommer.cms.admin.Product.Color.ShowColor" %>
<div class="head">
    Các màu đã tạo. 
    <div class="fr ter"><a class="btThemMoi" href="/Admin.aspx?modul=Product&submodul=Color&handle=CreateNew">Thêm một màu mới</a></div>
    <div class="cb"></div>
</div>
<div class="KhungChuaBang">
   <table class="tbMau">
       <tr>
           <th class="cotMa">Mã</th>
           <th class="cotTen">Tên màu</th>
           <th class="cotCongCu">Công cụ</th>
       </tr>
       <asp:Literal ID="ltrMau" runat="server"></asp:Literal>
   </table>
</div>
<script type="text/javascript">
    function XoaMau(MauID) {
        if (confirm("Bạn chắc chắn muốn xóa màu này")) {
            //Viết code xóa màu tại đây

            $.post("cms/admin/Product/Color/Ajax/Mau.aspx",
                {
                    "ThaoTac": "XoaMau",
                    "MauID": MauID
                },
                function (data, status) {
                    //alert("Data :" + data + "\n Status :" + status);
                    if (data == 1) {
                        //thực hiện thành công => ẩn dòng vừa xóa đi
                        $("#maDong_" + MauID).slideUp();

                    }
                });
        }
    }
</script>