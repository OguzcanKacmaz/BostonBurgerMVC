using System.ComponentModel.DataAnnotations;

namespace BostonBurger.UI.Areas.Admin.Models
{
    public class MenuViewModel
    {
        [Required(ErrorMessage ="Ad Alanı Boş Olamaz!")]
        public string Adı { get; set; } = null!;
        [Required(ErrorMessage = "Fiyat Alanı Boş Olamaz!")]
        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Resim Alanı Boş Olamaz!")]

        public IFormFile Resim { get; set; }=null!;
        [Required(ErrorMessage = "Açıklama Alanı Boş Olamaz!")]

        public string Aciklama { get; set; } = null!;
    }
}
