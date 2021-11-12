using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Registration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (PizzaOrder entity = new PizzaOrder())
            {
                int count = entity.UserDatas.Count(ct => ct.Email == TextBoxEmail.Text);
                if (count > 0) // nula poneve po golqmo zna4i 4e nqma zapis
                {
                    Label1.Visible = true;
                    Label1.Text = "Username already exists";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    return;

                }
                UserData usd = new UserData()
                {
                    Username = TextBoxUN.Text,
                    Email = TextBoxEmail.Text,
                    Password = TextBoxPass.Text,
                    DateAdded = DateTime.Now,
                    Neighbourhood = DropDownListHood.SelectedValue
                };

                entity.UserDatas.Add(usd);
                entity.SaveChanges();

            }

            Session["user"] = TextBoxUN.Text;

            MessageBox.Show(Page, "You have successfully registered!");
            Response.Redirect("/Info");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login");
        }
    }
}