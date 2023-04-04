<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_Sort.aspx.cs" Inherits="lap2_sql.Product_Sort" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Sắp xếp sản phẩm</h2>
            <p> 
                Sắp xếp theo tên:
                <asp:DropDownList ID="ddlSortName" runat="server" >
                    <asp:ListItem Text="A-Z" Value="A-Z"></asp:ListItem>
                    <asp:ListItem Text="Z-A" Value="Z-A"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <p>
                Sắp xếp theo giá:
                <asp:DropDownList ID="ddlSortPrice" runat="server" >
                    <asp:ListItem Text="Từ thấp đến cao" Value="Từ thấp đến cao"></asp:ListItem>
                    <asp:ListItem Text="Từ cao đến thấp" Value="Từ cao đến thấp"></asp:ListItem>
                </asp:DropDownList>
            </p>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br /> 
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="769px">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
        <asp:Label ID="lblProductCount" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
