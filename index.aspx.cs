using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //索引 microsoft.ace.oledb.12.0
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\ivy\\Documents\\WebTest.accdb");
        //打開檔案
        cn.Open();
        //查詢語法
        string StandSt = "SELECT * FROM Account WHERE ";
        //設置帳號和密碼的textbox查詢語法
        string StUserName = StandSt + "UserName = '" + TextBox1.Text + "'";
        string StPassWord = StandSt + "PassWord = '" + TextBox2.Text + "'";
        //新增連結查詢
        OleDbCommand cmd = new OleDbCommand(StUserName, cn);
        //閱讀該資料
        OleDbDataReader reader = cmd.ExecuteReader();
        //設bool值得到正確與否
        bool U = reader.Read();
        cmd = new OleDbCommand(StPassWord, cn);
        reader = cmd.ExecuteReader();
        bool P = reader.Read();
        //判斷中...
        
            if (U == true)
            {
                if (P == true)
                {
                    Response.Write("<Script language='JavaScript'>alert('帳號密碼正確');</Script>");
                    Response.Redirect("ShowData.aspx");
                }
                else
                {
                    Response.Write("<Script language='JavaScript'>alert('密碼錯誤');</Script>");
                }
            }
            else if (TextBox1.Text == "" || TextBox2.Text == "")
            {
                Response.Write("<Script language='JavaScript'>alert('資料輸入不完全');</Script>");
            }
            else
            {
                Response.Write("<Script language='JavaScript'>alert('帳號錯誤');</Script>");
            }
        cn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script>window.open('NewCenter.aspx');</script>");
    }
}
   