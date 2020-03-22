using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuySell.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogBody", "BlogTitle", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 2, 23, 23, 56, 11, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hələdə smartfonu ən sərfəli qiymətə haradan alacağını düşünürsən?", 0, null, false, 0, null },
                    { 2, 0, new DateTime(2020, 3, 15, 11, 19, 47, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Kampaniya başa çatana qədər yalnız bir neçə gün qaldı!", 0, null, false, 0, null },
                    { 3, 0, new DateTime(2020, 2, 29, 19, 37, 1, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Sifarişçilərin nəzərinə!", 0, null, false, 0, null },
                    { 4, 0, new DateTime(2020, 2, 23, 4, 58, 32, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hörmətlə , saytın administrasiyası !", 0, null, false, 0, null },
                    { 5, 0, new DateTime(2020, 2, 26, 11, 37, 14, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Fiziki şəxslər üçün mobil telefonlu bağlamaların Gömrük idarəsi tərəfindən təhvil verilmə qaydaları dəyişdirilmişdir.", 0, null, false, 0, null },
                    { 6, 0, new DateTime(2020, 3, 21, 13, 28, 25, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hər bir şəkildə gözəllik", 0, null, false, 0, null },
                    { 7, 0, new DateTime(2020, 2, 29, 7, 40, 4, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Qutu açılımı çək - endirim qazan!", 0, null, false, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Elektronika", null },
                    { 22, "Kompüterlər", null },
                    { 31, "Oyunlar", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 3, "Mobil aksesuarlar", 1 },
                    { 32, "Oyun Konsolları", 31 },
                    { 26, "Periferiya Qurğuları", 22 },
                    { 25, "Tabletlər", 22 },
                    { 24, "Masaüstü Kompüterlər", 22 },
                    { 23, "Notbuklar", 22 },
                    { 4, "Tv və Audio", 1 },
                    { 33, "Oyun Nəzarətçiləri", 31 },
                    { 34, "Video Oyunlar", 31 },
                    { 2, "Telefonlar", 1 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogId", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhotoPath", "ProductId" },
                values: new object[,]
                {
                    { 69, 0, new DateTime(2020, 3, 15, 7, 40, 41, 0, DateTimeKind.Local), 7, 0, null, false, 0, null, "images/slides/blog-id-7.jpeg", null },
                    { 68, 0, new DateTime(2020, 3, 7, 4, 20, 23, 0, DateTimeKind.Local), 6, 0, null, false, 0, null, "images/slides/blog-id-6.jpeg", null },
                    { 67, 0, new DateTime(2020, 3, 1, 10, 0, 49, 0, DateTimeKind.Local), 5, 0, null, false, 0, null, "images/slides/blog-id-5.jpeg", null },
                    { 66, 0, new DateTime(2020, 3, 18, 17, 56, 35, 0, DateTimeKind.Local), 4, 0, null, false, 0, null, "images/slides/blog-id-4.jpeg", null },
                    { 65, 0, new DateTime(2020, 3, 20, 7, 6, 50, 0, DateTimeKind.Local), 3, 0, null, false, 0, null, "images/slides/blog-id-3.jpeg", null },
                    { 64, 0, new DateTime(2020, 2, 25, 13, 50, 38, 0, DateTimeKind.Local), 2, 0, null, false, 0, null, "images/slides/blog-id-2.jpeg", null },
                    { 63, 0, new DateTime(2020, 2, 22, 13, 48, 21, 0, DateTimeKind.Local), 1, 0, null, false, 0, null, "images/slides/blog-id-1.jpeg", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 5, "Apple", 2 },
                    { 28, "Xarici disklər", 26 },
                    { 29, "Secondary Hardware", 26 },
                    { 30, "Monitorlar", 26 },
                    { 21, "Proyektorlər", 4 },
                    { 20, "Televizorlar", 4 },
                    { 19, "Audio pleyerlər", 4 },
                    { 27, "Printerlər", 26 },
                    { 17, "Digər", 3 },
                    { 16, "Adapter", 3 },
                    { 18, "Video pleyerlər", 4 },
                    { 14, "Smart Saatlar", 3 },
                    { 13, "Səs qurğuları", 3 },
                    { 12, "Keyslər", 3 },
                    { 11, "Honor", 2 },
                    { 10, "LG", 2 },
                    { 9, "Nokia", 2 },
                    { 6, "Samsung", 2 },
                    { 7, "Xiaomi", 2 },
                    { 15, "Qulaqlıqlar", 3 },
                    { 8, "Panasonic", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "CategoryId", "DeletedDate", "IsAvailable", "IsDeleted", "ModifiedDate", "ProductCount", "ProductDetails", "ProductDiscount", "ProductName", "ProductPrice", "ProductRating" },
                values: new object[,]
                {
                    { 55, new DateTime(2020, 3, 3, 22, 16, 18, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Nintendo Switch with Neon Blue and Red Joy-Con Controllers ", 320m, (byte)4 },
                    { 58, new DateTime(2020, 2, 29, 22, 21, 2, 0, DateTimeKind.Local), 33, null, true, false, null, 150, "", 0, "Microsoft Xbox One Wireless Controller ", 43m, (byte)5 },
                    { 57, new DateTime(2020, 3, 18, 17, 26, 24, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Sony PlayStation 4 Pro PS4 Pro 1TB Black ", 360m, (byte)5 },
                    { 59, new DateTime(2020, 2, 27, 5, 42, 58, 0, DateTimeKind.Local), 33, null, true, false, null, 150, "", 0, "Sony PlayStation 4 DualShock 4 Wireless ", 53m, (byte)5 },
                    { 60, new DateTime(2020, 3, 14, 7, 26, 9, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "Battle Chasers: Nightwar for PlayStation 4 (R2) ", 27m, (byte)3 },
                    { 56, new DateTime(2020, 2, 26, 6, 3, 10, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Microsoft Xbox One S 1TB Gaming Console (White) ", 240m, (byte)5 },
                    { 46, new DateTime(2020, 3, 1, 11, 29, 5, 0, DateTimeKind.Local), 25, null, true, false, null, 50, "", 0, "Apple iPad 10.2 Wi-Fi 32GB Gold ", 630m, (byte)4 },
                    { 38, new DateTime(2020, 2, 27, 9, 5, 48, 0, DateTimeKind.Local), 23, null, true, false, null, 150, "vintelyator bizlik deyil", 0, "HP Laptop 15-da1080ur 7SH99EA Black (Core i7, 8GB, 1TB, 15.6\"HD, NVIDIA GF, DOS) Eng / Rus ", 830m, (byte)3 },
                    { 44, new DateTime(2020, 2, 27, 14, 23, 14, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Apple iMac 21.5\" MMQA2(Mid 2017) ", 1040m, (byte)5 },
                    { 43, new DateTime(2020, 3, 17, 1, 41, 9, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "HP 290 G2 Microtower 3VA90EA Black (Core i3, 4GB, 500GB, Intel HD, 18.5HD, DOS) Eng/Rus ", 550m, (byte)4 },
                    { 42, new DateTime(2020, 3, 3, 15, 9, 25, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Microsoft Surface Studio 2 Multi-Touch All-in-One (Core i7, 16GB, 1TB SSD, 28\" PixelSense Touch, 6GB GTX, Win10 Pro) Engl / Arab ", 3900m, (byte)4 },
                    { 41, new DateTime(2020, 3, 12, 6, 28, 20, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Apple iMac Pro 27\" MQ2Y2 with Retina 5K Display(Late 2017) Space Gray ", 5040m, (byte)5 },
                    { 40, new DateTime(2020, 3, 3, 22, 13, 32, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 14, "Lenovo ideacentre A340-24ICB F0E6009RAX ", 838m, (byte)4 },
                    { 39, new DateTime(2020, 3, 18, 14, 7, 14, 0, DateTimeKind.Local), 23, null, true, false, null, 250, "APPLE", 0, "Apple MacBook Pro 13.3\"  MV972 with Touch Bar(Mid 2019) Space Gray ", 2040m, (byte)5 },
                    { 61, new DateTime(2020, 3, 20, 1, 59, 7, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "For Honor Deluxe Edition for PlayStation 4 (R2) ", 27m, (byte)3 },
                    { 37, new DateTime(2020, 3, 10, 3, 33, 17, 0, DateTimeKind.Local), 23, null, true, false, null, 250, "ucuz və sərfəli", 0, "Acer Aspire A1 A114-006 Black (Celeron N4000, 4GB, 64GB, 14.0\" LED, Intel HD, Win10) Engl / Arab", 259m, (byte)5 },
                    { 36, new DateTime(2020, 2, 26, 21, 18, 59, 0, DateTimeKind.Local), 23, null, true, false, null, 50, "Geymrlar üçün", 0, "ASUS ROG Zephyrus GX701GXR-HG122T Gaming ", 3880m, (byte)5 },
                    { 35, new DateTime(2020, 3, 20, 10, 15, 45, 0, DateTimeKind.Local), 23, null, true, false, null, 150, "əsl smm üçün", 14, "Lenovo IdeaPad 330S-81F400VFAX Grey ", 880m, (byte)5 },
                    { 45, new DateTime(2020, 2, 26, 20, 2, 39, 0, DateTimeKind.Local), 25, null, true, false, null, 50, "", 3, "Apple iPad 10.2 Wi - Fi 32GB Gold ", 315m, (byte)5 },
                    { 62, new DateTime(2020, 2, 26, 5, 39, 32, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "Cartoon Network: Battle Crashers for PlayStation 4 ", 27m, (byte)3 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogId", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhotoPath", "ProductId" },
                values: new object[,]
                {
                    { 62, 0, new DateTime(2020, 3, 20, 22, 42, 12, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-62.jpeg", 62 },
                    { 35, 0, new DateTime(2020, 3, 10, 19, 51, 19, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-35.jpeg", 35 },
                    { 36, 0, new DateTime(2020, 3, 14, 0, 59, 39, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-36.jpeg", 36 },
                    { 37, 0, new DateTime(2020, 3, 7, 1, 4, 13, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-37.jpeg", 37 },
                    { 38, 0, new DateTime(2020, 3, 16, 2, 44, 19, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-38.jpeg", 38 },
                    { 39, 0, new DateTime(2020, 2, 24, 10, 14, 24, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-39.jpeg", 39 },
                    { 40, 0, new DateTime(2020, 3, 20, 18, 23, 7, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-40.jpeg", 40 },
                    { 41, 0, new DateTime(2020, 2, 22, 21, 58, 8, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-41.jpeg", 41 },
                    { 42, 0, new DateTime(2020, 2, 25, 1, 32, 57, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-42.jpeg", 42 },
                    { 43, 0, new DateTime(2020, 2, 27, 7, 59, 24, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-43.jpeg", 43 },
                    { 44, 0, new DateTime(2020, 2, 22, 22, 49, 31, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-44.jpeg", 44 },
                    { 45, 0, new DateTime(2020, 2, 23, 1, 53, 35, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-45.jpeg", 45 },
                    { 46, 0, new DateTime(2020, 2, 25, 9, 13, 55, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-46.jpeg", 46 },
                    { 55, 0, new DateTime(2020, 2, 23, 14, 27, 39, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-55.jpeg", 55 },
                    { 60, 0, new DateTime(2020, 3, 1, 7, 4, 51, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-60.jpeg", 60 },
                    { 59, 0, new DateTime(2020, 2, 27, 5, 3, 46, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-59.jpeg", 59 },
                    { 58, 0, new DateTime(2020, 2, 24, 3, 16, 23, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-58.jpeg", 58 },
                    { 57, 0, new DateTime(2020, 3, 22, 0, 29, 54, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-57.jpeg", 57 },
                    { 56, 0, new DateTime(2020, 3, 12, 6, 31, 12, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-56.jpeg", 56 },
                    { 61, 0, new DateTime(2020, 3, 11, 9, 40, 10, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-61.jpeg", 61 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "CategoryId", "DeletedDate", "IsAvailable", "IsDeleted", "ModifiedDate", "ProductCount", "ProductDetails", "ProductDiscount", "ProductName", "ProductPrice", "ProductRating" },
                values: new object[,]
                {
                    { 54, new DateTime(2020, 3, 19, 15, 21, 1, 0, DateTimeKind.Local), 30, null, true, false, null, 50, "", 0, "HP 27es 68.58 cm (27\") Monitor(T3M86AA) ", 240m, (byte)5 },
                    { 49, new DateTime(2020, 2, 26, 23, 28, 21, 0, DateTimeKind.Local), 28, null, true, false, null, 50, "", 0, "Transcend 1TB StoreJet TS1TSJ25M3 Anti-Shock ", 70m, (byte)4 },
                    { 52, new DateTime(2020, 3, 15, 5, 44, 43, 0, DateTimeKind.Local), 29, null, true, false, null, 50, "", 0, "Apple Magic Keyboard (MLA22) ", 108m, (byte)5 },
                    { 51, new DateTime(2020, 3, 13, 14, 33, 38, 0, DateTimeKind.Local), 29, null, true, false, null, 50, "", 0, "Microsoft Surface Arc Wireless Mouse Black (2017) ", 70m, (byte)4 },
                    { 50, new DateTime(2020, 3, 2, 5, 15, 44, 0, DateTimeKind.Local), 28, null, true, false, null, 50, "", 0, "WD 2TB My Passport USB 3.0 Secure Portable Hard ", 80m, (byte)4 },
                    { 32, new DateTime(2020, 2, 23, 4, 42, 42, 0, DateTimeKind.Local), 20, null, true, false, null, 20, "Azərbaycan serialları artıq Türk serialı dadında", 0, "LG 43-Inch 4K UHD TV 43UK6400 Black ", 370m, (byte)5 },
                    { 47, new DateTime(2020, 3, 22, 9, 20, 58, 0, DateTimeKind.Local), 27, null, true, false, null, 50, "", 0, "HP ScanJet Pro 2500 f1 (L2747A) ", 330m, (byte)4 },
                    { 34, new DateTime(2020, 2, 24, 23, 19, 32, 0, DateTimeKind.Local), 21, null, true, false, null, 20, "Futbol heç bu qədər maraqlı olmamışdı", 0, "Epson EB-U42 ", 880m, (byte)5 },
                    { 33, new DateTime(2020, 2, 24, 4, 17, 25, 0, DateTimeKind.Local), 20, null, true, false, null, 20, "pleysteyşn üçün yaradılıb elə bil", 0, "Sony 55-inch 4K Ultra HD LED TV 55X9000E Black ", 1400m, (byte)5 },
                    { 53, new DateTime(2020, 3, 10, 21, 42, 35, 0, DateTimeKind.Local), 30, null, true, false, null, 50, "", 0, "HP 32s Monitor 2UD96AA Black/Silver ", 290m, (byte)5 },
                    { 48, new DateTime(2020, 3, 6, 4, 6, 21, 0, DateTimeKind.Local), 27, null, true, false, null, 50, "", 0, "HP LaserJet Pro M227fdn Printer (G3Q79A) ", 330m, (byte)4 },
                    { 31, new DateTime(2020, 3, 11, 10, 33, 54, 0, DateTimeKind.Local), 19, null, true, false, null, 20, "Zəngdən başqa hərşey", 0, "Apple iPod touch 32GB 7th Generation (Pink) ", 240m, (byte)5 },
                    { 29, new DateTime(2020, 3, 14, 14, 48, 10, 0, DateTimeKind.Local), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore 10000mAh Compact High-Capacity ", 20m, (byte)5 },
                    { 2, new DateTime(2020, 3, 22, 10, 37, 26, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Red", 810m, (byte)5 },
                    { 3, new DateTime(2020, 3, 12, 0, 49, 2, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Black", 710m, (byte)5 },
                    { 4, new DateTime(2020, 3, 5, 23, 15, 6, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Green", 750m, (byte)5 },
                    { 5, new DateTime(2020, 2, 26, 8, 23, 10, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 Dual SIM 64GB Yellow ", 813m, (byte)5 },
                    { 6, new DateTime(2020, 3, 14, 19, 36, 52, 0, DateTimeKind.Local), 6, null, true, false, null, 200, "Əla telefondu", 0, "Samsung Galaxy A20s Dual Sim SM-A207F/DS 32GB 4G", 162m, (byte)2 },
                    { 7, new DateTime(2020, 2, 25, 23, 33, 14, 0, DateTimeKind.Local), 6, null, true, false, null, 200, "Əla telefondu", 7, "Samsung Galaxy S9 Plus Duos SM-G965F/DS 64GB ", 521m, (byte)4 },
                    { 8, new DateTime(2020, 3, 7, 10, 6, 16, 0, DateTimeKind.Local), 6, null, true, false, null, 150, "Əla telefondu", 0, "Samsung Galaxy S20 Plus Dual SM-G985F/DS 8GB/128GB 4G LTE Cosmic Black ", 880m, (byte)4 },
                    { 9, new DateTime(2020, 2, 27, 11, 13, 18, 0, DateTimeKind.Local), 6, null, true, false, null, 100, "Əla telefondu", 18, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Black ", 1445m, (byte)4 },
                    { 10, new DateTime(2020, 3, 1, 23, 51, 55, 0, DateTimeKind.Local), 6, null, true, false, null, 50, "Əla telefondu", 0, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Gold ", 1629m, (byte)5 },
                    { 11, new DateTime(2020, 3, 5, 22, 0, 2, 0, DateTimeKind.Local), 7, null, true, false, null, 100, "Əla telefondu", 0, "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G ", 455m, (byte)5 },
                    { 12, new DateTime(2020, 3, 1, 5, 32, 6, 0, DateTimeKind.Local), 7, null, true, false, null, 100, "Əla telefondu", 15, "Xiaomi Redmi Note 8 Dual M1908C3JG 4GB/128GB 4G ", 200m, (byte)3 },
                    { 15, new DateTime(2020, 2, 27, 19, 14, 23, 0, DateTimeKind.Local), 8, null, true, false, null, 100, "Əla telefondu", 0, "Panasonic Eluga A3 Dual 16GB 4G LTE Gold ", 164m, (byte)5 },
                    { 13, new DateTime(2020, 2, 26, 14, 16, 24, 0, DateTimeKind.Local), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 800 Tough Dual TA-1189 4GB 4G LTE Sand ", 129m, (byte)5 },
                    { 14, new DateTime(2020, 3, 3, 18, 22, 59, 0, DateTimeKind.Local), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black  ", 93m, (byte)5 },
                    { 16, new DateTime(2020, 3, 14, 1, 49, 36, 0, DateTimeKind.Local), 10, null, true, false, null, 100, "Əla telefondu", 8, "LG V30 Dual H930D 64GB 4G LTE Black ", 300m, (byte)3 },
                    { 17, new DateTime(2020, 3, 18, 0, 49, 55, 0, DateTimeKind.Local), 11, null, true, false, null, 100, "Əla telefondu", 0, "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue ", 164m, (byte)3 },
                    { 18, new DateTime(2020, 3, 9, 18, 59, 22, 0, DateTimeKind.Local), 12, null, true, false, null, 200, "Əla telefon qabıdı", 0, "X-Doria iPhone XS/X Case Defense Defense Shield ", 16m, (byte)5 },
                    { 19, new DateTime(2020, 3, 18, 9, 41, 12, 0, DateTimeKind.Local), 12, null, true, false, null, 200, "Əla telefon qabıdı", 25, "Samsung Galaxy S10 Plus Protective Standing Cover ", 32m, (byte)3 },
                    { 20, new DateTime(2020, 3, 3, 17, 52, 57, 0, DateTimeKind.Local), 13, null, true, false, null, 100, "Elə bil diktokedadı", 0, "JBL Charge 3 Special Edition Portable Stereo Speaker ", 132m, (byte)5 },
                    { 21, new DateTime(2020, 2, 26, 3, 9, 19, 0, DateTimeKind.Local), 13, null, true, false, null, 100, "Toya apar, manıslıq elə", 0, "JBL Playlist 150 Wireless Speaker with Chromecast ", 172m, (byte)5 },
                    { 22, new DateTime(2020, 3, 9, 12, 44, 54, 0, DateTimeKind.Local), 14, null, true, false, null, 100, "Bahalı həyat", 0, "Samsung Galaxy Watch Active 2 44mm Bluetooth ", 335m, (byte)5 },
                    { 23, new DateTime(2020, 3, 5, 12, 57, 35, 0, DateTimeKind.Local), 14, null, true, false, null, 200, "Bahalı həyat", 0, "Apple Watch Series 5 GPS + Cellular 44mm Space Gray ", 568m, (byte)5 },
                    { 24, new DateTime(2020, 3, 12, 21, 13, 34, 0, DateTimeKind.Local), 15, null, true, false, null, 200, "Ucuz və keyfiyyətli", 0, "JBL TUNE 500BT Wireless On-Ear Headphones (Blue) ", 50m, (byte)4 },
                    { 25, new DateTime(2020, 3, 7, 13, 19, 41, 0, DateTimeKind.Local), 15, null, true, false, null, 200, "ayfonla əla gedir", 0, "Beats by Dr. Dre Beats Solo3 Wireless On-Ear Headphones ", 150m, (byte)5 },
                    { 26, new DateTime(2020, 3, 13, 20, 43, 34, 0, DateTimeKind.Local), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Samsung Wireless Charger Duo with Wall Charger White ", 56m, (byte)3 },
                    { 27, new DateTime(2020, 2, 24, 13, 23, 18, 0, DateTimeKind.Local), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Apple 18W USB-C Power Adapter (MU7W2) ", 40m, (byte)5 },
                    { 28, new DateTime(2020, 2, 29, 14, 40, 14, 0, DateTimeKind.Local), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore II 20000mAh Universal Portable ", 50m, (byte)5 },
                    { 30, new DateTime(2020, 2, 24, 10, 31, 47, 0, DateTimeKind.Local), 18, null, true, false, null, 20, "televizorun da ayfon olsun", 0, "Apple TV 4K 32GB (MQD22) ", 200m, (byte)5 },
                    { 1, new DateTime(2020, 3, 5, 22, 2, 32, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Black", 810m, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogId", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhotoPath", "ProductId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 2, 23, 15, 3, 39, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-1.jpeg", 1 },
                    { 24, 0, new DateTime(2020, 2, 25, 0, 34, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-24.jpeg", 24 },
                    { 25, 0, new DateTime(2020, 3, 14, 3, 46, 40, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-25.jpeg", 25 },
                    { 26, 0, new DateTime(2020, 3, 7, 8, 42, 57, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-26.jpeg", 26 },
                    { 27, 0, new DateTime(2020, 3, 22, 20, 48, 47, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-27.jpeg", 27 },
                    { 28, 0, new DateTime(2020, 2, 23, 0, 57, 8, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-28.jpeg", 28 },
                    { 29, 0, new DateTime(2020, 3, 9, 23, 38, 9, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-29.jpeg", 29 },
                    { 30, 0, new DateTime(2020, 3, 10, 23, 57, 48, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-30.jpeg", 30 },
                    { 31, 0, new DateTime(2020, 3, 1, 23, 9, 23, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-31.jpeg", 31 },
                    { 32, 0, new DateTime(2020, 3, 4, 2, 27, 38, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-32.jpeg", 32 },
                    { 33, 0, new DateTime(2020, 3, 15, 16, 59, 58, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-33.jpeg", 33 },
                    { 34, 0, new DateTime(2020, 3, 16, 21, 35, 20, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-34.jpeg", 34 },
                    { 47, 0, new DateTime(2020, 2, 26, 4, 57, 24, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-47.jpeg", 47 },
                    { 48, 0, new DateTime(2020, 3, 10, 10, 16, 24, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-48.jpeg", 48 },
                    { 49, 0, new DateTime(2020, 3, 5, 19, 0, 25, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-49.jpeg", 49 },
                    { 50, 0, new DateTime(2020, 3, 10, 19, 51, 2, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-50.jpeg", 50 },
                    { 51, 0, new DateTime(2020, 3, 15, 21, 9, 7, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-51.jpeg", 51 },
                    { 52, 0, new DateTime(2020, 3, 22, 3, 51, 23, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-52.jpeg", 52 },
                    { 23, 0, new DateTime(2020, 3, 13, 15, 44, 42, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-23.jpeg", 23 },
                    { 22, 0, new DateTime(2020, 3, 13, 4, 18, 59, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-22.jpeg", 22 },
                    { 21, 0, new DateTime(2020, 3, 3, 10, 57, 26, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-21.jpeg", 21 },
                    { 20, 0, new DateTime(2020, 3, 20, 4, 3, 30, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-20.jpeg", 20 },
                    { 2, 0, new DateTime(2020, 3, 4, 20, 27, 3, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-2.jpeg", 2 },
                    { 3, 0, new DateTime(2020, 3, 21, 8, 4, 34, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-3.jpeg", 3 },
                    { 4, 0, new DateTime(2020, 3, 12, 13, 3, 53, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-4.jpeg", 4 },
                    { 5, 0, new DateTime(2020, 3, 7, 20, 0, 14, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-5.jpeg", 5 },
                    { 6, 0, new DateTime(2020, 3, 3, 10, 43, 25, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-6.jpeg", 6 },
                    { 7, 0, new DateTime(2020, 3, 14, 3, 53, 47, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-7.jpeg", 7 },
                    { 8, 0, new DateTime(2020, 3, 2, 17, 41, 57, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-8.jpeg", 8 },
                    { 9, 0, new DateTime(2020, 3, 5, 17, 2, 53, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-9.jpeg", 9 },
                    { 53, 0, new DateTime(2020, 2, 23, 20, 2, 34, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-53.jpeg", 53 },
                    { 10, 0, new DateTime(2020, 3, 20, 11, 30, 40, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-10.jpeg", 10 },
                    { 12, 0, new DateTime(2020, 3, 15, 7, 14, 13, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-12.jpeg", 12 },
                    { 15, 0, new DateTime(2020, 2, 22, 6, 49, 18, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-15.jpeg", 15 },
                    { 13, 0, new DateTime(2020, 3, 22, 6, 10, 10, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-13.jpeg", 13 },
                    { 14, 0, new DateTime(2020, 2, 24, 7, 46, 27, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-14.jpeg", 14 },
                    { 16, 0, new DateTime(2020, 3, 8, 17, 20, 55, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-16.jpeg", 16 },
                    { 17, 0, new DateTime(2020, 3, 16, 20, 57, 28, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-17.jpeg", 17 },
                    { 18, 0, new DateTime(2020, 3, 7, 21, 36, 8, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-18.jpeg", 18 },
                    { 19, 0, new DateTime(2020, 3, 22, 6, 9, 8, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-19.jpeg", 19 },
                    { 11, 0, new DateTime(2020, 3, 22, 0, 37, 41, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-11.jpeg", 11 },
                    { 54, 0, new DateTime(2020, 3, 1, 16, 42, 10, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-54.jpeg", 54 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);
        }
    }
}
