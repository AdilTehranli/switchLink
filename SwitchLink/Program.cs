var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute(
    "default",
        "{controller=home}/{action=index}"
    );

app.MapControllerRoute(
    "contact",
   pattern: "contact-us",
    defaults:new {controller ="home",action="about"}
    );
app.Run();
