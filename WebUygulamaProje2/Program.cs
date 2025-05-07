using Microsoft.EntityFrameworkCore;
using WebUygulamaProje2.Utility;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UygulamaDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //Utility içindeki contructor için servis yazdýk.
//Buradaki "DefaultConnection appsetting.json içindeki DC'yi ifade eder.
//Özetle UygulamaDbContext'i kullan, bunu kullanýrken Sql server, onuda kullanýrken DConnection'ý kullan.


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) //json dosyasýndaki Development kýsmý
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
    pattern: "{controller=Home}/{action=Index}/{id?}"); //Controllers klasöründeki controller.cs dosyalarýný ifade eder.
                                                        //action kýsmýda HomeControllerdaki metotlarý ifade eder. Action=Baþka bir html yazarsak o açýlýr.

app.Run();
