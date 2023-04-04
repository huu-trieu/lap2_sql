<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Add(StoreProcedure).aspx.cs" Inherits="lap2_sql.Product_Add_StoreProcedure_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Product</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; THÊM SẢN PHẨM</h1>
            <table>
                <tr>
                    <td>Tên SP:</td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Đường dẫn hình:</td>
                    <td><asp:TextBox ID="txtPath" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Giá SP:</td>
                    <td><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mô tả:</td>
                    <td><asp:TextBox ID="txtDescript" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mã loại :</td>
                    <td><asp:TextBox ID="txtIDCat" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" /></td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" DataKeyNames="MaSP" DataSourceID="SqlDataSource1" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="MaSP" HeaderText="MaSP" ReadOnly="True" SortExpression="MaSP" />
                    <asp:BoundField DataField="TenSP" HeaderText="TenSP" SortExpression="TenSP" />
                    <asp:BoundField DataField="DuongDan" HeaderText="DuongDan" SortExpression="DuongDan" />
                    <asp:BoundField DataField="Gia" HeaderText="Gia" SortExpression="Gia" />
                    <asp:BoundField DataField="MoTa" HeaderText="MoTa" SortExpression="MoTa" />
                    <asp:BoundField DataField="MaLoai" HeaderText="MaLoai" SortExpression="MaLoai" />
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
          
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:QL_DTDD1ConnectionString %>" 
    InsertCommand="sp_InsertSanPham" 
    InsertCommandType="StoredProcedure">
    <InsertParameters>
        <asp:Parameter Name="TenSP" Type="String" />
        <asp:Parameter Name="DuongDan" Type="String" />
        <asp:Parameter Name="Gia" Type="Double" />
        <asp:Parameter Name="MoTa" Type="String" />
        <asp:Parameter Name="MaLoai" Type="Int32" />
    </InsertParameters>
</asp:SqlDataSource>
            
        </div>
    </form>
</body>
</html>
