using Microsoft.EntityFrameworkCore;
using WebUygulamaProje2.Utility;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UygulamaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //Utility i�indeki contructor i�in servis yazd�k.
//Buradaki "DefaultConnection appsetting.json i�indeki DC'yi ifade eder.
//�zetle UygulamaDbContext'i kullan, bunu kullan�rken Sql server, onuda kullan�rken DConnection'� kullan.


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) //json dosyas�ndaki Development k�sm�
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
    pattern: "{controller=Home}/{action=Index}/{id?}"); //Controllers klas�r�ndeki controller.cs dosyalar�n� ifade eder.
                                                        //action k�sm�da HomeControllerdaki metotlar� ifade eder. Action=Ba�ka bir html yazarsak o a��l�r.

app.Run();
