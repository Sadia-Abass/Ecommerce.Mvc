
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EasyClothes.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();
//var connectionString = builder.Configuration.GetConnectionString("EasyClothesContextConnection") ?? throw new InvalidOperationException("Connection string 'EasyClothesContextConnection' not found.");



// Add services to container
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();


//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
