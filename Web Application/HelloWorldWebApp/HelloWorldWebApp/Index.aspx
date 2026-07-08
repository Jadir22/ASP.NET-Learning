<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HelloWorldWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Hello Software Engineers!</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click" />
            <asp:Label ID="showMessageLabel" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
