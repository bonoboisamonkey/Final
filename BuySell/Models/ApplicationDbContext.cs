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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderDetail>()
                .HasKey(x => new { x.OrderId, x.ProductId });
            builder.Entity<OrderDetail>().HasOne(x => x.Product).WithMany(x => x.OrderDetails);
            builder.Entity<OrderDetail>().HasOne(x => x.Order).WithMany(x => x.OrderDetails);

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

                , new Category { Id = 27, Name = "Printerlər", ParentId = 25 }
                , new Category { Id = 28, Name = "Skanerlər", ParentId = 25 }
                , new Category { Id = 29, Name = "Secondary Hardware", ParentId = 25 }
                , new Category { Id = 30, Name = "Monitorlar", ParentId = 25 }
                , new Category { Id = 31, Name = "Digər", ParentId = 25 }
                );

            builder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    BlogTitle = "Hələdə smartfonu ən sərfəli qiymətə haradan alacağını düşünürsən?",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 2,
                    BlogTitle = "Kampaniya başa çatana qədər yalnız bir neçə gün qaldı!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 3,
                    BlogTitle = "Sifarişçilərin nəzərinə!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 4,
                    BlogTitle = "Hörmətlə , saytın administrasiyası !",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 5,
                    BlogTitle = "Fiziki şəxslər üçün mobil telefonlu bağlamaların Gömrük idarəsi tərəfindən təhvil verilmə qaydaları dəyişdirilmişdir.",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 6,
                    BlogTitle = "From.ae - dən hər kəsə 10$ hədiyyə",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                , new Blog
                {
                    Id = 7,
                    BlogTitle = "Qutu açılımı çək - endirim qazan!",
                    BlogBody = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    IsDeleted = false
                }
                ); ;

            builder.Entity<Product>().HasData(

                //telefonlar

                new Product { Id = 1, CategoryId = 5, ProductName = "Apple iPhone 11 128GB Black", ProductPrice = 810, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails="Əla telefondu" }
                , new Product { Id = 2, CategoryId = 5, ProductName = "Apple iPhone 11 128GB Red", ProductPrice = 810, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 3, CategoryId = 5, ProductName = "Apple iPhone 11 64GB Black", ProductPrice = 710, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 4, CategoryId = 5, ProductName = "Apple iPhone 11 64GB Green", ProductPrice = 750, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 5, CategoryId = 5, ProductName = "Apple iPhone 11 Dual SIM 64GB Green ", ProductPrice = 813, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 6, CategoryId = 6, ProductName = "Samsung Galaxy A20s Dual Sim SM-A207F/DS 32GB 4G", ProductPrice = 162, ProductDiscount = 0, ProductRating = 2, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 7, CategoryId = 6, ProductName = "Samsung Galaxy S9 Plus Duos SM-G965F/DS 64GB ", ProductPrice = 521, ProductDiscount = 7, ProductRating = 4, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 8, CategoryId = 6, ProductName = "Samsung Galaxy S20 Plus Dual SM-G985F/DS 8GB/128GB 4G LTE Cosmic Black ", ProductPrice = 880, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 150, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 9, CategoryId = 6, ProductName = "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Black ", ProductPrice = 1445, ProductDiscount = 18, ProductRating = 4, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 10, CategoryId = 6, ProductName = "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Gold ", ProductPrice = 1629, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 50, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 11, CategoryId = 7, ProductName = "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G ", ProductPrice = 455, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 12, CategoryId = 7, ProductName = "Xiaomi Redmi Note 8 Dual M1908C3JG 4GB/128GB 4G ", ProductPrice = 200, ProductDiscount = 15, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 13, CategoryId = 9, ProductName = "Nokia 800 Tough Dual TA-1189 4GB 4G LTE Sand ", ProductPrice = 129, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                , new Product { Id = 14, CategoryId = 9, ProductName = "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black  ", ProductPrice = 93, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 15, CategoryId = 8, ProductName = "Panasonic Eluga A3 Dual 16GB 4G LTE Gold ", ProductPrice = 164, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 16, CategoryId = 10, ProductName = "LG V30 Dual H930D 64GB 4G LTE Black ", ProductPrice = 300, ProductDiscount = 8, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }

                , new Product { Id = 17, CategoryId = 11, ProductName = "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue ", ProductPrice = 164, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Əla telefondu" }
                
                // mobil aksesualarlar

                , new Product { Id = 18, CategoryId = 12, ProductName = "X-Doria iPhone XS/X Case Defense Defense Shield ", ProductPrice = 16, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefon qabıdı" }
                , new Product { Id = 19, CategoryId = 12, ProductName = "Samsung Galaxy S10 Plus Protective Standing Cover ", ProductPrice = 32, ProductDiscount = 25, ProductRating = 3, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Əla telefon qabıdı" }

                , new Product { Id = 20, CategoryId = 13, ProductName = "JBL Charge 3 Special Edition Portable Stereo Speaker ", ProductPrice = 132, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Elə bil diktokedadı" }
                , new Product { Id = 21, CategoryId = 13, ProductName = "JBL Playlist 150 Wireless Speaker with Chromecast ", ProductPrice = 172, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Toya apar, manıslıq elə" }

                , new Product { Id = 22, CategoryId = 14, ProductName = "Samsung Galaxy Watch Active 2 44mm Bluetooth ", ProductPrice = 335, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 100, IsDeleted = false, ProductDetails = "Bahalı həyat" }
                , new Product { Id = 23, CategoryId = 14, ProductName = "Apple Watch Series 5 GPS + Cellular 44mm Space Gray ", ProductPrice = 568, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Bahalı həyat" }

                , new Product { Id = 24, CategoryId = 15, ProductName = "JBL TUNE 500BT Wireless On-Ear Headphones (Blue) ", ProductPrice = 50, ProductDiscount = 0, ProductRating = 4, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "Ucuz və keyfiyyətli" }
                , new Product { Id = 25, CategoryId = 15, ProductName = "Beats by Dr. Dre Beats Solo3 Wireless On-Ear Headphones ", ProductPrice = 150, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }

                , new Product { Id = 26, CategoryId = 16, ProductName = "Samsung Wireless Charger Duo with Wall Charger White ", ProductPrice = 56, ProductDiscount = 0, ProductRating = 3, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 27, CategoryId = 16, ProductName = "Apple 18W USB-C Power Adapter (MU7W2) ", ProductPrice = 40, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }

                , new Product { Id = 28, CategoryId = 17, ProductName = "Anker PowerCore II 20000mAh Universal Portable ", ProductPrice = 50, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 29, CategoryId = 17, ProductName = "Anker PowerCore 10000mAh Compact High-Capacity ", ProductPrice = 20, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 200, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }

                //tv və audio
                , new Product { Id = 30, CategoryId = 18, ProductName = "Apple TV 4K 32GB (MQD22) ", ProductPrice = 200, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 31, CategoryId = 19, ProductName = "Apple iPod touch 32GB 7th Generation (Pink) ", ProductPrice = 240, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 32, CategoryId = 20, ProductName = "LG 43-Inch 4K UHD TV 43UK6400 Black ", ProductPrice = 370, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 33, CategoryId = 20, ProductName = "Sony 55-inch 4K Ultra HD LED TV 55X9000E Black ", ProductPrice = 1400, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }
                , new Product { Id = 34, CategoryId = 21, ProductName = "Epson EB-U42 ", ProductPrice = 880, ProductDiscount = 0, ProductRating = 5, IsAvailable = true, ProductCount = 20, IsDeleted = false, ProductDetails = "ayfonla əla gedir" }


                );
        }
    }
}
