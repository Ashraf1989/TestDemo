using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    [WebMethod]
    public static string LoadUserControl(string message)
    {
        using (Page page = new Page())
        {
            UserControl userControl = (UserControl)page.LoadControl("Message.ascx");
            (userControl.FindControl("lblMessage") as Label).Text = message;
            page.Controls.Add(userControl);
            using (StringWriter writer = new StringWriter())
            {
                page.Controls.Add(userControl);
                HttpContext.Current.Server.Execute(page, writer, false);
                return writer.ToString();
            }
        }
    }
}