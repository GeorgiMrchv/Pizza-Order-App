using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind();
            if (Session["userRemember"] != null) // "ako ima potrebitel kakvo da napravq"
            {
                Response.Redirect("/Info");  //"zashivai go kum modul info"
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (PizzaOrder entity = new PizzaOrder())
            {
                int count = entity.UserDatas.Count(ct => !ct.IsAdmin && ct.Username == UsernameBox.Text && ct.Password == PasswordBox.Text);
                int admin = entity.UserDatas.Count(ad => ad.IsAdmin && ad.Username == UsernameBox.Text && ad.Password == PasswordBox.Text);
                //naro4no nashivam i username i pass za da ima baza za sravnenie s napisanoto ot men 1 vid tova koeto sum napisal dali e adminski profil ili ne
                //Moje i da se zashi bez ad.Password == PasswordBox.Text,no ako ima 2ma admini s 1 i su6to ime no razli4ni paroli,2riq admin moje da vleze pri 1vi 
                //bez da mu zn pass
                if (count > 0)
                {
                    Session["user"] = UsernameBox.Text;

                    MessageBox.Show(Page, "You are Logged in!");
                    Response.Redirect("/Info");
                }
                else if (admin > 0)
                {
                    Response.Redirect("/Admin");
                    Session["user"] = UsernameBox.Text;
                    MessageBox.Show(Page, "You are Logged in!");
                }
                else
                {
                    Response.Write("Wrong account or password !");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("/Register");

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRemember.Checked) // "Ako e aktiviran chekbox-a kakvo da napravq ?!"
                Session["userRemember"] = true; // "ami aktivizirai sesiqta"
        }
    }
}