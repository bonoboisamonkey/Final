using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BuySell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySell.Models
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { set; get; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Photo> Photos { get; set; }

        private static DateTime RandomTime()
        {
            Random gen = new Random();
            int range = 30;
            DateTime randomDate = DateTime.Today.AddDays(-gen.Next(range));
            return randomDate.AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderDetail>()
                        .HasKey(x => new { x.OrderId, x.ProductId });
            builder.Entity<OrderDetail>()
                        .HasOne(x => x.Product)
                            .WithMany(x => x.OrderDetails);
            builder.Entity<OrderDetail>()
                        .HasOne(x => x.Order)
                            .WithMany(x => x.OrderDetails);

            builder.Entity<Cart>()
                       .HasKey(x => new { x.CostumerId, x.ProductId });
            builder.Entity<Cart>()
                        .HasOne(x => x.Product)
                            .WithMany(x => x.Carts);
            builder.Entity<Cart>()
                        .HasOne(x => x.Costumer)
                            .WithMany(x => x.Carts);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elektronika", ParentId = null }

                , new Category { Id = 2, Name = "Telefonlar", ParentId = 1 }
                , new Category { Id = 3, Name = "Mobil aksesuarlar", ParentId = 1 }
                , new Category { Id = 4, Name = "Tv və Audio", ParentId = 1 }

                , new Category { Id = 5, Name = "Apple", ParentId = 2 }
                , new Category { Id = 6, Name = "Samsung", ParentId = 2 }
                , new Category { Id = 7, Name = "Xiaomi", ParentId = 2 }
                , new Category { Id = 8, Name = "Panasonic", ParentId = 2 }
                , new Category { Id = 9, Name = "Nokia", ParentId = 2 }
                , new Category { Id = 10, Name = "LG", ParentId = 2 }
                , new Category { Id = 11, Name = "Honor", ParentId = 2 }

                , new Category { Id = 12, Name = "Keyslər", ParentId = 3 }
                , new Category { Id = 13, Name = "Səs qurğuları", ParentId = 3 }
                , new Category { Id = 14, Name = "Smart Saatlar", ParentId = 3 }
                , new Category { Id = 15, Name = "Qulaqlıqlar", ParentId = 3 }
                , new Category { Id = 16, Name = "Adapter", ParentId = 3 }
                , new Category { Id = 17, Name = "Digər", ParentId = 3 }

                , new Category { Id = 18, Name = "Video pleyerlər", ParentId = 4 }
                , new Category { Id = 19, Name = "Audio pleyerlər", ParentId = 4 }
                , new Category { Id = 20, Name = "Televizorlar", ParentId = 4 }
                , new Category { Id = 21, Name = "Proyektorlər", ParentId = 4 }

                , new Category { Id = 22, Name = "Kompüterlər", ParentId = null }

                , new Category { Id = 23, Name = "Notbuklar", ParentId = 22 }
                , new Category { Id = 24, Name = "Masaüstü Kompüterlər", ParentId = 22 }
                , new Category { Id = 25, Name = "Tabletlər", ParentId = 22 }
                , new Category { Id = 26, Name = "Periferiya Qurğuları", ParentId = 22 }

                , new Category { Id = 27, Name = "Printerlər", ParentId = 26 }
                , new Category { Id = 28, Name = "Xarici disklər", ParentId = 26 }
                , new Category { Id = 29, Name = "Secondary Hardware", ParentId = 26 }
                , new Category { Id = 30, Name = "Monitorlar", ParentId = 26 }

                , new Category { Id = 31, Name = "Oyunlar", ParentId = null }

                , new Category { Id = 32, Name = "Oyun Konsolları", ParentId = 31 }
                , new Category { Id = 33, Name = "Oyun Nəzarətçiləri", ParentId = 31 }
                , new Category { Id = 34, Name = "Video Oyunlar", ParentId = 31 }
                );

            builder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    BlogTitle = "Hələdə smartfonu ən sərfəli qiymətə haradan alacağını düşünürsən?",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 2,
                    BlogTitle = "Kampaniya başa çatana qədər yalnız bir neçə gün qaldı!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 3,
                    BlogTitle = "Sifarişçilərin nəzərinə!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 4,
                    BlogTitle = "Hörmətlə , saytın administrasiyası !",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 5,
                    BlogTitle = "Fiziki şəxslər üçün mobil telefonlu bağlamaların Gömrük idarəsi tərəfindən təhvil verilmə qaydaları dəyişdirilmişdir.",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 6,
                    BlogTitle = "Hər bir şəkildə gözəllik",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                , new Blog
                {
                    Id = 7,
                    BlogTitle = "Qutu açılımı çək - endirim qazan!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ",
                    IsDeleted = false,
                    AddedDate = RandomTime()
                }
                ); ;

            builder.Entity<Product>().HasData(

                //telefonlar

                new Product { Id = 1, CategoryId = 5, ProductName = "Apple iPhone 11 128GB Black", ProductPrice = 810, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 2, CategoryId = 5, ProductName = "Apple iPhone 11 128GB Red", ProductPrice = 810, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 3, CategoryId = 5, ProductName = "Apple iPhone 11 64GB Black", ProductPrice = 710, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 4, CategoryId = 5, ProductName = "Apple iPhone 11 64GB Green", ProductPrice = 750, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 5, CategoryId = 5, ProductName = "Apple iPhone 11 Dual SIM 64GB Yellow ", ProductPrice = 813, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 6, CategoryId = 6, ProductName = "Samsung Galaxy A20s Dual Sim SM-A207F/DS 32GB 4G", ProductPrice = 162, ProductDiscount = 0, ProductRating = 2, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 7, CategoryId = 6, ProductName = "Samsung Galaxy S9 Plus Duos SM-G965F/DS 64GB ", ProductPrice = 521, ProductDiscount = 7, ProductRating = 4, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 8, CategoryId = 6, ProductName = "Samsung Galaxy S20 Plus Dual SM-G985F/DS 8GB/128GB 4G LTE Cosmic Black ", ProductPrice = 880, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 9, CategoryId = 6, ProductName = "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Black ", ProductPrice = 1445, ProductDiscount = 18, ProductRating = 4, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 10, CategoryId = 6, ProductName = "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Gold ", ProductPrice = 1629, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 11, CategoryId = 7, ProductName = "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G ", ProductPrice = 455, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 12, CategoryId = 7, ProductName = "Xiaomi Redmi Note 8 Dual M1908C3JG 4GB/128GB 4G ", ProductPrice = 200, ProductDiscount = 15, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 13, CategoryId = 9, ProductName = "Nokia 800 Tough Dual TA-1189 4GB 4G LTE Sand ", ProductPrice = 129, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }
                , new Product { Id = 14, CategoryId = 9, ProductName = "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black  ", ProductPrice = 93, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 15, CategoryId = 8, ProductName = "Panasonic Eluga A3 Dual 16GB 4G LTE Gold ", ProductPrice = 164, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 16, CategoryId = 10, ProductName = "LG V30 Dual H930D 64GB 4G LTE Black ", ProductPrice = 300, ProductDiscount = 8, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                , new Product { Id = 17, CategoryId = 11, ProductName = "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue ", ProductPrice = 164, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu", AddedDate = RandomTime() }

                // mobil aksesualarlar

                , new Product { Id = 18, CategoryId = 12, ProductName = "X-Doria iPhone XS/X Case Defense Defense Shield ", ProductPrice = 16, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefon qabıdı", AddedDate = RandomTime() }
                , new Product { Id = 19, CategoryId = 12, ProductName = "Samsung Galaxy S10 Plus Protective Standing Cover ", ProductPrice = 32, ProductDiscount = 25, ProductRating = 3, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefon qabıdı", AddedDate = RandomTime() }

                , new Product { Id = 20, CategoryId = 13, ProductName = "JBL Charge 3 Special Edition Portable Stereo Speaker ", ProductPrice = 132, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Elə bil diktokedadı", AddedDate = RandomTime() }
                , new Product { Id = 21, CategoryId = 13, ProductName = "JBL Playlist 150 Wireless Speaker with Chromecast ", ProductPrice = 172, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Toya apar, manıslıq elə", AddedDate = RandomTime() }

                , new Product { Id = 22, CategoryId = 14, ProductName = "Samsung Galaxy Watch Active 2 44mm Bluetooth ", ProductPrice = 335, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Bahalı həyat", AddedDate = RandomTime() }
                , new Product { Id = 23, CategoryId = 14, ProductName = "Apple Watch Series 5 GPS + Cellular 44mm Space Gray ", ProductPrice = 568, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Bahalı həyat", AddedDate = RandomTime() }

                , new Product { Id = 24, CategoryId = 15, ProductName = "JBL TUNE 500BT Wireless On-Ear Headphones (Blue) ", ProductPrice = 50, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Ucuz və keyfiyyətli", AddedDate = RandomTime() }
                , new Product { Id = 25, CategoryId = 15, ProductName = "Beats by Dr. Dre Beats Solo3 Wireless On-Ear Headphones ", ProductPrice = 150, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir", AddedDate = RandomTime() }

                , new Product { Id = 26, CategoryId = 16, ProductName = "Samsung Wireless Charger Duo with Wall Charger White ", ProductPrice = 56, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir", AddedDate = RandomTime() }
                , new Product { Id = 27, CategoryId = 16, ProductName = "Apple 18W USB-C Power Adapter (MU7W2) ", ProductPrice = 40, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir", AddedDate = RandomTime() }

                , new Product { Id = 28, CategoryId = 17, ProductName = "Anker PowerCore II 20000mAh Universal Portable ", ProductPrice = 50, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir", AddedDate = RandomTime() }
                , new Product { Id = 29, CategoryId = 17, ProductName = "Anker PowerCore 10000mAh Compact High-Capacity ", ProductPrice = 20, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir", AddedDate = RandomTime() }

                //tv və audio
                , new Product { Id = 30, CategoryId = 18, ProductName = "Apple TV 4K 32GB (MQD22) ", ProductPrice = 200, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "televizorun da ayfon olsun", AddedDate = RandomTime() }
                , new Product { Id = 31, CategoryId = 19, ProductName = "Apple iPod touch 32GB 7th Generation (Pink) ", ProductPrice = 240, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "Zəngdən başqa hərşey", AddedDate = RandomTime() }
                , new Product { Id = 32, CategoryId = 20, ProductName = "LG 43-Inch 4K UHD TV 43UK6400 Black ", ProductPrice = 370, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "Azərbaycan serialları artıq Türk serialı dadında", AddedDate = RandomTime() }
                , new Product { Id = 33, CategoryId = 20, ProductName = "Sony 55-inch 4K Ultra HD LED TV 55X9000E Black ", ProductPrice = 1400, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "pleysteyşn üçün yaradılıb elə bil", AddedDate = RandomTime() }
                , new Product { Id = 34, CategoryId = 21, ProductName = "Epson EB-U42 ", ProductPrice = 880, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "Futbol heç bu qədər maraqlı olmamışdı", AddedDate = RandomTime() }

                //Kompüterlər

                , new Product { Id = 35, CategoryId = 23, ProductName = "Lenovo IdeaPad 330S-81F400VFAX Grey ", ProductPrice = 880, ProductDiscount = 14, ProductRating = 5, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "əsl smm üçün", AddedDate = RandomTime() }
                , new Product { Id = 36, CategoryId = 23, ProductName = "ASUS ROG Zephyrus GX701GXR-HG122T Gaming ", ProductPrice = 3880, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "Geymrlar üçün", AddedDate = RandomTime() }
                , new Product { Id = 37, CategoryId = 23, ProductName = "Acer Aspire A1 A114-006 Black (Celeron N4000, 4GB, 64GB, 14.0\" LED, Intel HD, Win10) Engl / Arab", ProductPrice = 259, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 250, IsDeleted = false, ProductDetails = "ucuz və sərfəli", AddedDate = RandomTime() }
                , new Product { Id = 38, CategoryId = 23, ProductName = "HP Laptop 15-da1080ur 7SH99EA Black (Core i7, 8GB, 1TB, 15.6\"HD, NVIDIA GF, DOS) Eng / Rus ", ProductPrice = 830, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "vintelyator bizlik deyil", AddedDate = RandomTime() }
                , new Product { Id = 39, CategoryId = 23, ProductName = "Apple MacBook Pro 13.3\"  MV972 with Touch Bar(Mid 2019) Space Gray ", ProductPrice = 2040, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 250, IsDeleted = false, ProductDetails = "APPLE", AddedDate = RandomTime() }

                , new Product { Id = 40, CategoryId = 24, ProductName = "Lenovo ideacentre A340-24ICB F0E6009RAX ", ProductPrice = 838, ProductDiscount = 14, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 41, CategoryId = 24, ProductName = "Apple iMac Pro 27\" MQ2Y2 with Retina 5K Display(Late 2017) Space Gray ", ProductPrice = 5040, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 42, CategoryId = 24, ProductName = "Microsoft Surface Studio 2 Multi-Touch All-in-One (Core i7, 16GB, 1TB SSD, 28\" PixelSense Touch, 6GB GTX, Win10 Pro) Engl / Arab ", ProductPrice = 3900, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 43, CategoryId = 24, ProductName = "HP 290 G2 Microtower 3VA90EA Black (Core i3, 4GB, 500GB, Intel HD, 18.5HD, DOS) Eng/Rus ", ProductPrice = 550, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 44, CategoryId = 24, ProductName = "Apple iMac 21.5\" MMQA2(Mid 2017) ", ProductPrice = 1040, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 45, CategoryId = 25, ProductName = "Apple iPad 10.2 Wi - Fi 32GB Gold ", ProductPrice = 315, ProductDiscount = 3, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 46, CategoryId = 25, ProductName = "Apple iPad 10.2 Wi-Fi 32GB Gold ", ProductPrice = 630, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 47, CategoryId = 27, ProductName = "HP ScanJet Pro 2500 f1 (L2747A) ", ProductPrice = 330, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 48, CategoryId = 27, ProductName = "HP LaserJet Pro M227fdn Printer (G3Q79A) ", ProductPrice = 330, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 49, CategoryId = 28, ProductName = "Transcend 1TB StoreJet TS1TSJ25M3 Anti-Shock ", ProductPrice = 70, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 50, CategoryId = 28, ProductName = "WD 2TB My Passport USB 3.0 Secure Portable Hard ", ProductPrice = 80, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 51, CategoryId = 29, ProductName = "Microsoft Surface Arc Wireless Mouse Black (2017) ", ProductPrice = 70, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 52, CategoryId = 29, ProductName = "Apple Magic Keyboard (MLA22) ", ProductPrice = 108, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 53, CategoryId = 30, ProductName = "HP 32s Monitor 2UD96AA Black/Silver ", ProductPrice = 290, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 54, CategoryId = 30, ProductName = "HP 27es 68.58 cm (27\") Monitor(T3M86AA) ", ProductPrice = 240, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                //Oyunlar
                , new Product { Id = 55, CategoryId = 32, ProductName = "Nintendo Switch with Neon Blue and Red Joy-Con Controllers ", ProductPrice = 320, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 56, CategoryId = 32, ProductName = "Microsoft Xbox One S 1TB Gaming Console (White) ", ProductPrice = 240, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 57, CategoryId = 32, ProductName = "Sony PlayStation 4 Pro PS4 Pro 1TB Black ", ProductPrice = 360, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 58, CategoryId = 33, ProductName = "Microsoft Xbox One Wireless Controller ", ProductPrice = 43, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 59, CategoryId = 33, ProductName = "Sony PlayStation 4 DualShock 4 Wireless ", ProductPrice = 53, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                , new Product { Id = 60, CategoryId = 34, ProductName = "Sony :Battle Chasers: Nightwar for PlayStation 4 (R2) ", ProductPrice = 27, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 61, CategoryId = 34, ProductName = "Sony :For Honor Deluxe Edition for PlayStation 4 (R2) ", ProductPrice = 27, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }
                , new Product { Id = 62, CategoryId = 34, ProductName = "Sony :Cartoon Network: Battle Crashers for PlayStation 4 ", ProductPrice = 27, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "", AddedDate = RandomTime() }

                );
            builder.Entity<Photo>().HasData(
                //Product photos
                new Photo { Id = 1, PhotoPath = "images/products/product-id-1.jpeg", ProductId = 1, AddedDate = RandomTime() }
                , new Photo { Id = 2, PhotoPath = "images/products/product-id-2.jpeg", ProductId = 2, AddedDate = RandomTime() }
                , new Photo { Id = 3, PhotoPath = "images/products/product-id-3.jpeg", ProductId = 3, AddedDate = RandomTime() }
                , new Photo { Id = 4, PhotoPath = "images/products/product-id-4.jpeg", ProductId = 4, AddedDate = RandomTime() }
                , new Photo { Id = 5, PhotoPath = "images/products/product-id-5.jpeg", ProductId = 5, AddedDate = RandomTime() }
                , new Photo { Id = 6, PhotoPath = "images/products/product-id-6.jpeg", ProductId = 6, AddedDate = RandomTime() }
                , new Photo { Id = 7, PhotoPath = "images/products/product-id-7.jpeg", ProductId = 7, AddedDate = RandomTime() }
                , new Photo { Id = 8, PhotoPath = "images/products/product-id-8.jpeg", ProductId = 8, AddedDate = RandomTime() }
                , new Photo { Id = 9, PhotoPath = "images/products/product-id-9.jpeg", ProductId = 9, AddedDate = RandomTime() }
                , new Photo { Id = 10, PhotoPath = "images/products/product-id-10.jpeg", ProductId = 10, AddedDate = RandomTime() }
                , new Photo { Id = 11, PhotoPath = "images/products/product-id-11.jpeg", ProductId = 11, AddedDate = RandomTime() }
                , new Photo { Id = 12, PhotoPath = "images/products/product-id-12.jpeg", ProductId = 12, AddedDate = RandomTime() }
                , new Photo { Id = 13, PhotoPath = "images/products/product-id-13.jpeg", ProductId = 13, AddedDate = RandomTime() }
                , new Photo { Id = 14, PhotoPath = "images/products/product-id-14.jpeg", ProductId = 14, AddedDate = RandomTime() }
                , new Photo { Id = 15, PhotoPath = "images/products/product-id-15.jpeg", ProductId = 15, AddedDate = RandomTime() }
                , new Photo { Id = 16, PhotoPath = "images/products/product-id-16.jpeg", ProductId = 16, AddedDate = RandomTime() }
                , new Photo { Id = 17, PhotoPath = "images/products/product-id-17.jpeg", ProductId = 17, AddedDate = RandomTime() }
                , new Photo { Id = 18, PhotoPath = "images/products/product-id-18.jpeg", ProductId = 18, AddedDate = RandomTime() }
                , new Photo { Id = 19, PhotoPath = "images/products/product-id-19.jpeg", ProductId = 19, AddedDate = RandomTime() }
                , new Photo { Id = 20, PhotoPath = "images/products/product-id-20.jpeg", ProductId = 20, AddedDate = RandomTime() }
                , new Photo { Id = 21, PhotoPath = "images/products/product-id-21.jpeg", ProductId = 21, AddedDate = RandomTime() }
                , new Photo { Id = 22, PhotoPath = "images/products/product-id-22.jpeg", ProductId = 22, AddedDate = RandomTime() }
                , new Photo { Id = 23, PhotoPath = "images/products/product-id-23.jpeg", ProductId = 23, AddedDate = RandomTime() }
                , new Photo { Id = 24, PhotoPath = "images/products/product-id-24.jpeg", ProductId = 24, AddedDate = RandomTime() }
                , new Photo { Id = 25, PhotoPath = "images/products/product-id-25.jpeg", ProductId = 25, AddedDate = RandomTime() }
                , new Photo { Id = 26, PhotoPath = "images/products/product-id-26.jpeg", ProductId = 26, AddedDate = RandomTime() }
                , new Photo { Id = 27, PhotoPath = "images/products/product-id-27.jpeg", ProductId = 27, AddedDate = RandomTime() }
                , new Photo { Id = 28, PhotoPath = "images/products/product-id-28.jpeg", ProductId = 28, AddedDate = RandomTime() }
                , new Photo { Id = 29, PhotoPath = "images/products/product-id-29.jpeg", ProductId = 29, AddedDate = RandomTime() }
                , new Photo { Id = 30, PhotoPath = "images/products/product-id-30.jpeg", ProductId = 30, AddedDate = RandomTime() }
                , new Photo { Id = 31, PhotoPath = "images/products/product-id-31.jpeg", ProductId = 31, AddedDate = RandomTime() }
                , new Photo { Id = 32, PhotoPath = "images/products/product-id-32.jpeg", ProductId = 32, AddedDate = RandomTime() }
                , new Photo { Id = 33, PhotoPath = "images/products/product-id-33.jpeg", ProductId = 33, AddedDate = RandomTime() }
                , new Photo { Id = 34, PhotoPath = "images/products/product-id-34.jpeg", ProductId = 34, AddedDate = RandomTime() }
                , new Photo { Id = 35, PhotoPath = "images/products/product-id-35.jpeg", ProductId = 35, AddedDate = RandomTime() }
                , new Photo { Id = 36, PhotoPath = "images/products/product-id-36.jpeg", ProductId = 36, AddedDate = RandomTime() }
                , new Photo { Id = 37, PhotoPath = "images/products/product-id-37.jpeg", ProductId = 37, AddedDate = RandomTime() }
                , new Photo { Id = 38, PhotoPath = "images/products/product-id-38.jpeg", ProductId = 38, AddedDate = RandomTime() }
                , new Photo { Id = 39, PhotoPath = "images/products/product-id-39.jpeg", ProductId = 39, AddedDate = RandomTime() }
                , new Photo { Id = 40, PhotoPath = "images/products/product-id-40.jpeg", ProductId = 40, AddedDate = RandomTime() }
                , new Photo { Id = 41, PhotoPath = "images/products/product-id-41.jpeg", ProductId = 41, AddedDate = RandomTime() }
                , new Photo { Id = 42, PhotoPath = "images/products/product-id-42.jpeg", ProductId = 42, AddedDate = RandomTime() }
                , new Photo { Id = 43, PhotoPath = "images/products/product-id-43.jpeg", ProductId = 43, AddedDate = RandomTime() }
                , new Photo { Id = 44, PhotoPath = "images/products/product-id-44.jpeg", ProductId = 44, AddedDate = RandomTime() }
                , new Photo { Id = 45, PhotoPath = "images/products/product-id-45.jpeg", ProductId = 45, AddedDate = RandomTime() }
                , new Photo { Id = 46, PhotoPath = "images/products/product-id-46.jpeg", ProductId = 46, AddedDate = RandomTime() }
                , new Photo { Id = 47, PhotoPath = "images/products/product-id-47.jpeg", ProductId = 47, AddedDate = RandomTime() }
                , new Photo { Id = 48, PhotoPath = "images/products/product-id-48.jpeg", ProductId = 48, AddedDate = RandomTime() }
                , new Photo { Id = 49, PhotoPath = "images/products/product-id-49.jpeg", ProductId = 49, AddedDate = RandomTime() }
                , new Photo { Id = 50, PhotoPath = "images/products/product-id-50.jpeg", ProductId = 50, AddedDate = RandomTime() }
                , new Photo { Id = 51, PhotoPath = "images/products/product-id-51.jpeg", ProductId = 51, AddedDate = RandomTime() }
                , new Photo { Id = 52, PhotoPath = "images/products/product-id-52.jpeg", ProductId = 52, AddedDate = RandomTime() }
                , new Photo { Id = 53, PhotoPath = "images/products/product-id-53.jpeg", ProductId = 53, AddedDate = RandomTime() }
                , new Photo { Id = 54, PhotoPath = "images/products/product-id-54.jpeg", ProductId = 54, AddedDate = RandomTime() }
                , new Photo { Id = 55, PhotoPath = "images/products/product-id-55.jpeg", ProductId = 55, AddedDate = RandomTime() }
                , new Photo { Id = 56, PhotoPath = "images/products/product-id-56.jpeg", ProductId = 56, AddedDate = RandomTime() }
                , new Photo { Id = 57, PhotoPath = "images/products/product-id-57.jpeg", ProductId = 57, AddedDate = RandomTime() }
                , new Photo { Id = 58, PhotoPath = "images/products/product-id-58.jpeg", ProductId = 58, AddedDate = RandomTime() }
                , new Photo { Id = 59, PhotoPath = "images/products/product-id-59.jpeg", ProductId = 59, AddedDate = RandomTime() }
                , new Photo { Id = 60, PhotoPath = "images/products/product-id-60.jpeg", ProductId = 60, AddedDate = RandomTime() }
                , new Photo { Id = 61, PhotoPath = "images/products/product-id-61.jpeg", ProductId = 61, AddedDate = RandomTime() }
                , new Photo { Id = 62, PhotoPath = "images/products/product-id-62.jpeg", ProductId = 62, AddedDate = RandomTime() }

                //blog photos
                , new Photo { Id = 63, PhotoPath = "images/slides/blog-id-1.jpeg", BlogId = 1, AddedDate = RandomTime() }
                , new Photo { Id = 64, PhotoPath = "images/slides/blog-id-2.jpeg", BlogId = 2, AddedDate = RandomTime() }
                , new Photo { Id = 65, PhotoPath = "images/slides/blog-id-3.jpeg", BlogId = 3, AddedDate = RandomTime() }
                , new Photo { Id = 66, PhotoPath = "images/slides/blog-id-4.jpeg", BlogId = 4, AddedDate = RandomTime() }
                , new Photo { Id = 67, PhotoPath = "images/slides/blog-id-5.jpeg", BlogId = 5, AddedDate = RandomTime() }
                , new Photo { Id = 68, PhotoPath = "images/slides/blog-id-6.jpeg", BlogId = 6, AddedDate = RandomTime() }
                , new Photo { Id = 69, PhotoPath = "images/slides/blog-id-7.jpeg", BlogId = 7, AddedDate = RandomTime() }

                );
        }
    }
}

