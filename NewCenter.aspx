<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewCenter.aspx.cs" Inherits="NewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 400px; width: 800px">
    <h1 style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="註冊會員資料"></asp:Label>
    </h1>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            <asp:Label ID="Label2" runat="server" Text="帳號(UserName)："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Label ID="Label3" runat="server" Text="密碼(PassWord)："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Width="170px"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Label ID="Label4" runat="server" Text="再次輸入(Again)："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 0px" Width="170px"></asp:TextBox>
        </p>
        <p style="text-align: center">
            <asp:Label ID="Label5" runat="server" Text="英文名字(Name)："></asp:Label>
            &nbsp;<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" Text="確認註冊" OnClick="Button1_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="資料清除" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
