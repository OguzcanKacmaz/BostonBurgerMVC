using BostonBurger.ENTITIES.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.ENTITIES.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ad Alanı Boş Olamaz!")]
        public string Adı { get; set; } = null!;
        [Required(ErrorMessage = "Fiyat Alanı Boş Olamaz!")]

        public decimal Fiyat { get; set; }
        [Required(ErrorMessage = "Resim Alanı Boş Olamaz!")]

        public string Resim { get; set; } = null!;
        [Required(ErrorMessage = "Açıklama Alanı Boş Olamaz!")]

        public string Aciklama { get; set; } = null!;
        public int KategoriID { get; set; }

        public Kategori? Kategori { get; set; }
    }
}
