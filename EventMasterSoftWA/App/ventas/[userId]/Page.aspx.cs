using System;
using System.Collections.Generic;
using System.Web;

namespace EventMasterSoftWA.App.ventas._userId_
{
    public partial class Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var parameters =
                (Dictionary<string, string>)HttpContext.Current.Items["RouteParameters"];
            if (parameters != null && parameters.ContainsKey("userId"))
            {
                string userId = parameters["userId"];

                Response.Write($"<h1>User ID: {userId}</h1>");
            }
        }
    }
}
