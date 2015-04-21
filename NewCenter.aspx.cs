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
        
        
        try
        {
            string StandSt = "SELECT * FROM Account WHERE ";
            string StUserName = StandSt + "UserName = '" + TextBox1.Text + "'";
            string StPassWord = StandSt + "PassWord = '" + TextBox2.Text + "'";
            string StEngName = StandSt + "EnglishName = '" + TextBox4.Text + "'";

            OleDbCommand cmd = new OleDbCommand(StUserName, cn);
            reader = cmd.ExecuteReader();
            bool U = reader.Read();

            cmd = new OleDbCommand(StPassWord, cn);
            reader = cmd.ExecuteReader();
            bool P = reader.Read();

            cmd = new OleDbCommand(StEngName, cn);
            reader = cmd.ExecuteReader();
            bool Q = reader.Read();

            bool TNnew;
            //檢查輸入之任何資料
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "")
            {
                Response.Write("<Script language='JavaScript'>alert('資料輸入不完全哦');</Script>");
            }
                else if (TextBox2.Text != TextBox3.Text)
            {
                Response.Write("<Script language='JavaScript'>alert('兩次密碼不一致哦');</Script>");
            }
            else
            {
                if (U == false && Q == false)
                {
                    TNnew = true;
                }
                else
                {
                    if (U == true && Q == true)
                    {
                        TNnew = false;
                        Response.Write("<Script language='JavaScript'>alert('帳號和名字重複');</Script>");
                    }
                    else if (Q == true)
                    {
                        TNnew = false;
                        Response.Write("<Script language='JavaScript'>alert('英文名字重複');</Script>");
                    }
                    else
                    {
                        TNnew = false;
                        Response.Write("<Script language='JavaScript'>alert('帳號重複');</Script>");
                    }
                }
            }
            //新增資料
            string IntoData = "INSERT INTO Account ([UserName]" + ",[PassWord]" + ",[EnglishName]) "
            + "VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "')"; //T_SQL 插入語法
            cmd = new OleDbCommand(IntoData, cn);
            cmd.ExecuteNonQuery();
        }
        catch
        {

        }
        finally
        {
            cn.Close();        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
    }
}