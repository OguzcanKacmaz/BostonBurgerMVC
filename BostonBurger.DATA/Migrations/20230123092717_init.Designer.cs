﻿// <auto-generated />
using BostonBurger.DATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BostonBurger.DATA.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    [Migration("20230123092717_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Atistirmalik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Atistirmaliklar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Doğal, soyulmuş, gevrek kızarmış patates",
                            Adı = "Patates",
                            Fiyat = 15m,
                            KategoriID = 6,
                            Resim = "patates.png"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates",
                            Adı = "Tırtıklı Patates",
                            Fiyat = 15m,
                            KategoriID = 6,
                            Resim = "tirtikli-patates.png"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Çıtır çıtır 8’li Soğan Halka lezzeti",
                            Adı = "Soğan Halkası",
                            Fiyat = 15m,
                            KategoriID = 6,
                            Resim = "sogan-halkasi.png"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "Dışı çıtır çıtır, içi sıcacık peyniriyle 6’lı Çıtır Peynir!",
                            Adı = "Çıtır Peynir",
                            Fiyat = 15m,
                            KategoriID = 6,
                            Resim = "citir-peynir.png"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "Bir Burger King Klasiği, 6’lı parça çıtır BK King Nuggets®",
                            Adı = "BK King Nuggets®",
                            Fiyat = 15m,
                            KategoriID = 6,
                            Resim = "bk-king-nuggets-1.png"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.AtistirmalikSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AtistirmalikID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AtistirmalikID");

                    b.HasIndex("SiparisID");

                    b.ToTable("AtistirmalikSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Burger", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Burgerler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "175 gram Alevde Izgara Eti, Yumuşacık Artizan Ekmeği ile Gurmelerin Ağzını Açık Bırakan Lezzet!",
                            Adı = "Trüflü King Beef Burger",
                            Fiyat = 80m,
                            KategoriID = 1,
                            Resim = "truflu-king-beef-burger.png"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "2 kat Whopper® eti, füme eti, barbekü sosu, cheddar peyniri ve çıtır kaplamalı soğanları ile nefis bir seçim.",
                            Adı = "Double Texas Smokehouse Burger®",
                            Fiyat = 80m,
                            KategoriID = 1,
                            Resim = "double-texas-smokehouse-burger-1.png"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger King® klasiğine lezzetini veren tartar sosun birleşimi.",
                            Adı = "Fish Royale®",
                            Fiyat = 80m,
                            KategoriID = 1,
                            Resim = "fish-royale-1.png"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir Boston Burger lezzeti.",
                            Adı = "Spicy Gurme Tavuk",
                            Fiyat = 80m,
                            KategoriID = 1,
                            Resim = "spicy-gurme-tavuk.png"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "Anne tarifi ile hazırlanan 2 adet Köfteburger® eti, cheddar peyniri, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez ve marulun eşsiz birleşimi.",
                            Adı = "Double Köfteburger®",
                            Fiyat = 80m,
                            KategoriID = 1,
                            Resim = "double-kofteburger-1.png"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.BurgerSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BurgerID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BurgerID");

                    b.HasIndex("SiparisID");

                    b.ToTable("BurgerSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.EkstraMalzeme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("EkstraMalzemeler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Peynir",
                            Adı = "Peynir",
                            Fiyat = 2m,
                            KategoriID = 4,
                            Resim = "-"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Turşu",
                            Adı = "Turşu",
                            Fiyat = 2m,
                            KategoriID = 4,
                            Resim = "-"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Domates",
                            Adı = "Domates",
                            Fiyat = 2m,
                            KategoriID = 4,
                            Resim = "-"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "Soğan",
                            Adı = "Soğan",
                            Fiyat = 2m,
                            KategoriID = 4,
                            Resim = "-"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "Acı Sos",
                            Adı = "Acı Sos",
                            Fiyat = 2m,
                            KategoriID = 4,
                            Resim = "-"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.EkstraMalzemeSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("EkstraMalzemeID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EkstraMalzemeID");

                    b.HasIndex("SiparisID");

                    b.ToTable("EkstraMalzemeSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Icecek", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Icecekler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile",
                            Adı = "Fuse Tea",
                            Fiyat = 20m,
                            KategoriID = 3,
                            Resim = "fuse-tea.png"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Geleneksel Coca-Cola Lezzeti",
                            Adı = "Coca-Cola",
                            Fiyat = 20m,
                            KategoriID = 3,
                            Resim = "coca-cola.png"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Geleneksel Coca-Cola Lezzeti Sıfır Şeker",
                            Adı = "Coca-Cola Zero Sugar",
                            Fiyat = 20m,
                            KategoriID = 3,
                            Resim = "coca-cola-zero-sugar.png"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "Çilekli Milkshake yaz kış demeden sizlerle.",
                            Adı = "Çilekli Milkshake",
                            Fiyat = 20m,
                            KategoriID = 3,
                            Resim = "cilekli-milkshake.png"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "Espressolu Milkshake yaz kış demeden sizlerle.",
                            Adı = "Espressolu Milkshake",
                            Fiyat = 20m,
                            KategoriID = 3,
                            Resim = "espressolu-milkshake.png"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.IcecekSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("IcecekID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IcecekID");

                    b.HasIndex("SiparisID");

                    b.ToTable("IcecekSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("KategoriAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            KategoriAdı = "Burger"
                        },
                        new
                        {
                            ID = 2,
                            KategoriAdı = "Menu"
                        },
                        new
                        {
                            ID = 3,
                            KategoriAdı = "Icecek"
                        },
                        new
                        {
                            ID = 4,
                            KategoriAdı = "EkstraMalzeme"
                        },
                        new
                        {
                            ID = 5,
                            KategoriAdı = "Sos"
                        },
                        new
                        {
                            ID = 6,
                            KategoriAdı = "Atistirmalik"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Menuler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Boston Burger® klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!",
                            Adı = "Whopper® Menü",
                            Fiyat = 130m,
                            KategoriID = 2,
                            Resim = "whopper-menu.png"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!",
                            Adı = "Rodeo Whopper® Menü",
                            Fiyat = 130m,
                            KategoriID = 2,
                            Resim = "rodeo-whopper-menu.png"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!",
                            Adı = "BK Steakhouse Burger® Menü",
                            Fiyat = 130m,
                            KategoriID = 2,
                            Resim = "bk-steakhouse-burger-menu.png"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Big King® Menü keyfini istediğin gibi yaşa",
                            Adı = "Double Big King® Menü",
                            Fiyat = 130m,
                            KategoriID = 2,
                            Resim = "double-big-king-menu.png"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "2 adet King Chicken® eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan klasikleşmiş lezzet alternatifini, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!",
                            Adı = "Double King Chicken® Menü",
                            Fiyat = 130m,
                            KategoriID = 2,
                            Resim = "double-king-chicken-menu.png"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.MenuSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.HasIndex("SiparisID");

                    b.ToTable("MenuSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Siparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SiparisBoyut")
                        .HasColumnType("int");

                    b.Property<bool>("SiparisOnaylandı")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Sos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Soslar");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Aciklama = "Mini Acı Sos",
                            Adı = "Mini Acı Sos",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-aci-sos.png"
                        },
                        new
                        {
                            ID = 2,
                            Aciklama = "Mini Ranch",
                            Adı = "Mini Ranch",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-ranch.png"
                        },
                        new
                        {
                            ID = 3,
                            Aciklama = "Mini BBQ",
                            Adı = "Mini BBQ",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-bbq.png"
                        },
                        new
                        {
                            ID = 4,
                            Aciklama = "Mini Ballı Hardal",
                            Adı = "Mini Ballı Hardal",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-balli-hardal-1.png"
                        },
                        new
                        {
                            ID = 5,
                            Aciklama = "Mini Sarımsaklı Mayonez",
                            Adı = "Mini Sarımsaklı Mayonez",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-sarimsakli-mayonez-1.png"
                        },
                        new
                        {
                            ID = 6,
                            Aciklama = "Mini Mayonez",
                            Adı = "Mini Mayonez",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-mayonez.png"
                        },
                        new
                        {
                            ID = 7,
                            Aciklama = "Mini Ketçap",
                            Adı = "Mini Ketçap",
                            Fiyat = 5m,
                            KategoriID = 5,
                            Resim = "mini-ketcap.png"
                        });
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.SosSiparis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("SiparisID")
                        .HasColumnType("int");

                    b.Property<int>("SosID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SiparisID");

                    b.HasIndex("SosID");

                    b.ToTable("SosSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Atistirmalik", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("Atistirmaliklar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.AtistirmalikSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Atistirmalik", "Atistirmalik")
                        .WithMany("AtistirmalikSiparis")
                        .HasForeignKey("AtistirmalikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("AtistirmalikSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atistirmalik");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Burger", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("Burgerler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.BurgerSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Burger", "Burger")
                        .WithMany("BurgerSiparis")
                        .HasForeignKey("BurgerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("BurgerSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.EkstraMalzeme", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("EkstraMalzemeler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.EkstraMalzemeSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.EkstraMalzeme", "EkstraMalzeme")
                        .WithMany("EkstraMalzemeSiparis")
                        .HasForeignKey("EkstraMalzemeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("EkstraMalzemeSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EkstraMalzeme");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Icecek", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("Icecekler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.IcecekSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Icecek", "Icecek")
                        .WithMany("IcecekSiparis")
                        .HasForeignKey("IcecekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("IcecekSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icecek");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Menu", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("Menuler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.MenuSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Menu", "Menu")
                        .WithMany("MenuSiparis")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("MenuSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Siparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Sos", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Kategori", "Kategori")
                        .WithMany("Soslar")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.SosSiparis", b =>
                {
                    b.HasOne("BostonBurger.ENTITIES.Concreate.Siparis", "Siparis")
                        .WithMany("SosSiparisler")
                        .HasForeignKey("SiparisID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BostonBurger.ENTITIES.Concreate.Sos", "Sos")
                        .WithMany("SosSiparis")
                        .HasForeignKey("SosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Sos");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Atistirmalik", b =>
                {
                    b.Navigation("AtistirmalikSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Burger", b =>
                {
                    b.Navigation("BurgerSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.EkstraMalzeme", b =>
                {
                    b.Navigation("EkstraMalzemeSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Icecek", b =>
                {
                    b.Navigation("IcecekSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Kategori", b =>
                {
                    b.Navigation("Atistirmaliklar");

                    b.Navigation("Burgerler");

                    b.Navigation("EkstraMalzemeler");

                    b.Navigation("Icecekler");

                    b.Navigation("Menuler");

                    b.Navigation("Soslar");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Menu", b =>
                {
                    b.Navigation("MenuSiparis");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Siparis", b =>
                {
                    b.Navigation("AtistirmalikSiparisler");

                    b.Navigation("BurgerSiparisler");

                    b.Navigation("EkstraMalzemeSiparisler");

                    b.Navigation("IcecekSiparisler");

                    b.Navigation("MenuSiparisler");

                    b.Navigation("SosSiparisler");
                });

            modelBuilder.Entity("BostonBurger.ENTITIES.Concreate.Sos", b =>
                {
                    b.Navigation("SosSiparis");
                });
#pragma warning restore 612, 618
        }
    }
}
