using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string module = Request.QueryString["page"];
            LoadModule(!string.IsNullOrEmpty(module) ? module : "login");
        }

        public void LoadModule(string param)
        {
            switch (param)
            {              
                case "info":
                    UserControl info = (UserControl)LoadControl("/Modules/Information.ascx");
                    contentModule.Controls.Add(info);
                    break;
                case "reg":
                    UserControl reg = (UserControl)LoadControl("/Modules/Registration.ascx");
                    contentModule.Controls.Add(reg);
                    break;
                case "begin":
                    UserControl beg = (UserControl)LoadControl("/Modules/Beginning.ascx");
                    contentModule.Controls.Add(beg);
                    break;
                case "chron":
                    UserControl chron = (UserControl)LoadControl("/Modules/Chronology.ascx");
                    contentModule.Controls.Add(chron);
                    break;
                case "dis":
                    UserControl dis = (UserControl)LoadControl("/Modules/Discounts.ascx");
                    contentModule.Controls.Add(dis);
                    break;
                case "login":
                    UserControl login = (UserControl)LoadControl("/Modules/Login.ascx");
                    contentModule.Controls.Add(login);
                    break;
                case "orders":
                    UserControl orders = (UserControl)LoadControl("/Modules/Orders.ascx");
                    contentModule.Controls.Add(orders);
                    break;
                case "offers":
                    UserControl offers = (UserControl)LoadControl("/Modules/Offers.ascx");
                    contentModule.Controls.Add(offers);
                    break;
                case "admin":
                    UserControl admin = (UserControl)LoadControl("/Modules/Admin.ascx");
                    contentModule.Controls.Add(admin);
                    break;
                default:
                    break;
            }
        }

        
    }
}