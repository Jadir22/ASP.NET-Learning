<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Taking_User_Input_from_Web_App.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="nameTextBox" runat="server" Width="223px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="displayButton" runat="server" Text="Display" />
            <asp:Label ID="nameLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
