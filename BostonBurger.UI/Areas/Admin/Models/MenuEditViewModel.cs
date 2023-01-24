using System.ComponentModel.DataAnnotations;

namespace BostonBurger.UI.Areas.Admin.Models
{
    public class MenuEditViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Olamaz!")]

        public string Adı { get; set; } = null!;
        [Required(ErrorMessage = "Fiyat Alanı Boş Olamaz!")]

        public decimal Fiyat { get; set; }
        public IFormFile? Resim { get; set; }
        [Required(ErrorMessage = "Açıklama Alanı Boş Olamaz!")]

        public string Aciklama { get; set; } = null!;
    }
}
