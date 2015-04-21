<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ModifyData.aspx.cs" Inherits="ModifyData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="修改"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="60px" Text="健保代碼"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="120px" Text="藥名(中文)"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="120px" Text="藥名(英文)"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="40px" Text="劑型"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="40px" Text="顏色"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Width="40px" Text="形狀"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Width="120px" Text="用藥指示"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Width="120px" Text="副作用"></asp:TextBox>&nbsp;&nbsp;
        <br />
        <br />
        <asp:TextBox ID="TextBox9" runat="server" Width="60px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server" Width="120px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox11" runat="server" Width="120px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox12" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox13" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox14" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox15" runat="server" Width="120px"></asp:TextBox>
&nbsp;&nbsp;<asp:TextBox ID="TextBox16" runat="server" Width="120px"></asp:TextBox>
        <p style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="確定" OnClick="Button1_Click" /></p>
    </div>
    </form>
</body>
</html>
