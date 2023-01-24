using BostonBurger.ENTITIES.Abstract;
using BostonBurger.ENTITIES.Enumlar;

namespace BostonBurger.UI.Models
{
    public class SepetViewModel
    {
        public List<BaseEntity> Sepet { get; set; }=new List<BaseEntity>();
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
    }
}
