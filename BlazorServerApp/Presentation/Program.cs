using Application.DependencyInjectionService;
using Application.Mapper;
using Infraestructure.DependencyInjectionService;
using MudBlazor.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddApplication();
builder.Services.AddInfraestruture();
builder.Services.AddMudServices();
builder.Services.AddHttpClient();
builder.Services.AddAutoMapper(Assembly.Load("Application"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
