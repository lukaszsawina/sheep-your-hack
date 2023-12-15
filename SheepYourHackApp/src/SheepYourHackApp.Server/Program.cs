using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SheepYourHackApp.Server.Data;
using SheepYourHackHosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlite(builder.Configuration.GetConnectionString("DefaultSQLiteConnection"));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.Configure<SheepYourHackHostingOptions>(builder.Configuration.GetSection("NextjsStaticHosting"));
builder.Services.AddNextjsStaticHosting();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.UseSwagger();
app.UseSwaggerUI();

app.MapNextjsStaticHtmls();
app.UseNextjsStaticHosting();

app.Run();
