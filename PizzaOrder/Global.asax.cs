using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace PizzaOrder
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string fullOrigionalpath = Request.Url.ToString();
            Uri page = new Uri(fullOrigionalpath);

            switch (page.Segments.Last())
            {
                case "Info":
                    Context.RewritePath("/?page=info");
                    break;
                case "Register":
                    Context.RewritePath("/?page=reg");
                    break;
                case "Begin":
                    Context.RewritePath("/?page=begin");
                    break;
                case "Chronology":
                    Context.RewritePath("/?page=chron");
                    break;
                case "Discount":
                    Context.RewritePath("/?page=dis");
                    break;
                case "Login":
                    Context.RewritePath("/?page=login");
                    break;
                case "Orders":
                    Context.RewritePath("/?page=orders");
                    break;
                case "Offers":
                    Context.RewritePath("/?page=offers");
                    break;
                case "Admin":
                    Context.RewritePath("/?page=admin");
                    break;
                default:
                    break;
            }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}