using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PizzaOrder.Modules
{
    public partial class Orders : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.DataBind(); // zarejda stranicata
            if (Session["user"] == null)
            {
                Response.Redirect("/Login");
            }

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            using (PizzaOrder entity = new PizzaOrder())
            {
                decimal totalAmount = 0;

                if (Size.SelectedItem.Text.Split('-')[0].Contains("Small")) // ako nai lqvata 4ast ot slovosy4etanieto small - 1.22 e small kakvo da napravi
                {
                    totalAmount = entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeSmall;//vzema cenata 
                }
                else if (Size.SelectedItem.Text.Split('-')[0].Contains("Middle"))
                {
                    totalAmount = entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeMiddle;
                }
                else if (Size.SelectedItem.Text.Split('-')[0].Contains("Large"))
                {
                    totalAmount = entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeLarge;
                }

                string accout = Session["user"].ToString(); // vzemame sesiqta 

                Order order = new Order
                {
                    Username = accout, // nashivame sesiqta v username na tablicata v bazi4kata
                    Telephone = Convert.ToInt32(Telephone.Text), // da go zashiq ot string-a v int,poneje .Text iziskva string, a az slagam int
                    Category = Categories.SelectedItem.Text,
                    Product = Products.SelectedItem.Text,
                    Size = Size.SelectedItem.Text.Split('-')[0], // odrqzvame cqloto slovosu4etanie "razmer - cena" i chrez [0] kazvame 4e vzemame razmera.
                    TotalAmount = totalAmount,
                    Address = Address.Text,
                    DateOrder = DateTime.Now,
                    Comment = boxComment.Text
                };

                entity.Orders.Add(order); // zashivame v bazata ve4e suzdadeniq obekt
                entity.SaveChanges(); // zapazvame promenite v bazata
            }

            MessageBox.Show(Page, "Your order is confirmed!");


        }

        protected void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categories.SelectedIndex < 1) // ako ne e izbrana kategoriq da vrushta dokat bude izbrana
                return;

            Products.Items.Clear(); // iz4istva produktite vednuj kato gi nashtrakam,za da ne gi zarejda nanovo ako ne6to razcukam nqkoq druga opciq
            using (PizzaOrder entity = new PizzaOrder())
            {
                ListItem li = new ListItem(); // nashivame ru4no tova za da go izkarva nego po default,a ne edna ot opciite,koeto syzdava problem poneje
                li.Text = "Select Product";   //ako imenno 1 ot opciite izkarva po default nqma da moje da bude zashita v bazata
                li.Value = "0";              // tova e stoinostta na koq poziciq
                li.Selected = true;
                Products.Items.Add(li);    // zashiva q v list item-a 

                int cnt = 1;
                foreach (Product pr in entity.Products.Where(wr => wr.ProductType == Categories.SelectedIndex)) // obxojda se tablica "ProductType" i go zashiva v suotvetniq 
                {                                                                                               // dropdownlist
                    ListItem item = new ListItem(); //ru4no zashiva za vsqko edno pootdelno v item-a,pravi se poneje  po gore sme zashili Default-natoto i sega ostava tezi 
                    item.Text = pr.ProductName;    // da slojim vytre 
                    item.Value = cnt.ToString();  // tuka gi vurti +1 dokat ne stignat 3
                    Products.Items.Add(item);
                    cnt++;
                }
            }
            Products.DataBind(); //zarejda bazata vizualno na stranicata
        }

        protected void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Products.SelectedIndex < 1)  // sy6tata sxema kato s Categories_SelectedIndexChanged
                return;

            Size.Items.Clear();
            using (PizzaOrder entity = new PizzaOrder())
            {
                ListItem li = new ListItem();
               
                li.Text = "Select Size";
                li.Value = "0";
                li.Selected = true;
                Size.Items.Add(li);

                li = new ListItem();
                li.Text = (Categories.SelectedIndex == 2 ? "250ml - " : "Small - ") + entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeSmall + " lv."; // dobavq razmera pod ime i 
                li.Value = "1";                     // izvli4a 4rez entity cenata i gi konkatenira po tozi na4in polu4avame jelanie efekt bez da gazim pravilata
                Size.Items.Add(li);                 // dobavq obekta

                li = new ListItem();
                li.Text = (Categories.SelectedIndex == 2 ? "1l - " : "Middle - ") + entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeMiddle + " lv.";
                li.Value = "2"; // tuk sme zashili kategoriqta "ako" e ravna na "drinks" da izlizat litri/mililitri,ako li ne da izka4at razmeri 
                Size.Items.Add(li);

                li = new ListItem();
                li.Text = (Categories.SelectedIndex == 2 ? "2l - " : "Large - ") + entity.Products.First(wr => wr.ProductName == Products.SelectedItem.Text).ProductPrizeLarge + " lv.";
                li.Value = "3";
                Size.Items.Add(li);
            }
        }
    }
}