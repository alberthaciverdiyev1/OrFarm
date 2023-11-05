//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Routing;

//public class RouteConfig
//{
//    public static void ConfigureRoutes(IRouteBuilder routes)
//    {
//        routes.MapControllerRoute(
//            name: "Login",
//            pattern: "Account/Login/{action=Index}",
//            defaults: new { controller = "Login" });

//        routes.MapControllerRoute(
//            name: "Logout",
//            pattern: "Account/Logout/{action=Index}/{id?}",
//            defaults: new { controller = "Logout" });

//        routes.MapControllerRoute(
//            name: "Register",
//            pattern: "Account/Register/{action=Index}/{id?}",
//            defaults: new { controller = "Register" });

//        routes.MapControllerRoute(
//            name: "Default",
//            pattern: "{controller=Home}/{action=Index}/{id?}",
//            defaults: new { controller = "Home", action = "Index" });
//    }
//}
