using Departmanlar.Models;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

//3
builder.Services.AddControllersWithViews();




//Sql baðlama
builder.Services.AddDbContext<Context>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("sqlCon"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//1
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//2
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=depart}/{action=Index}/{id?}");

app.Run();
