<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ViewState_Web_Application_in_C_.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 221px;
            text-align: right;
        }
        .auto-style2 {
            width: 221px;
            height: 33px;
            text-align: right;
        }
        .auto-style3 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="nameLabel" runat="server" Text="Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="nameTextBox" runat="server" Width="193px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style3">
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
                        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Output:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="outputTextBox" runat="server" ReadOnly="True" Width="188px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
