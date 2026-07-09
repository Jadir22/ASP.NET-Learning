<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="User_Define_Type_In_C_.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 154px;
            text-align: right;
        }
        .auto-style2 {
            width: 154px;
            height: 27px;
            text-align: right;
        }
        .auto-style3 {
            height: 27px;
        }
        .auto-style5 {
            width: 5px;
        }
        .auto-style6 {
            width: 104px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Middle Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="middleNameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Last Name:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="lastNameTextBox" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
                    <asp:Button ID="getFullButton" runat="server" OnClick="getFullButton_Click" Text="Get Full Name" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:ListBox ID="fullNameListBox" runat="server" style="margin-left: 0px" Width="206px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
