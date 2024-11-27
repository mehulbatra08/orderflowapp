using OrderFlowApp.Components;
using OrderFlowApp;
using OrderFlowApp.Models;
using MudBlazor.Services;
using Microsoft.EntityFrameworkCore; //Add this
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices(); //Add here
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=Orders.db")); 
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<ProductService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
