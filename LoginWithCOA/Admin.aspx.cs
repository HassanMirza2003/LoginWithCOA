using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginWithCOA
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AccessLevel"] != null)
            {
                int accessLevel = Int32.Parse(Session["AccessLevel"].ToString());
                if (accessLevel !=1)
                {
                    switch(accessLevel)
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
            }
            else
            {
                Response.Redirect("./Logind.aspx");
            }
            LblName.Text = Session["UserName"].ToString();
        }
    }
}