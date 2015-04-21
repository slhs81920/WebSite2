<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteData.aspx.cs" Inherits="DeleteData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="刪除"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="60px" Text="健保代碼"></asp:TextBox>&nbsp;&nbsp;

        <br />
        <br />
        <asp:TextBox ID="TextBox9" runat="server" Width="60px"></asp:TextBox>
        <p style="text-align:center">
            <asp:Button ID="Button1" runat="server" Text="確定" OnClick="Button1_Click" /></p>
    </div>
    </form>
</body>
</html>
