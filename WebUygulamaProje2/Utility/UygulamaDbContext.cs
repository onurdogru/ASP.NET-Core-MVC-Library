using Microsoft.EntityFrameworkCore;
using WebUygulamaProje2.Models;

namespace WebUygulamaProje2.Utility
{
    public class UygulamaDbContext : DbContext //DbContext sınıfından türeyen bir uygulama, uygulamadbcontext.
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }  //.NET Contructr


        //Veritabnında tablo oluşturmak için, property eklememiz gereklidir.

        public DbSet<KitapTuru> KitapTurleri { get; set; }

    }
}
