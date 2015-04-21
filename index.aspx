<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="height: 420px; width: 820px">
    <div style="height: 400px; width: 800px">
    
        <h1 style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="測試資料庫"></asp:Label>
        </h1>
        <p style="text-align: center">
            &nbsp;</p>
        <h3 style="text-align: center">帳號登入</h3>
        <p style="text-align: center">
            <asp:Label ID="Label2" runat="server" Text="帳號(UserName)："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Label ID="Label3" runat="server" Text="密碼(PassWord)："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Width="170px"></asp:TextBox>
        </p>

        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" />
        &nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="註冊" OnClick="Button2_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="詳查" />
&nbsp;
            </p>

    </div>
    </form>
</body>
</html>
