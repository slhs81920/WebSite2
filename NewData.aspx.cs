using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class NewData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\ivy\\Documents\\WebTest.accdb");
        OleDbDataReader reader;
        cn.Open();

        string test = "SELECT * FROM Medicine WHERE 健保代碼 = " + TextBox9.Text;
        OleDbCommand cmd = new OleDbCommand(test, cn);
        reader = cmd.ExecuteReader();
        bool Utest = reader.Read();

        if (Utest ==true)
            Response.Write("<Script language='JavaScript'>alert('已有資料,不能新增');</Script>");
        else
        {
            string test2 = "INSERT INTO Medicine ([健保代碼],[藥名(中文)],[藥名(英文)],[劑型],[顏色],[形狀],[用藥指示],[副作用]) " +
                "VALUES ('"+TextBox9.Text+"','"+TextBox10.Text+"','"+TextBox11.Text+"','"+TextBox12.Text+"','"+TextBox13.Text+"','"+
                    TextBox14.Text+"','"+TextBox15.Text+"','"+TextBox16.Text+"')";
            newww(test2);
        }
        cn.Close();
    }
    protected void newww(string newwww)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\ivy\\Documents\\WebTest.accdb");
        OleDbDataReader reader;
        OleDbCommand cmd = new OleDbCommand(newwww, cn);
        cn.Open();
        cmd.ExecuteNonQuery();
        Response.Write("<Script language='JavaScript'>alert('成功新增');</Script>");
    }
}