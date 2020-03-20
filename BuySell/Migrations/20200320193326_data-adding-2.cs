using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuySell.Migrations
{
    public partial class dataadding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Photos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BlogTitle",
                table: "Blogs",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "BlogBody",
                table: "Blogs",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogBody", "BlogTitle", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hələdə smartfonu ən sərfəli qiymətə haradan alacağını düşünürsən?", 0, null, false, 0, null },
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Kampaniya başa çatana qədər yalnız bir neçə gün qaldı!", 0, null, false, 0, null },
                    { 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Sifarişçilərin nəzərinə!", 0, null, false, 0, null },
                    { 4, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hörmətlə , saytın administrasiyası !", 0, null, false, 0, null },
                    { 5, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Fiziki şəxslər üçün mobil telefonlu bağlamaların Gömrük idarəsi tərəfindən təhvil verilmə qaydaları dəyişdirilmişdir.", 0, null, false, 0, null },
                    { 6, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "From.ae - dən hər kəsə 10$ hədiyyə", 0, null, false, 0, null },
                    { 7, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Qutu açılımı çək - endirim qazan!", 0, null, false, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, "Elektronika", null },
                    { 22, "Kompüterlər", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 2, "Telefonlar", 1 },
                    { 3, "Mobil aksesuarlar", 1 },
                    { 4, "Tv və Audio", 1 },
                    { 23, "Notbuklar", 22 },
                    { 24, "Masaüstü Kompüterlər", 22 },
                    { 25, "Tabletlər", 22 },
                    { 26, "Periferiya Qurğuları", 22 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { 5, "Apple", 2 },
                    { 30, "Monitorlar", 25 },
                    { 29, "Secondary Hardware", 25 },
                    { 28, "Xarici disklər", 25 },
                    { 27, "Printerlər", 25 },
                    { 20, "Televizorlar", 4 },
                    { 19, "Audio pleyerlər", 4 },
                    { 18, "Video pleyerlər", 4 },
                    { 17, "Digər", 3 },
                    { 16, "Adapter", 3 },
                    { 21, "Proyektorlər", 4 },
                    { 14, "Smart Saatlar", 3 },
                    { 13, "Səs qurğuları", 3 },
                    { 12, "Keyslər", 3 },
                    { 11, "Honor", 2 },
                    { 10, "LG", 2 },
                    { 6, "Samsung", 2 },
                    { 7, "Xiaomi", 2 },
                    { 8, "Panasonic", 2 },
                    { 9, "Nokia", 2 },
                    { 15, "Qulaqlıqlar", 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "CategoryId", "DeletedDate", "IsAvailable", "IsDeleted", "ModifiedDate", "ProductCount", "ProductDetails", "ProductDiscount", "ProductName", "ProductPrice", "ProductRating" },
                values: new object[,]
                {
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, true, false, null, 50, "", 0, "Apple iMac 21.5\" MMQA2(Mid 2017) ", 1040m, (byte)5 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, true, false, null, 50, "", 0, "HP 290 G2 Microtower 3VA90EA Black (Core i3, 4GB, 500GB, Intel HD, 18.5HD, DOS) Eng/Rus ", 550m, (byte)4 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, true, false, null, 50, "", 0, "Microsoft Surface Studio 2 Multi-Touch All-in-One (Core i7, 16GB, 1TB SSD, 28\" PixelSense Touch, 6GB GTX, Win10 Pro) Engl / Arab ", 3900m, (byte)4 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, true, false, null, 250, "APPLE", 0, "Apple MacBook Pro 13.3\"  MV972 with Touch Bar(Mid 2019) Space Gray ", 2040m, (byte)5 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, true, false, null, 50, "", 14, "Lenovo ideacentre A340-24ICB F0E6009RAX ", 838m, (byte)4 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, true, false, null, 150, "vintelyator bizlik deyil", 0, "HP Laptop 15-da1080ur 7SH99EA Black (Core i7, 8GB, 1TB, 15.6\"HD, NVIDIA GF, DOS) Eng / Rus ", 830m, (byte)3 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, true, false, null, 250, "ucuz və sərfəli", 0, "Acer Aspire A1 A114-006 Black (Celeron N4000, 4GB, 64GB, 14.0\" LED, Intel HD, Win10) Engl / Arab", 259m, (byte)5 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, true, false, null, 50, "Geymrlar üçün", 0, "ASUS ROG Zephyrus GX701GXR-HG122T Gaming ", 3880m, (byte)5 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, true, false, null, 150, "əsl smm üçün", 14, "Lenovo IdeaPad 330S-81F400VFAX Grey ", 880m, (byte)5 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, null, true, false, null, 50, "", 3, "Apple iPad 10.2 Wi - Fi 32GB Gold ", 315m, (byte)5 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, null, true, false, null, 50, "", 0, "Apple iMac Pro 27\" MQ2Y2 with Retina 5K Display(Late 2017) Space Gray ", 5040m, (byte)5 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, null, true, false, null, 50, "", 0, "Apple iPad 10.2 Wi-Fi 32GB Gold ", 630m, (byte)4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "CategoryId", "DeletedDate", "IsAvailable", "IsDeleted", "ModifiedDate", "ProductCount", "ProductDetails", "ProductDiscount", "ProductName", "ProductPrice", "ProductRating" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Black", 810m, (byte)5 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null, true, false, null, 200, "Ucuz və keyfiyyətli", 0, "JBL TUNE 500BT Wireless On-Ear Headphones (Blue) ", 50m, (byte)4 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, null, true, false, null, 200, "ayfonla əla gedir", 0, "Beats by Dr. Dre Beats Solo3 Wireless On-Ear Headphones ", 150m, (byte)5 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Samsung Wireless Charger Duo with Wall Charger White ", 56m, (byte)3 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Apple 18W USB-C Power Adapter (MU7W2) ", 40m, (byte)5 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore II 20000mAh Universal Portable ", 50m, (byte)5 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore 10000mAh Compact High-Capacity ", 20m, (byte)5 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, null, true, false, null, 20, "televizorun da ayfon olsun", 0, "Apple TV 4K 32GB (MQD22) ", 200m, (byte)5 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null, true, false, null, 20, "Zəngdən başqa hərşey", 0, "Apple iPod touch 32GB 7th Generation (Pink) ", 240m, (byte)5 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, null, true, false, null, 20, "Azərbaycan serialları artıq Türk serialı dadında", 0, "LG 43-Inch 4K UHD TV 43UK6400 Black ", 370m, (byte)5 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, null, true, false, null, 20, "pleysteyşn üçün yaradılıb elə bil", 0, "Sony 55-inch 4K Ultra HD LED TV 55X9000E Black ", 1400m, (byte)5 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, null, true, false, null, 20, "Futbol heç bu qədər maraqlı olmamışdı", 0, "Epson EB-U42 ", 880m, (byte)5 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, null, true, false, null, 50, "", 0, "HP ScanJet Pro 2500 f1 (L2747A) ", 330m, (byte)4 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, null, true, false, null, 50, "", 0, "HP LaserJet Pro M227fdn Printer (G3Q79A) ", 330m, (byte)4 },
                    { 49, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null, true, false, null, 50, "", 0, "Transcend 1TB StoreJet TS1TSJ25M3 Anti-Shock ", 70m, (byte)4 },
                    { 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null, true, false, null, 50, "", 0, "WD 2TB My Passport USB 3.0 Secure Portable Hard ", 80m, (byte)4 },
                    { 51, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null, true, false, null, 50, "", 0, "Microsoft Surface Arc Wireless Mouse Black (2017) ", 70m, (byte)4 },
                    { 52, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, null, true, false, null, 50, "", 0, "Apple Magic Keyboard (MLA22) ", 108m, (byte)5 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, true, false, null, 200, "Bahalı həyat", 0, "Apple Watch Series 5 GPS + Cellular 44mm Space Gray ", 568m, (byte)5 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, true, false, null, 100, "Bahalı həyat", 0, "Samsung Galaxy Watch Active 2 44mm Bluetooth ", 335m, (byte)5 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null, true, false, null, 100, "Toya apar, manıslıq elə", 0, "JBL Playlist 150 Wireless Speaker with Chromecast ", 172m, (byte)5 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, null, true, false, null, 100, "Elə bil diktokedadı", 0, "JBL Charge 3 Special Edition Portable Stereo Speaker ", 132m, (byte)5 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Red", 810m, (byte)5 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Black", 710m, (byte)5 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Green", 750m, (byte)5 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 Dual SIM 64GB Green ", 813m, (byte)5 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, true, false, null, 200, "Əla telefondu", 0, "Samsung Galaxy A20s Dual Sim SM-A207F/DS 32GB 4G", 162m, (byte)2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, true, false, null, 200, "Əla telefondu", 7, "Samsung Galaxy S9 Plus Duos SM-G965F/DS 64GB ", 521m, (byte)4 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, true, false, null, 150, "Əla telefondu", 0, "Samsung Galaxy S20 Plus Dual SM-G985F/DS 8GB/128GB 4G LTE Cosmic Black ", 880m, (byte)4 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, true, false, null, 100, "Əla telefondu", 18, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Black ", 1445m, (byte)4 },
                    { 53, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null, true, false, null, 50, "", 0, "HP 32s Monitor 2UD96AA Black/Silver ", 290m, (byte)5 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, true, false, null, 50, "Əla telefondu", 0, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Gold ", 1629m, (byte)5 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, true, false, null, 100, "Əla telefondu", 15, "Xiaomi Redmi Note 8 Dual M1908C3JG 4GB/128GB 4G ", 200m, (byte)3 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, true, false, null, 100, "Əla telefondu", 0, "Panasonic Eluga A3 Dual 16GB 4G LTE Gold ", 164m, (byte)5 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 800 Tough Dual TA-1189 4GB 4G LTE Sand ", 129m, (byte)5 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black  ", 93m, (byte)5 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null, true, false, null, 100, "Əla telefondu", 8, "LG V30 Dual H930D 64GB 4G LTE Black ", 300m, (byte)3 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, true, false, null, 100, "Əla telefondu", 0, "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue ", 164m, (byte)3 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, true, false, null, 200, "Əla telefon qabıdı", 0, "X-Doria iPhone XS/X Case Defense Defense Shield ", 16m, (byte)5 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, true, false, null, 200, "Əla telefon qabıdı", 25, "Samsung Galaxy S10 Plus Protective Standing Cover ", 32m, (byte)3 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, true, false, null, 100, "Əla telefondu", 0, "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G ", 455m, (byte)5 },
                    { 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, null, true, false, null, 50, "", 0, "HP 27es 68.58 cm (27\") Monitor(T3M86AA) ", 240m, (byte)5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

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
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoPath",
                table: "Photos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "BlogTitle",
                table: "Blogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BlogBody",
                table: "Blogs",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);
        }
    }
}
