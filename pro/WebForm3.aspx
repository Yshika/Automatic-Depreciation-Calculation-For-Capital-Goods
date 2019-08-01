<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="pro.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Record</title>
    <style>
        body{
            background-color:cadetblue;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
            <br />
            <asp:Label ID="Label1" runat="server" Text=" Account Code of Assests " BorderColor="Black" BorderStyle="None" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox17" runat="server" BorderStyle="Solid"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="Label21" runat="server" Font-Bold="True" Font-Size="Large" Text="Account Code of Name of Assests" BorderStyle="None"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox18" runat="server" BorderStyle="Solid"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label22" runat="server" Text="Closing Value" Font-Bold="True"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox19" runat="server" OnTextChanged="TextBox19_TextChanged" BorderStyle="Solid"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update Record" Font-Bold="True" Width="136px" BorderStyle="Dotted" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BorderStyle="Dotted" Font-Bold="True" OnClick="Button2_Click" Text="Home Page" />
            <br />
        </div>
    </form>
</body>
</html>
