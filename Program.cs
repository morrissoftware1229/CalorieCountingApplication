using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using CalorieCountingApplication.Models;

//Need to add SeeDailyLog View and logic
//Need to add migrations
//Need to add logic for Entries controller to push PostItem to DB
//Need to add default form for Entries/AddItem before onChange to Select element

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<CalorieCountingApplicationContext>(item => item.UseSqlServer(configuration.GetConnectionString("ProductionDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
