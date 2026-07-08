<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Taking_User_Input_from_Web_App.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="nameLabel" runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" Width="197px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
