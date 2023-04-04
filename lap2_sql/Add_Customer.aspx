<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Customer.aspx.cs" Inherits="lap2_sql.Add_Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        h1 {
            font-size: 20px;
            color: red;
             margin-left: 360px;
         }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="color:red; font-size:20px;">Thêm khách hàng mới</div>
        <br />
        <table>
            <tr>
                <td>Mã KH:</td>
                <td><asp:TextBox ID="txtMaKH" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Tên KH:</td>
                <td><asp:TextBox ID="txtTenKH" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Điện thoại:</td>
                <td><asp:TextBox ID="txtDienThoai" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Giới tính:</td>
                <td>
                    <asp:RadioButtonList ID="rdlGioiTinh" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="Nam">Nam</asp:ListItem>
                        <asp:ListItem Value="Nu">Nữ</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Sở thích:</td>
                <td>
                    <asp:DropDownList ID="ddlSoThich" runat="server">
                        <asp:ListItem Value="Gym">Gym</asp:ListItem>
                        <asp:ListItem Value="Music">Music</asp:ListItem>
                        <asp:ListItem Value="Read Book">Read Book</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Mật khẩu:</td>
                <td><asp:TextBox ID="txtMatKhau" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnThemMoi" runat="server" Text="Thêm mới" OnClick="btnThemMoi_Click" /><asp:Label ID="lblThongBao" runat="server" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr>
                <td></td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
