using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class DeleteData : System.Web.UI.Page
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

        if (Utest == true)
        {
            string test2 = "DELETE FROM Medicine WHERE 健保代碼 = " + TextBox9.Text;
            OleDbCommand cms = new OleDbCommand(test2, cn);
            cms.ExecuteNonQuery();
            Response.Write("<Script language='JavaScript'>alert('完成刪除');</Script>");
        }
        else
        {
            Response.Write("<Script language='JavaScript'>alert('沒有此筆資料');</Script>");
        }
        cn.Close();
    }
}