using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class Lab3Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Musername"] != null)
            {
                Label1.Text = Session["Musername"].ToString();
            }
            if (Session["Susername"] != null)
            {
                Label1.Text = Session["Susername"].ToString();
            }
        }
    }
}