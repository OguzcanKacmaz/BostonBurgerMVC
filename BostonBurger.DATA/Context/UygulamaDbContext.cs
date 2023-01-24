using BostonBurger.ENTITIES.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BostonBurger.DATA.Context
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori()
                {
                    ID = 1,
                    KategoriAdı = "Burger"
                },
                new Kategori()
                {
                    ID = 2,
                    KategoriAdı = "Menu"
                },
                new Kategori()
                {
                    ID = 3,
                    KategoriAdı = "Icecek"
                },
                new Kategori()
                {
                    ID = 4,
                    KategoriAdı = "EkstraMalzeme"
                },
                new Kategori()
                {
                    ID = 5,
                    KategoriAdı = "Sos"
                },
                new Kategori()
                {
                    ID = 6,
                    KategoriAdı = "Atistirmalik"
                }
                ) ;
            modelBuilder.Entity<Menu>().HasData(
                new Menu()
                {
                    ID = 1,
                    Adı = "Whopper® Menü",
                    Aciklama = "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Boston Burger® klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!",
                    Fiyat = 130,
                    Resim = "whopper-menu.png",
                    KategoriID= 2
                },
                new Menu()
                {
                    ID = 2,
                    Adı = "Rodeo Whopper® Menü",
                    Aciklama = "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!",
                    Fiyat = 130,
                    Resim = "rodeo-whopper-menu.png",
                    KategoriID = 2
                },
                new Menu()
                {
                    ID = 3,
                    Adı = "BK Steakhouse Burger® Menü",
                    Aciklama = "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!",
                    Fiyat = 130,
                    Resim = "bk-steakhouse-burger-menu.png",
                    KategoriID = 2
                },
                new Menu()
                {
                    ID = 4,
                    Adı = "Double Big King® Menü",
                    Aciklama = "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Big King® Menü keyfini istediğin gibi yaşa",
                    Fiyat = 130,
                    Resim = "double-big-king-menu.png",
                    KategoriID = 2
                },
                new Menu()
                {
                    ID = 5,
                    Adı = "Double King Chicken® Menü",
                    Aciklama = "2 adet King Chicken® eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan klasikleşmiş lezzet alternatifini, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!",
                    Fiyat = 130,
                    Resim = "double-king-chicken-menu.png",
                    KategoriID = 2

                });

            modelBuilder.Entity<Burger>().HasData(
                new Burger()
                {
                    ID = 1,
                    Adı = "Trüflü King Beef Burger",
                    Aciklama = "175 gram Alevde Izgara Eti, Yumuşacık Artizan Ekmeği ile Gurmelerin Ağzını Açık Bırakan Lezzet!",
                    Fiyat = 80,
                    Resim = "truflu-king-beef-burger.png",
                    KategoriID = 1
                },
                new Burger()
                {
                    ID = 2,
                    Adı = "Double Texas Smokehouse Burger®",
                    Aciklama = "2 kat Whopper® eti, füme eti, barbekü sosu, cheddar peyniri ve çıtır kaplamalı soğanları ile nefis bir seçim.",
                    Fiyat = 80,
                    Resim = "double-texas-smokehouse-burger-1.png",
                    KategoriID = 1

                },
                new Burger()
                {
                    ID = 3,
                    Adı = "Fish Royale®",
                    Aciklama = "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger King® klasiğine lezzetini veren tartar sosun birleşimi.",
                    Fiyat = 80,
                    Resim = "fish-royale-1.png",
                    KategoriID = 1

                },
                new Burger()
                {
                    ID = 4,
                    Adı = "Spicy Gurme Tavuk",
                    Aciklama = "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir Boston Burger lezzeti.",
                    Fiyat = 80,
                    Resim = "spicy-gurme-tavuk.png",
                    KategoriID = 1

                },
                new Burger()
                {
                    ID = 5,
                    Adı = "Double Köfteburger®",
                    Aciklama = "Anne tarifi ile hazırlanan 2 adet Köfteburger® eti, cheddar peyniri, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez ve marulun eşsiz birleşimi.",
                    Fiyat = 80,
                    Resim = "double-kofteburger-1.png",
                    KategoriID = 1

                }
                );
            modelBuilder.Entity<Icecek>().HasData(
                new Icecek()
                {
                    ID = 1,
                    Adı = "Fuse Tea",
                    Aciklama = "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile",
                    Fiyat = 20,
                    Resim = "fuse-tea.png",
                    KategoriID = 3

                },
                new Icecek()
                {
                    ID = 2,
                    Adı = "Coca-Cola",
                    Aciklama = "Geleneksel Coca-Cola Lezzeti",
                    Fiyat = 20,
                    Resim = "coca-cola.png",
                    KategoriID = 3

                },
                 new Icecek()
                 {
                     ID = 3,
                     Adı = "Coca-Cola Zero Sugar",
                     Aciklama = "Geleneksel Coca-Cola Lezzeti Sıfır Şeker",
                     Fiyat = 20,
                     Resim = "coca-cola-zero-sugar.png",
                     KategoriID = 3

                 },
                 new Icecek()
                 {
                     ID = 4,
                     Adı = "Çilekli Milkshake",
                     Aciklama = "Çilekli Milkshake yaz kış demeden sizlerle.",
                     Fiyat = 20,
                     Resim = "cilekli-milkshake.png",
                     KategoriID = 3

                 },
                 new Icecek()
                 {
                     ID = 5,
                     Adı = "Espressolu Milkshake",
                     Aciklama = "Espressolu Milkshake yaz kış demeden sizlerle.",
                     Fiyat = 20,
                     Resim = "espressolu-milkshake.png",
                     KategoriID = 3

                 }
                );
            modelBuilder.Entity<Sos>().HasData(
                new Sos()
                {
                    ID = 1,
                    Adı = "Mini Acı Sos",
                    Aciklama = "Mini Acı Sos",
                    Fiyat = 5,
                    Resim = "mini-aci-sos.png",
                    KategoriID = 5

                },
                 new Sos()
                 {
                     ID = 2,
                     Adı = "Mini Ranch",
                     Aciklama = "Mini Ranch",
                     Fiyat = 5,
                     Resim = "mini-ranch.png",
                     KategoriID = 5

                 },
                  new Sos()
                  {
                      ID = 3,
                      Adı = "Mini BBQ",
                      Aciklama = "Mini BBQ",
                      Fiyat = 5,
                      Resim = "mini-bbq.png",
                      KategoriID = 5

                  },
                  new Sos()
                  {
                      ID = 4,
                      Adı = "Mini Ballı Hardal",
                      Aciklama = "Mini Ballı Hardal",
                      Fiyat = 5,
                      Resim = "mini-balli-hardal-1.png",
                      KategoriID = 5

                  },
                  new Sos()
                  {
                      ID = 5,
                      Adı = "Mini Sarımsaklı Mayonez",
                      Aciklama = "Mini Sarımsaklı Mayonez",
                      Fiyat = 5,
                      Resim = "mini-sarimsakli-mayonez-1.png",
                      KategoriID = 5

                  },
                  new Sos()
                  {
                      ID = 6,
                      Adı = "Mini Mayonez",
                      Aciklama = "Mini Mayonez",
                      Fiyat = 5,
                      Resim = "mini-mayonez.png",
                      KategoriID = 5

                  },
                  new Sos()
                  {
                      ID = 7,
                      Adı = "Mini Ketçap",
                      Aciklama = "Mini Ketçap",
                      Fiyat = 5,
                      Resim = "mini-ketcap.png",
                      KategoriID = 5

                  });
            modelBuilder.Entity<Atistirmalik>().HasData(
                new Atistirmalik()
                {
                    ID = 1,
                    Adı = "Patates",
                    Aciklama = "Doğal, soyulmuş, gevrek kızarmış patates",
                    Fiyat = 15,
                    Resim = "patates.png",
                    KategoriID = 6

                },
                new Atistirmalik()
                {
                    ID = 2,
                    Adı = "Tırtıklı Patates",
                    Aciklama = "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates",
                    Fiyat = 15,
                    Resim = "tirtikli-patates.png",
                    KategoriID = 6

                },
                new Atistirmalik()
                {
                    ID = 3,
                    Adı = "Soğan Halkası",
                    Aciklama = "Çıtır çıtır 8’li Soğan Halka lezzeti",
                    Fiyat = 15,
                    Resim = "sogan-halkasi.png",
                    KategoriID = 6

                },
                new Atistirmalik()
                {
                    ID = 4,
                    Adı = "Çıtır Peynir",
                    Aciklama = "Dışı çıtır çıtır, içi sıcacık peyniriyle 6’lı Çıtır Peynir!",
                    Fiyat = 15,
                    Resim = "citir-peynir.png",
                    KategoriID = 6

                },
                new Atistirmalik()
                {
                    ID = 5,
                    Adı = "BK King Nuggets®",
                    Aciklama = "Bir Burger King Klasiği, 6’lı parça çıtır BK King Nuggets®",
                    Fiyat = 15,
                    Resim = "bk-king-nuggets-1.png",
                    KategoriID = 6

                });
            modelBuilder.Entity<EkstraMalzeme>().HasData(
               new EkstraMalzeme()
               {
                   ID = 1,
                   Adı = "Peynir",
                   Aciklama = "Peynir",
                   Fiyat = 2,
                   Resim = "-",
                   KategoriID = 4

               },
               new EkstraMalzeme()
               {
                   ID = 2,
                   Adı = "Turşu",
                   Aciklama = "Turşu",
                   Fiyat = 2,
                   Resim = "-",
                   KategoriID = 4

               },
               new EkstraMalzeme()
               {
                   ID = 3,
                   Adı = "Domates",
                   Aciklama = "Domates",
                   Fiyat = 2,
                   Resim = "-",
                   KategoriID = 4

               },
               new EkstraMalzeme()
               {
                   ID = 4,
                   Adı = "Soğan",
                   Aciklama = "Soğan",
                   Fiyat = 2,
                   Resim = "-",
                   KategoriID = 4

               },
               new EkstraMalzeme()
               {
                   ID = 5,
                   Adı = "Acı Sos",
                   Aciklama = "Acı Sos",
                   Fiyat = 2,
                   Resim = "-",
                   KategoriID = 4

               }
               );

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Menu> Menuler => Set<Menu>();
        public DbSet<Burger> Burgerler => Set<Burger>();
        public DbSet<Icecek> Icecekler => Set<Icecek>();
        public DbSet<Atistirmalik> Atistirmaliklar => Set<Atistirmalik>();
        public DbSet<EkstraMalzeme> EkstraMalzemeler => Set<EkstraMalzeme>();
        public DbSet<Sos> Soslar => Set<Sos>();
        public DbSet<Kategori> Kategoriler => Set<Kategori>();
        public DbSet<Siparis> Siparisler => Set<Siparis>();
        public DbSet<AtistirmalikSiparis> AtistirmalikSiparis => Set<AtistirmalikSiparis>();
        public DbSet<BurgerSiparis> BurgerSiparis => Set<BurgerSiparis>();
        public DbSet<EkstraMalzemeSiparis> EkstraMalzemeSiparis => Set<EkstraMalzemeSiparis>();
        public DbSet<IcecekSiparis> IcecekSiparis => Set<IcecekSiparis>();
        public DbSet<MenuSiparis> MenuSiparis => Set<MenuSiparis>();
        public DbSet<SosSiparis> SosSiparis => Set<SosSiparis>();
    }
}
