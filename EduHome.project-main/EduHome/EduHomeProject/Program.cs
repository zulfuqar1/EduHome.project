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


//builder.Services.AddIdentity<AppUser, IdentityRole>(identityOptions =>
//{
//    identityOptions.User.RequireUniqueEmail = true;
//    identityOptions.Password.RequireNonAlphanumeric = true;
//    identityOptions.Password.RequiredLength = 8;
//    identityOptions.Password.RequireDigit = true;
//    identityOptions.Password.RequireLowercase = true;
//    identityOptions.Password.RequireUppercase = true;

//    identityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3);
//    identityOptions.Lockout.MaxFailedAccessAttempts = 5;
//    identityOptions.Lockout.AllowedForNewUsers = true;

//}).AddClaimsPrincipalFactory<AppDbContext>()
//.AddDefaultTokenProviders();

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