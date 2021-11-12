using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Offers : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind();
            if (Session["user"] == null)
            {
                Response.Redirect("/Login");
            }
            using (PizzaOrder entity = new PizzaOrder())
            {
                pizzaRepeater.DataSource = entity.Products.Where(x => x.ProductType == 1).ToList();// izkarva ot bazata produktite,koito imat productType == 1,toest picite
                pizzaRepeater.DataBind(); // prezarejda strani4kata i go izkarva na Front-End-a,tova s pizzata
                cokeRepeater.DataSource = entity.Products.Where(x => x.ProductType == 2).ToList();//izkarva ot bazata produktite,koito imat productType == 2,toest napitkit
                cokeRepeater.DataBind();
                hamburgerRepeater.DataSource = entity.Products.Where(x => x.ProductType == 3).ToList();//izkarva ot bazata produktite,koito imat productType == 3,burgerite
                hamburgerRepeater.DataBind();
            }
        }
    }
}