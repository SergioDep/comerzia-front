using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventMasterSoftWA
{
    public partial class EventMasterSoft : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Url.AbsolutePath.EndsWith("Login.aspx")) // Cambia "Login.aspx" al nombre de tu página de login
            {
                mainNavbar.Visible = false;
                sidebar.Visible = false;
            }
        }
    }
}