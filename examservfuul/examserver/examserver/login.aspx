<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="examserver.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Login&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="93px"></asp:TextBox>
    <div>
    
        Password <asp:TextBox ID="TextBox2" runat="server" Width="94px"></asp:TextBox>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="186px" />
            <div>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
