var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "esas-sehife",
    defaults: new {controller="Home",action="Index"}
);

app.Run();

