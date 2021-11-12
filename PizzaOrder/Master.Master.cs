using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind();

            if (Session["user"] == null)
            {
                Logout.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("/Login");
        }
    }
}