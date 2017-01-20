<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SiteCore.UI.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    </div>
    <div>
    
        <asp:GridView ID="GridView1" runat="server">
         
        </asp:GridView>
    


    </div>
    </form>
</body>
</html>
