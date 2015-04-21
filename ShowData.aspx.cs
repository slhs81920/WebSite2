using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;



public partial class NewData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=C:\\Users\\ivy\\Documents\\WebTest.accdb");
        cn.Open();
        string StandSt = "SELECT * FROM Medicine ";
        OleDbCommand cmd = new OleDbCommand(StandSt, cn);
        OleDbDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            ListBox1.Items.Add(reader["健保代碼"].ToString() + "＋" + reader["藥名(中文)"].ToString() + "＋" + reader["藥名(英文)"].ToString() + "＋" + reader["劑型"].ToString());
            ListBox2.Items.Add(reader["顏色"].ToString() + "＋" + reader["形狀"].ToString() + "＋" + reader["用藥指示"].ToString() + "＋" + reader["副作用"].ToString());
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("NewData.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteData.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModifyData.aspx");
    }
}