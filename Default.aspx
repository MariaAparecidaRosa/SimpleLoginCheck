<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_01.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>

            <table style="width:25%">
              <tr>
                <td>Login: </td>
                <td><asp:TextBox ID="txtLogin" runat="server" /><br /></td> 
              </tr>
              <tr>
                <td>Password: </td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /> <br /><br /></td>
              </tr>
            </table>

            <asp:Button ID="btnLogin" runat="server" Text="Login" />
        </div>
    </form>
</body>
</html>
