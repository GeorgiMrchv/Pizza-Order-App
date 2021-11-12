using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace PizzaOrder
{
public class Utils
{
    public static int PageSize = 20;
}

public static class MessageBox // Клас,който описва диалогов прозорец и вътре съответните методи свързани с него.
{
    /// <summary>
    /// Calls a javascript alert window
    /// </summary>
    /// <param name="Page">The page from which you call the MessageBox</param>
    public static void Show(Page Page, string Message) // Метод,при който се вика прозорче,което известява потребителя,че се регистрирал.
    {
        Page.ClientScript.RegisterStartupScript( // Това е един път кат се регистрира потребителя какво да прави
           Page.GetType(),                      // vrushta tip
           "MessageBox",                       //Това извиква Меседж бокса.
           "<script language='javascript'>alert('" + Message + "');</script>" //JavaScript функция,която изкарва прозорчето при регистрация.
        );
    }
}

}