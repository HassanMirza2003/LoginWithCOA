using AppProps;
using BusinessLogicLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWithCOA
{
    public partial class Logind : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Email = TxtEmail.Text,
                Password = TxtPass.Text,
            };
            UserBll userBll = new UserBll();
            DbCon db = new DbCon();
            db.OpenConnection();
            SqlDataReader rdr = db.SrchByReader(userBll.LoginUserBll(user));
            if(rdr.HasRows)
            {
                if(rdr.Read())
                {
                    Session["UserId"] = rdr["Id"].ToString();
                    Session["UserName"] = rdr["Name"].ToString();
                    Session["AccessLevel"] = rdr["AccessLevel"].ToString();
                    int accessLevel = Int32.Parse(Session["AccessLevel"].ToString());
                   // db.OpenConnection();
                        switch (accessLevel)
                        {
                            case 2:
                                Response.Redirect("./Employee.aspx");
                                break;
                            case 3:
                                Response.Redirect("./Client.aspx");
                                break;
                            default:
                                Response.Redirect("./Logind.aspx");
                                break;

                        }
                    }


                else
                {
                    LblRes.Text = "User found data not readable";
                    db.CloseConnection();
                }
            }
            else
            {
                LblRes.Text = "User Not Found: Email or Password is incorrect";
            }
            db.CloseConnection();

        }
    }
}