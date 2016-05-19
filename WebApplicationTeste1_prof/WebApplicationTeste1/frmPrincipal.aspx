<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrincipal.aspx.cs" Inherits="WebApplicationTeste1.frmPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="cmdOK" runat="server" OnClick="cmdOK_Click" Text="OK" />
        <asp:Label ID="lblMensagem" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="grdDados" runat="server">
        </asp:GridView>
        <asp:Button ID="cmdDados" runat="server" OnClick="cmdDados_Click" Text="Dados" />
    
    </div>
    </form>
</body>
</html>
