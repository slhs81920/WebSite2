<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowData.aspx.cs" Inherits="NewData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 400px; width: 800px">
        <h1 style="text-align: center"><asp:Label ID="Label1" runat="server" style="text-align: center" Text="藥品資料SHOW"></asp:Label></h1>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="60px" Text="健保代碼"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="60px" Text="藥名(中文)"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="60px" Text="藥名(英文)"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Width="60px" Text="劑型"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="60px" Text="顏色"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Width="60px" Text="形狀"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Width="60px" Text="用藥指示"></asp:TextBox>&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Width="60px" Text="副作用"></asp:TextBox>&nbsp;&nbsp;
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="200px" Width="305px"></asp:ListBox>&nbsp;&nbsp;
&nbsp;<asp:ListBox ID="ListBox2" runat="server" Height="200px" Width="305px"></asp:ListBox>
        <br />
        <br />
    
        <p style="text-align: center">
        <asp:Button ID="Button1" runat="server" Text="新增" OnClick="Button1_Click" />
    
    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="刪除" OnClick="Button2_Click" />
        　<asp:Button ID="Button3" runat="server" Text="修改" OnClick="Button3_Click" />
    </p>
    </div>
    </form>
</body>
</html>
