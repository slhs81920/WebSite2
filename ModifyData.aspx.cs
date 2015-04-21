using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class ModifyData : System.Web.UI.Page
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

        if (Utest == false)
            Response.Write("<Script language='JavaScript'>alert('沒有資料,不能修改');</Script>");
        else
        {
            //string test2 = "UPDATE Medicine SET 健保代碼=" + TextBox9.Text + ",藥名(中文)=" + TextBox10.Text + ",藥名(英文)=" +
                //TextBox11.Text + ",劑型=" + TextBox12.Text + ",顏色=" + TextBox13.Text + ",形狀=" + TextBox14.Text + ",用藥指示=" + 
                //TextBox15.Text + ",副作用=" + TextBox16.Text + " WHERE 健保代碼=" + TextBox9.Text;
            string test2 = "UPDATE Medicine SET 藥名(中文)=@" + TextBox10.Text + "WHERE 健保代碼=@" + TextBox9.Text;
            cmd = new OleDbCommand(test2, cn);
            cmd.ExecuteNonQuery();
            Response.Write("<Script language='JavaScript'>alert('完成更新');</Script>");
        }
        cn.Close();
    }
}