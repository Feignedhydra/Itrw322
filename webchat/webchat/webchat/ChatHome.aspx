<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChatHome.aspx.cs" Inherits="webchat.ChatHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 523px">
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox4" runat="server" BorderColor="Black" Width="167px">Enter your name here</asp:TextBox>
    
    </div>
        <p style="width: 100px">
            IP Address:</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black"></asp:TextBox>
        </p>
        <p>
            Port:</p>
        <p style="width: 133px">
            <asp:TextBox ID="TextBox2" runat="server" BackColor="White" BorderColor="Black"></asp:TextBox>
        </p>
        <p style="width: 133px">
            <asp:Button ID="Button1" runat="server" BackColor="#99FF33" BorderColor="Black" OnClick="Button1_Click" Text="Connect" />
        </p>
        <p style="width: 133px">
            <asp:TextBox ID="TextBox3" runat="server" BorderColor="Black" Height="50px" Width="646px"></asp:TextBox>
        </p>
        <asp:Button ID="Button3" runat="server" BackColor="Lime" BorderColor="Black" OnClick="Button3_Click" Text="Send" />
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server" Height="79px" Width="642px"></asp:TextBox>
    </form>
</body>
</html>
