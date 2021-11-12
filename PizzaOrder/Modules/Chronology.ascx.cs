using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Chronology : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("/Login");
            }
            Page.DataBind();
            using (PizzaOrder entity = new PizzaOrder())
            {
                string session = Session["user"].ToString();
                orderRepeater.DataSource = entity.Orders.Where(x => x.Username == session).OrderByDescending(x => x.DateOrder).ToList();                
                orderRepeater.DataBind();
            } 



        }
    }
}