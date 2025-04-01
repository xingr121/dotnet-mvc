using foody.Data;
using foody.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var modelBuilder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = modelBuilder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
modelBuilder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
modelBuilder.Services.AddDatabaseDeveloperPageExceptionFilter();

modelBuilder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
modelBuilder.Services.AddControllersWithViews();

var app = modelBuilder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ingredient}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
