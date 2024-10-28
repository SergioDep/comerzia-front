namespace EventMasterSoftWA
{
    public static class AuthConfig
    {
        public static readonly string[] PublicRoutes =
        { /* Add public routes here */
            "/login/something"
        };

        // TODO: Refactor The Name, these are not required routes, but routes that are used for authentication
        public static readonly string[] AuthenticationRoutes =
        {
            "/login",
            "/register",
            "/forgot-password",
            "/reset-password"
        };

        public static readonly string ApiAuthPrefix = "/api/auth";
        public static readonly string DefaultAuthenticatedRedirect = "/";
    }
}
