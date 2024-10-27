using System;
using System.Text.RegularExpressions;
using System.Web;

namespace EventMasterSoftWA
{
    public static class RouteConfig
    {
        public static readonly string[] PublicRoutes = { };
        public static readonly string[] AuthRoutes = { "/login", "/register", "/forgot-password", "/reset-password" };
        public static readonly string ApiAuthPrefix = "/api/auth";
        public static readonly string DefaultLoggedInRedirect = "/";
    }
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var context = HttpContext.Current;

            if (context.Request.Path == "/App/_404.aspx")
            {
                return;
            }

            var requestedPath = context.Request.RawUrl.ToLower();

            var ignoreStaticFilesPattern = new Regex(@"\/((?!.+\.[\w]+$|public).*)");

            if (!IsCompleteMatch(ignoreStaticFilesPattern, requestedPath))
            {
                return;
            }

            if (requestedPath.StartsWith(RouteConfig.ApiAuthPrefix))
            {
                return;
            }

            // Example user session check (replace with actual auth check logic)
            bool userIsAuthenticated = context.Session != null && context.Session["User"] != null;

            bool isPublicRoute = Array.Exists(RouteConfig.PublicRoutes, route => requestedPath.Equals(route, StringComparison.OrdinalIgnoreCase));
            bool isAuthRoute = Array.Exists(RouteConfig.AuthRoutes, route => requestedPath.Equals(route, StringComparison.OrdinalIgnoreCase));

            if (isAuthRoute)
            {
                if (userIsAuthenticated)
                {
                    context.Response.Redirect(RouteConfig.DefaultLoggedInRedirect);
                }
            }
            else if (!isPublicRoute)
            {
                if (!userIsAuthenticated)
                {
                    context.Response.Redirect("/login");
                }
            }
        }

        protected static bool IsCompleteMatch(Regex regex, string input)
        {
            Match match = regex.Match(input);
            return match.Success && match.Index == 0 && match.Length == input.Length;
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}