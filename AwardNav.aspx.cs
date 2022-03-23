using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab3
{
    public partial class AwardNav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASc(object sender, EventArgs e)
        {
            Response.Redirect("AwardScholaarshipaspx.aspx");
        }

        protected void AJ(object sender, EventArgs e)
        {
            Response.Redirect("AwardJob.aspx");
        }

        protected void AI(object sender, EventArgs e)
        {
            Response.Redirect("AwardInternship.aspx");
        }
    }
}