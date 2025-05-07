using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje2.Models
{
    public class KitapTuru
    {
        [Key] //Primary key yaptık ve yukardaki ComponentModelDataAnnotations kütüphanesini yüklemiş olduk. Sadece Id PK oldu.
        public int Id { get; set; }

        [Required] //null olamaz
        public string Ad { get; set; }  

    }
}
