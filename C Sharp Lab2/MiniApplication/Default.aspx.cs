using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniApplication
{
    public partial class _Default : Page
    {
        protected void Page_PreInit(Object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonNext_Click(object sender, EventArgs e)
        {
            Session["Name"] = TextBox1.Text;
            Response.Redirect("Welcome.aspx");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}