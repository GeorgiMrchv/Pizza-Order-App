using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Admin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind();

            using (PizzaOrder entity = new PizzaOrder())
            {
                orderRepeater.DataSource = entity.Orders.OrderByDescending(x => x.DateOrder).ToList();
                orderRepeater.DataBind();


            }

        }
    }
}