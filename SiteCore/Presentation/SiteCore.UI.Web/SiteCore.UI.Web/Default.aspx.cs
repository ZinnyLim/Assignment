using SiteCore.UI.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteCore.UI.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SubscriberUserProcess process = new SubscriberUserProcess();
            GridView1.DataSource = process.GetSubscriber();
            GridView1.DataBind(); 

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}