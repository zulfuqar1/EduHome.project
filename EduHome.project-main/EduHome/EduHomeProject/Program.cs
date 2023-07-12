using EduHome.Core.Entities;
using EduHome.DataAccess.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});


builder.Services.AddIdentity<AppUser,IdentityRole>(IdentityOptions =>
{
    IdentityOptions.User.RequireUniqueEmail = true;
    IdentityOptions.Password.RequireNonAlphanumeric = true;
    IdentityOptions.Password.RequiredLength = 8;
    IdentityOptions.Password.RequireDigit = true;
    IdentityOptions.Password.RequireLowercase = true;
    IdentityOptions.Password.RequireUppercase = true;

    IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
    IdentityOptions.Lockout.MaxFailedAccessAttempts = 5;
    IdentityOptions.Lockout.AllowedForNewUsers = true;

    });

var app = builder.Build();

app.UseStaticFiles();


app.MapControllerRoute(
     name: "areas",
     pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);



app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
);
app.Run();
