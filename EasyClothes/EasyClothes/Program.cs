
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EasyClothes.Areas.Identity.Data;
using EasyClothes.Services.Interfaces;
using EasyClothes.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EasyClothesConnection") ?? throw new InvalidOperationException("Connection string 'EasyClothesConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();
//var connectionString = builder.Configuration.GetConnectionString("EasyClothesContextConnection") ?? throw new InvalidOperationException("Connection string 'EasyClothesContextConnection' not found.");

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ISubcaegoryRepository, SubcategoryRepository>();

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
