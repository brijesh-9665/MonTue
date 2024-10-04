using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using MonTue.Interfaces;
using MonTue.Models;
using MonTue.Services;
using MonTue.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation(emp=>emp.RegisterValidatorsFromAssemblyContaining<Employee>());
builder.Services.AddSingleton<IEmployeeService,EmployeeService>();


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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // Attribute-based routing
});

/*
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Employee}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Index",
    pattern: "EmployeeIndex",
    defaults: new {Controller="Employee",Action="Index"} );

app.MapControllerRoute(
    name:"Error",
    pattern:"RedirectToErrorPage",
    defaults: new {Controller="Employee",Action="ErrorPage"}
    );*/




app.Run();
