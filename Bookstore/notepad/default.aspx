<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Bookstore.notepad._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Telis Cosmas - Azure Microsoft</title>


</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Width="698px" Height="255px"></asp:TextBox>
        <asp:HyperLink ID="hyp" NavigateUrl="~/notepad/note" runat="server" Text="Notes" Target="_blank"></asp:HyperLink>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="go" BackColor="#0099FF" BorderColor="#3399FF" BorderStyle="Outset" Font-Bold="True" Font-Italic="True" Font-Names="Arial" ForeColor="White" />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
       
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" ForeColor="#0033CC"></asp:Label>
                <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" CellPadding="3" GridLines="Vertical" AllowSorting="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:BookStoreConnectionString %>" ProviderName="System.Data.SqlClient" SelectCommand=""></asp:SqlDataSource>

            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
