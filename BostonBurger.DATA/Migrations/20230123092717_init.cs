using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BostonBurger.DATA.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisBoyut = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    SiparisOnaylandı = table.Column<bool>(type: "bit", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Atistirmaliklar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atistirmaliklar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Atistirmaliklar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Burgerler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgerler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Burgerler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EkstraMalzemeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkstraMalzemeler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EkstraMalzemeler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Icecekler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icecekler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Icecekler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menuler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Menuler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soslar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Soslar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Soslar_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtistirmalikSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtistirmalikID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtistirmalikSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AtistirmalikSiparis_Atistirmaliklar_AtistirmalikID",
                        column: x => x.AtistirmalikID,
                        principalTable: "Atistirmaliklar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtistirmalikSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BurgerSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BurgerID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurgerSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BurgerSiparis_Burgerler_BurgerID",
                        column: x => x.BurgerID,
                        principalTable: "Burgerler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BurgerSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EkstraMalzemeSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkstraMalzemeSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EkstraMalzemeSiparis_EkstraMalzemeler_EkstraMalzemeID",
                        column: x => x.EkstraMalzemeID,
                        principalTable: "EkstraMalzemeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EkstraMalzemeSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IcecekSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IcecekID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IcecekSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IcecekSiparis_Icecekler_IcecekID",
                        column: x => x.IcecekID,
                        principalTable: "Icecekler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IcecekSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuSiparis_Menuler_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menuler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SosSiparis",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SosID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosSiparis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SosSiparis_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SosSiparis_Soslar_SosID",
                        column: x => x.SosID,
                        principalTable: "Soslar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "ID", "KategoriAdı" },
                values: new object[,]
                {
                    { 1, "Burger" },
                    { 2, "Menu" },
                    { 3, "Icecek" },
                    { 4, "EkstraMalzeme" },
                    { 5, "Sos" },
                    { 6, "Atistirmalik" }
                });

            migrationBuilder.InsertData(
                table: "Atistirmaliklar",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "Doğal, soyulmuş, gevrek kızarmış patates", "Patates", 15m, 6, "patates.png" },
                    { 2, "Çıtır Mı Çıtır Altın Sarısı Tırtıklı Patates", "Tırtıklı Patates", 15m, 6, "tirtikli-patates.png" },
                    { 3, "Çıtır çıtır 8’li Soğan Halka lezzeti", "Soğan Halkası", 15m, 6, "sogan-halkasi.png" },
                    { 4, "Dışı çıtır çıtır, içi sıcacık peyniriyle 6’lı Çıtır Peynir!", "Çıtır Peynir", 15m, 6, "citir-peynir.png" },
                    { 5, "Bir Burger King Klasiği, 6’lı parça çıtır BK King Nuggets®", "BK King Nuggets®", 15m, 6, "bk-king-nuggets-1.png" }
                });

            migrationBuilder.InsertData(
                table: "Burgerler",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "175 gram Alevde Izgara Eti, Yumuşacık Artizan Ekmeği ile Gurmelerin Ağzını Açık Bırakan Lezzet!", "Trüflü King Beef Burger", 80m, 1, "truflu-king-beef-burger.png" },
                    { 2, "2 kat Whopper® eti, füme eti, barbekü sosu, cheddar peyniri ve çıtır kaplamalı soğanları ile nefis bir seçim.", "Double Texas Smokehouse Burger®", 80m, 1, "double-texas-smokehouse-burger-1.png" },
                    { 3, "Fish Royale® eti, küçük boy susamlı sandviç ekmeği, doğranmış marul ve Burger King® klasiğine lezzetini veren tartar sosun birleşimi.", "Fish Royale®", 80m, 1, "fish-royale-1.png" },
                    { 4, "Özel kaplamasıyla tavuk göğüs fileto, mısır irmiği ile süslemeli özel ekmeği, spicy sosu, domatesi ve doğranmış maruldan oluşan yeni bir Boston Burger lezzeti.", "Spicy Gurme Tavuk", 80m, 1, "spicy-gurme-tavuk.png" },
                    { 5, "Anne tarifi ile hazırlanan 2 adet Köfteburger® eti, cheddar peyniri, küçük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez ve marulun eşsiz birleşimi.", "Double Köfteburger®", 80m, 1, "double-kofteburger-1.png" }
                });

            migrationBuilder.InsertData(
                table: "EkstraMalzemeler",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "Peynir", "Peynir", 2m, 4, "-" },
                    { 2, "Turşu", "Turşu", 2m, 4, "-" },
                    { 3, "Domates", "Domates", 2m, 4, "-" },
                    { 4, "Soğan", "Soğan", 2m, 4, "-" },
                    { 5, "Acı Sos", "Acı Sos", 2m, 4, "-" }
                });

            migrationBuilder.InsertData(
                table: "Icecekler",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "Şeftalili Fuse Tea ve Limonlu Fuse Tea seçenekleri ile", "Fuse Tea", 20m, 3, "fuse-tea.png" },
                    { 2, "Geleneksel Coca-Cola Lezzeti", "Coca-Cola", 20m, 3, "coca-cola.png" },
                    { 3, "Geleneksel Coca-Cola Lezzeti Sıfır Şeker", "Coca-Cola Zero Sugar", 20m, 3, "coca-cola-zero-sugar.png" },
                    { 4, "Çilekli Milkshake yaz kış demeden sizlerle.", "Çilekli Milkshake", 20m, 3, "cilekli-milkshake.png" },
                    { 5, "Espressolu Milkshake yaz kış demeden sizlerle.", "Espressolu Milkshake", 20m, 3, "espressolu-milkshake.png" }
                });

            migrationBuilder.InsertData(
                table: "Menuler",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "Whopper® eti, büyük boy susamlı sandviç ekmeği, salatalık turşusu, ketçap, mayonez, doğranmış marul, domates ve soğandan oluşan bir Boston Burger® klasiği. Enfes patates kızartması ve içeceğiyle birlikte Whopper® Menü keyfini istediğin gibi yaşa!", "Whopper® Menü", 130m, 2, "whopper-menu.png" },
                    { 2, "Whopper® eti, büyük boy susamlı sandviç ekmeği, mayonez, doğranmış marul, soğan halkaları, nefis barbekü sosu ve 2 adet cheddar peynirinden oluşan Whopper® lezzeti. Enfes patates kızartması ve içeceğiyle birlikte Rodeo Whopper® Menü keyfini istediğin gibi yaşa!", "Rodeo Whopper® Menü", 130m, 2, "rodeo-whopper-menu.png" },
                    { 3, "Kocaman Steakhouse eti, özel sosu, cheddar peyniri, domatesi, mayonezi, marulu ve çıtır kaplamalı soğanlarıyla sabrınızı zorlayacak bir lezzet. Enfes patates kızartması ve içeceğiyle birlikte BK Steakhouse Burger® Menü keyfini istediğin gibi yaşa!", "BK Steakhouse Burger® Menü", 130m, 2, "bk-steakhouse-burger-menu.png" },
                    { 4, "4 adet Hamburger eti, 3 katlı özel ekmeği, cheddar peyniri, salatalık turşusu, doğranmış marul ve soğana eşlik eden özel Big King® sosun birleşimi. Enfes patates kızartması ve içeceğiyle birlikte Double Big King® Menü keyfini istediğin gibi yaşa", "Double Big King® Menü", 130m, 2, "double-big-king-menu.png" },
                    { 5, "2 adet King Chicken® eti, susamlı sandviç ekmeği, mayonez ve doğranmış maruldan oluşan klasikleşmiş lezzet alternatifini, enfes patates kızartması ve içeceğiyle birlikte istediğin gibi yaşa!", "Double King Chicken® Menü", 130m, 2, "double-king-chicken-menu.png" }
                });

            migrationBuilder.InsertData(
                table: "Soslar",
                columns: new[] { "ID", "Aciklama", "Adı", "Fiyat", "KategoriID", "Resim" },
                values: new object[,]
                {
                    { 1, "Mini Acı Sos", "Mini Acı Sos", 5m, 5, "mini-aci-sos.png" },
                    { 2, "Mini Ranch", "Mini Ranch", 5m, 5, "mini-ranch.png" },
                    { 3, "Mini BBQ", "Mini BBQ", 5m, 5, "mini-bbq.png" },
                    { 4, "Mini Ballı Hardal", "Mini Ballı Hardal", 5m, 5, "mini-balli-hardal-1.png" },
                    { 5, "Mini Sarımsaklı Mayonez", "Mini Sarımsaklı Mayonez", 5m, 5, "mini-sarimsakli-mayonez-1.png" },
                    { 6, "Mini Mayonez", "Mini Mayonez", 5m, 5, "mini-mayonez.png" },
                    { 7, "Mini Ketçap", "Mini Ketçap", 5m, 5, "mini-ketcap.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atistirmaliklar_KategoriID",
                table: "Atistirmaliklar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_AtistirmalikSiparis_AtistirmalikID",
                table: "AtistirmalikSiparis",
                column: "AtistirmalikID");

            migrationBuilder.CreateIndex(
                name: "IX_AtistirmalikSiparis_SiparisID",
                table: "AtistirmalikSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Burgerler_KategoriID",
                table: "Burgerler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerSiparis_BurgerID",
                table: "BurgerSiparis",
                column: "BurgerID");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerSiparis_SiparisID",
                table: "BurgerSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_EkstraMalzemeler_KategoriID",
                table: "EkstraMalzemeler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_EkstraMalzemeSiparis_EkstraMalzemeID",
                table: "EkstraMalzemeSiparis",
                column: "EkstraMalzemeID");

            migrationBuilder.CreateIndex(
                name: "IX_EkstraMalzemeSiparis_SiparisID",
                table: "EkstraMalzemeSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Icecekler_KategoriID",
                table: "Icecekler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_IcecekSiparis_IcecekID",
                table: "IcecekSiparis",
                column: "IcecekID");

            migrationBuilder.CreateIndex(
                name: "IX_IcecekSiparis_SiparisID",
                table: "IcecekSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Menuler_KategoriID",
                table: "Menuler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuSiparis_MenuID",
                table: "MenuSiparis",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuSiparis_SiparisID",
                table: "MenuSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_Soslar_KategoriID",
                table: "Soslar",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_SosSiparis_SiparisID",
                table: "SosSiparis",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_SosSiparis_SosID",
                table: "SosSiparis",
                column: "SosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtistirmalikSiparis");

            migrationBuilder.DropTable(
                name: "BurgerSiparis");

            migrationBuilder.DropTable(
                name: "EkstraMalzemeSiparis");

            migrationBuilder.DropTable(
                name: "IcecekSiparis");

            migrationBuilder.DropTable(
                name: "MenuSiparis");

            migrationBuilder.DropTable(
                name: "SosSiparis");

            migrationBuilder.DropTable(
                name: "Atistirmaliklar");

            migrationBuilder.DropTable(
                name: "Burgerler");

            migrationBuilder.DropTable(
                name: "EkstraMalzemeler");

            migrationBuilder.DropTable(
                name: "Icecekler");

            migrationBuilder.DropTable(
                name: "Menuler");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Soslar");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
