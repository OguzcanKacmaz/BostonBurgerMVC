using BostonBurger.BL.Abstract;
using BostonBurger.BL.Concreate;
using BostonBurger.BL.EntityFramework;
using BostonBurger.DATA.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<UygulamaDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("cs")));

builder.Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
builder.Services.AddScoped<EfAtistirmalikDal>();
builder.Services.AddScoped<EfBurgerDal>();
builder.Services.AddScoped<EfEkstraMalzemeDal>();
builder.Services.AddScoped<EfIcecekDal>();
builder.Services.AddScoped<EfMenuDal>();
builder.Services.AddScoped<EfSiparisDal>();
builder.Services.AddScoped<EfSosDal>();
builder.Services.AddScoped<EfSosSiparisDal>();
builder.Services.AddScoped<EfMenuSiparisDal>();
builder.Services.AddScoped<EfAtistirmalikSiparisDal>();
builder.Services.AddScoped<EfBurgerSiparisDal>();
builder.Services.AddScoped<EfIcecekSiparisDal>();
builder.Services.AddScoped<EfEkstraMalzemeSiparisDal>();


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
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
