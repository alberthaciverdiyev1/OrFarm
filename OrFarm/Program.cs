var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//      name: "areas",
//      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
//    );
//    endpoints.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//});
app.UseEndpoints(endpoints =>
{
    // Account Folder
    endpoints.MapControllerRoute(
        name: "Login",
        pattern: "Login/{action=Index}",
        defaults: new { controller = "Login" });

    endpoints.MapControllerRoute(
        name: "Logout",
        pattern: "Logout/{action=Index}",
        defaults: new { controller = "Logout" });

    endpoints.MapControllerRoute(
        name: "Register",
        pattern: "Register/{action=Index}",
        defaults: new { controller = "Register" });

    // WishList Folder
    endpoints.MapControllerRoute(
         name: "WishList",
         pattern: "Wishlist/{action=Index}",
         defaults: new { controller = "Wishlist" });

    //Shop Folder
    endpoints.MapControllerRoute(
     name: "Shop",
     pattern: "Shop/{action=Index}",
     defaults: new { controller = "Shop" });

    //Blog Folder
    endpoints.MapControllerRoute(
     name: "Blog",
     pattern: "Blog/{action=Index}",
     defaults: new { controller = "All" });

    //AboutUs Folder
    endpoints.MapControllerRoute(
      name: "AboutUs",
      pattern: "About-Us/{action=Index}",
      defaults: new { controller = "AboutUs" });

    //ContactUS Folder
    endpoints.MapControllerRoute(
      name: "ContactUs",
      pattern: "Contact-Us/{action=Index}",
      defaults: new { controller = "ContactUs" });

    //First HOME PAGE
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});



app.Run();
