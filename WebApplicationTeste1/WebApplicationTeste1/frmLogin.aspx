<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="WebApplicationTeste1.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 23%;
        }
        .auto-style2 {
        }
        .auto-style3 {
            width: 63px;
        }
        .auto-style4 {
            width: 83px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblUsuario" runat="server" Text="Usuário:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="cmdOK" runat="server" OnClick="cmdOK_Click" Text="OK" Width="100%" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="chkLembrar" runat="server" Text="Lembrar meu usuário." />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
