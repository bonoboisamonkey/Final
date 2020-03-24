using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuySell.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserSurname = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    ConfirmPassword = table.Column<string>(nullable: false),
                    City = table.Column<string>(maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 20, nullable: false),
                    RegistredDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(maxLength: 200, nullable: false),
                    BlogBody = table.Column<string>(maxLength: 500, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    ParentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrackingNumber = table.Column<string>(maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderTotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    CancelationDate = table.Column<DateTime>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(maxLength: 200, nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductDiscount = table.Column<int>(nullable: false),
                    ProductRating = table.Column<byte>(nullable: false),
                    ProductDetails = table.Column<string>(maxLength: 500, nullable: false),
                    ProductCount = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentatorName = table.Column<string>(maxLength: 30, nullable: false),
                    CommentTitle = table.Column<string>(maxLength: 50, nullable: false),
                    CommentBody = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    BlogId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    OrderUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    BlogId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: true),
                    AddedBy = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    DeletedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogBody", "BlogTitle", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 3, 21, 23, 28, 29, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hələdə smartfonu ən sərfəli qiymətə haradan alacağını düşünürsən?", 0, null, false, 0, null },
                    { 2, 0, new DateTime(2020, 2, 24, 23, 1, 10, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Kampaniya başa çatana qədər yalnız bir neçə gün qaldı!", 0, null, false, 0, null },
                    { 3, 0, new DateTime(2020, 3, 18, 2, 0, 58, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Sifarişçilərin nəzərinə!", 0, null, false, 0, null },
                    { 4, 0, new DateTime(2020, 3, 6, 1, 58, 0, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hörmətlə , saytın administrasiyası !", 0, null, false, 0, null },
                    { 5, 0, new DateTime(2020, 3, 23, 17, 32, 35, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Fiziki şəxslər üçün mobil telefonlu bağlamaların Gömrük idarəsi tərəfindən təhvil verilmə qaydaları dəyişdirilmişdir.", 0, null, false, 0, null },
                    { 6, 0, new DateTime(2020, 2, 26, 18, 17, 44, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Hər bir şəkildə gözəllik", 0, null, false, 0, null },
                    { 7, 0, new DateTime(2020, 2, 25, 10, 9, 7, 0, DateTimeKind.Local), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. ", "Qutu açılımı çək - endirim qazan!", 0, null, false, 0, null }
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
                    { 69, 0, new DateTime(2020, 2, 25, 0, 40, 59, 0, DateTimeKind.Local), 7, 0, null, false, 0, null, "images/slides/blog-id-7.jpeg", null },
                    { 68, 0, new DateTime(2020, 3, 17, 0, 53, 36, 0, DateTimeKind.Local), 6, 0, null, false, 0, null, "images/slides/blog-id-6.jpeg", null },
                    { 67, 0, new DateTime(2020, 2, 28, 13, 54, 4, 0, DateTimeKind.Local), 5, 0, null, false, 0, null, "images/slides/blog-id-5.jpeg", null },
                    { 66, 0, new DateTime(2020, 3, 17, 8, 11, 31, 0, DateTimeKind.Local), 4, 0, null, false, 0, null, "images/slides/blog-id-4.jpeg", null },
                    { 65, 0, new DateTime(2020, 2, 26, 4, 55, 48, 0, DateTimeKind.Local), 3, 0, null, false, 0, null, "images/slides/blog-id-3.jpeg", null },
                    { 64, 0, new DateTime(2020, 3, 1, 12, 5, 36, 0, DateTimeKind.Local), 2, 0, null, false, 0, null, "images/slides/blog-id-2.jpeg", null },
                    { 63, 0, new DateTime(2020, 2, 26, 7, 32, 18, 0, DateTimeKind.Local), 1, 0, null, false, 0, null, "images/slides/blog-id-1.jpeg", null }
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
                    { 55, new DateTime(2020, 3, 6, 0, 56, 15, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Nintendo Switch with Neon Blue and Red Joy-Con Controllers ", 320m, (byte)4 },
                    { 58, new DateTime(2020, 3, 2, 22, 16, 32, 0, DateTimeKind.Local), 33, null, true, false, null, 150, "", 0, "Microsoft Xbox One Wireless Controller ", 43m, (byte)5 },
                    { 57, new DateTime(2020, 3, 23, 11, 29, 59, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Sony PlayStation 4 Pro PS4 Pro 1TB Black ", 360m, (byte)5 },
                    { 59, new DateTime(2020, 3, 7, 1, 57, 55, 0, DateTimeKind.Local), 33, null, true, false, null, 150, "", 0, "Sony PlayStation 4 DualShock 4 Wireless ", 53m, (byte)5 },
                    { 60, new DateTime(2020, 3, 2, 17, 56, 42, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "Sony :Battle Chasers: Nightwar for PlayStation 4 (R2) ", 27m, (byte)3 },
                    { 56, new DateTime(2020, 2, 26, 0, 0, 1, 0, DateTimeKind.Local), 32, null, true, false, null, 50, "", 0, "Microsoft Xbox One S 1TB Gaming Console (White) ", 240m, (byte)5 },
                    { 46, new DateTime(2020, 2, 25, 1, 3, 34, 0, DateTimeKind.Local), 25, null, true, false, null, 50, "", 0, "Apple iPad 10.2 Wi-Fi 32GB Gold ", 630m, (byte)4 },
                    { 38, new DateTime(2020, 3, 17, 15, 19, 44, 0, DateTimeKind.Local), 23, null, true, false, null, 150, "vintelyator bizlik deyil", 0, "HP Laptop 15-da1080ur 7SH99EA Black (Core i7, 8GB, 1TB, 15.6\"HD, NVIDIA GF, DOS) Eng / Rus ", 830m, (byte)3 },
                    { 44, new DateTime(2020, 3, 15, 11, 44, 1, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Apple iMac 21.5\" MMQA2(Mid 2017) ", 1040m, (byte)5 },
                    { 43, new DateTime(2020, 2, 24, 15, 59, 47, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "HP 290 G2 Microtower 3VA90EA Black (Core i3, 4GB, 500GB, Intel HD, 18.5HD, DOS) Eng/Rus ", 550m, (byte)4 },
                    { 42, new DateTime(2020, 3, 1, 10, 5, 54, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Microsoft Surface Studio 2 Multi-Touch All-in-One (Core i7, 16GB, 1TB SSD, 28\" PixelSense Touch, 6GB GTX, Win10 Pro) Engl / Arab ", 3900m, (byte)4 },
                    { 41, new DateTime(2020, 3, 21, 19, 53, 23, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 0, "Apple iMac Pro 27\" MQ2Y2 with Retina 5K Display(Late 2017) Space Gray ", 5040m, (byte)5 },
                    { 40, new DateTime(2020, 3, 10, 3, 53, 56, 0, DateTimeKind.Local), 24, null, true, false, null, 50, "", 14, "Lenovo ideacentre A340-24ICB F0E6009RAX ", 838m, (byte)4 },
                    { 39, new DateTime(2020, 2, 28, 11, 13, 41, 0, DateTimeKind.Local), 23, null, true, false, null, 250, "APPLE", 0, "Apple MacBook Pro 13.3\"  MV972 with Touch Bar(Mid 2019) Space Gray ", 2040m, (byte)5 },
                    { 61, new DateTime(2020, 2, 29, 7, 45, 42, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "Sony :For Honor Deluxe Edition for PlayStation 4 (R2) ", 27m, (byte)3 },
                    { 37, new DateTime(2020, 3, 11, 23, 34, 47, 0, DateTimeKind.Local), 23, null, true, false, null, 250, "ucuz və sərfəli", 0, "Acer Aspire A1 A114-006 Black (Celeron N4000, 4GB, 64GB, 14.0\" LED, Intel HD, Win10) Engl / Arab", 259m, (byte)5 },
                    { 36, new DateTime(2020, 3, 7, 4, 57, 6, 0, DateTimeKind.Local), 23, null, true, false, null, 50, "Geymrlar üçün", 0, "ASUS ROG Zephyrus GX701GXR-HG122T Gaming ", 3880m, (byte)5 },
                    { 35, new DateTime(2020, 2, 24, 22, 53, 2, 0, DateTimeKind.Local), 23, null, true, false, null, 150, "əsl smm üçün", 14, "Lenovo IdeaPad 330S-81F400VFAX Grey ", 880m, (byte)5 },
                    { 45, new DateTime(2020, 2, 28, 7, 37, 10, 0, DateTimeKind.Local), 25, null, true, false, null, 50, "", 3, "Apple iPad 10.2 Wi - Fi 32GB Gold ", 315m, (byte)5 },
                    { 62, new DateTime(2020, 3, 11, 17, 47, 27, 0, DateTimeKind.Local), 34, null, true, false, null, 50, "", 0, "Sony :Cartoon Network: Battle Crashers for PlayStation 4 ", 27m, (byte)3 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogId", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhotoPath", "ProductId" },
                values: new object[,]
                {
                    { 62, 0, new DateTime(2020, 3, 22, 6, 3, 9, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-62.jpeg", 62 },
                    { 35, 0, new DateTime(2020, 2, 29, 9, 44, 38, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-35.jpeg", 35 },
                    { 36, 0, new DateTime(2020, 2, 29, 0, 39, 8, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-36.jpeg", 36 },
                    { 37, 0, new DateTime(2020, 3, 21, 0, 28, 4, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-37.jpeg", 37 },
                    { 38, 0, new DateTime(2020, 3, 19, 4, 23, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-38.jpeg", 38 },
                    { 39, 0, new DateTime(2020, 3, 11, 2, 37, 22, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-39.jpeg", 39 },
                    { 40, 0, new DateTime(2020, 3, 2, 16, 53, 58, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-40.jpeg", 40 },
                    { 41, 0, new DateTime(2020, 3, 19, 10, 0, 32, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-41.jpeg", 41 },
                    { 42, 0, new DateTime(2020, 3, 2, 6, 47, 14, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-42.jpeg", 42 },
                    { 43, 0, new DateTime(2020, 3, 2, 6, 57, 19, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-43.jpeg", 43 },
                    { 44, 0, new DateTime(2020, 2, 26, 8, 22, 39, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-44.jpeg", 44 },
                    { 45, 0, new DateTime(2020, 3, 16, 21, 6, 59, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-45.jpeg", 45 },
                    { 46, 0, new DateTime(2020, 3, 6, 3, 53, 43, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-46.jpeg", 46 },
                    { 55, 0, new DateTime(2020, 3, 24, 11, 40, 40, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-55.jpeg", 55 },
                    { 60, 0, new DateTime(2020, 3, 23, 2, 45, 7, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-60.jpeg", 60 },
                    { 59, 0, new DateTime(2020, 2, 24, 21, 49, 0, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-59.jpeg", 59 },
                    { 58, 0, new DateTime(2020, 3, 8, 5, 56, 15, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-58.jpeg", 58 },
                    { 57, 0, new DateTime(2020, 3, 1, 17, 42, 1, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-57.jpeg", 57 },
                    { 56, 0, new DateTime(2020, 3, 11, 7, 14, 38, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-56.jpeg", 56 },
                    { 61, 0, new DateTime(2020, 2, 26, 11, 35, 13, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-61.jpeg", 61 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AddedDate", "CategoryId", "DeletedDate", "IsAvailable", "IsDeleted", "ModifiedDate", "ProductCount", "ProductDetails", "ProductDiscount", "ProductName", "ProductPrice", "ProductRating" },
                values: new object[,]
                {
                    { 54, new DateTime(2020, 3, 16, 11, 56, 56, 0, DateTimeKind.Local), 30, null, true, false, null, 50, "", 0, "HP 27es 68.58 cm (27\") Monitor(T3M86AA) ", 240m, (byte)5 },
                    { 49, new DateTime(2020, 3, 10, 10, 2, 5, 0, DateTimeKind.Local), 28, null, true, false, null, 50, "", 0, "Transcend 1TB StoreJet TS1TSJ25M3 Anti-Shock ", 70m, (byte)4 },
                    { 52, new DateTime(2020, 2, 27, 3, 48, 56, 0, DateTimeKind.Local), 29, null, true, false, null, 50, "", 0, "Apple Magic Keyboard (MLA22) ", 108m, (byte)5 },
                    { 51, new DateTime(2020, 3, 1, 7, 54, 43, 0, DateTimeKind.Local), 29, null, true, false, null, 50, "", 0, "Microsoft Surface Arc Wireless Mouse Black (2017) ", 70m, (byte)4 },
                    { 50, new DateTime(2020, 3, 10, 1, 34, 37, 0, DateTimeKind.Local), 28, null, true, false, null, 50, "", 0, "WD 2TB My Passport USB 3.0 Secure Portable Hard ", 80m, (byte)4 },
                    { 32, new DateTime(2020, 2, 28, 19, 20, 26, 0, DateTimeKind.Local), 20, null, true, false, null, 20, "Azərbaycan serialları artıq Türk serialı dadında", 0, "LG 43-Inch 4K UHD TV 43UK6400 Black ", 370m, (byte)5 },
                    { 47, new DateTime(2020, 3, 7, 13, 31, 28, 0, DateTimeKind.Local), 27, null, true, false, null, 50, "", 0, "HP ScanJet Pro 2500 f1 (L2747A) ", 330m, (byte)4 },
                    { 34, new DateTime(2020, 3, 17, 6, 45, 4, 0, DateTimeKind.Local), 21, null, true, false, null, 20, "Futbol heç bu qədər maraqlı olmamışdı", 0, "Epson EB-U42 ", 880m, (byte)5 },
                    { 33, new DateTime(2020, 3, 10, 2, 23, 33, 0, DateTimeKind.Local), 20, null, true, false, null, 20, "pleysteyşn üçün yaradılıb elə bil", 0, "Sony 55-inch 4K Ultra HD LED TV 55X9000E Black ", 1400m, (byte)5 },
                    { 53, new DateTime(2020, 3, 11, 18, 9, 27, 0, DateTimeKind.Local), 30, null, true, false, null, 50, "", 0, "HP 32s Monitor 2UD96AA Black/Silver ", 290m, (byte)5 },
                    { 48, new DateTime(2020, 3, 6, 19, 10, 9, 0, DateTimeKind.Local), 27, null, true, false, null, 50, "", 0, "HP LaserJet Pro M227fdn Printer (G3Q79A) ", 330m, (byte)4 },
                    { 31, new DateTime(2020, 3, 17, 5, 53, 11, 0, DateTimeKind.Local), 19, null, true, false, null, 20, "Zəngdən başqa hərşey", 0, "Apple iPod touch 32GB 7th Generation (Pink) ", 240m, (byte)5 },
                    { 29, new DateTime(2020, 3, 2, 13, 27, 48, 0, DateTimeKind.Local), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore 10000mAh Compact High-Capacity ", 20m, (byte)5 },
                    { 2, new DateTime(2020, 3, 3, 21, 20, 42, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Red", 810m, (byte)5 },
                    { 3, new DateTime(2020, 3, 2, 3, 6, 7, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Black", 710m, (byte)5 },
                    { 4, new DateTime(2020, 3, 7, 21, 33, 53, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 64GB Green", 750m, (byte)5 },
                    { 5, new DateTime(2020, 3, 14, 18, 28, 19, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 Dual SIM 64GB Yellow ", 813m, (byte)5 },
                    { 6, new DateTime(2020, 3, 10, 8, 23, 26, 0, DateTimeKind.Local), 6, null, true, false, null, 200, "Əla telefondu", 0, "Samsung Galaxy A20s Dual Sim SM-A207F/DS 32GB 4G", 162m, (byte)2 },
                    { 7, new DateTime(2020, 3, 5, 13, 11, 46, 0, DateTimeKind.Local), 6, null, true, false, null, 200, "Əla telefondu", 7, "Samsung Galaxy S9 Plus Duos SM-G965F/DS 64GB ", 521m, (byte)4 },
                    { 8, new DateTime(2020, 3, 2, 14, 48, 4, 0, DateTimeKind.Local), 6, null, true, false, null, 150, "Əla telefondu", 0, "Samsung Galaxy S20 Plus Dual SM-G985F/DS 8GB/128GB 4G LTE Cosmic Black ", 880m, (byte)4 },
                    { 9, new DateTime(2020, 3, 22, 14, 39, 34, 0, DateTimeKind.Local), 6, null, true, false, null, 100, "Əla telefondu", 18, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Black ", 1445m, (byte)4 },
                    { 10, new DateTime(2020, 3, 11, 17, 9, 9, 0, DateTimeKind.Local), 6, null, true, false, null, 50, "Əla telefondu", 0, "Samsung Galaxy Z Flip SM-F700F/DS 8GB/256GB 4G LTE Mirror Gold ", 1629m, (byte)5 },
                    { 11, new DateTime(2020, 3, 10, 21, 34, 51, 0, DateTimeKind.Local), 7, null, true, false, null, 100, "Əla telefondu", 0, "Xiaomi Mi Note 10 Pro Dual M1910F4S 8GB/256GB 4G ", 455m, (byte)5 },
                    { 12, new DateTime(2020, 2, 24, 1, 50, 44, 0, DateTimeKind.Local), 7, null, true, false, null, 100, "Əla telefondu", 15, "Xiaomi Redmi Note 8 Dual M1908C3JG 4GB/128GB 4G ", 200m, (byte)3 },
                    { 15, new DateTime(2020, 3, 15, 8, 12, 57, 0, DateTimeKind.Local), 8, null, true, false, null, 100, "Əla telefondu", 0, "Panasonic Eluga A3 Dual 16GB 4G LTE Gold ", 164m, (byte)5 },
                    { 13, new DateTime(2020, 3, 22, 3, 24, 34, 0, DateTimeKind.Local), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 800 Tough Dual TA-1189 4GB 4G LTE Sand ", 129m, (byte)5 },
                    { 14, new DateTime(2020, 3, 12, 7, 3, 39, 0, DateTimeKind.Local), 9, null, true, false, null, 100, "Əla telefondu", 0, "Nokia 2.2 Dual TA-1188 2GB/16GB 4G LTE Black  ", 93m, (byte)5 },
                    { 16, new DateTime(2020, 3, 18, 18, 12, 6, 0, DateTimeKind.Local), 10, null, true, false, null, 100, "Əla telefondu", 8, "LG V30 Dual H930D 64GB 4G LTE Black ", 300m, (byte)3 },
                    { 17, new DateTime(2020, 3, 20, 14, 51, 48, 0, DateTimeKind.Local), 11, null, true, false, null, 100, "Əla telefondu", 0, "Honor 8A Pro Dual JAT-L41 3GB/64GB 4G LTE Blue ", 164m, (byte)3 },
                    { 18, new DateTime(2020, 3, 11, 17, 56, 38, 0, DateTimeKind.Local), 12, null, true, false, null, 200, "Əla telefon qabıdı", 0, "X-Doria iPhone XS/X Case Defense Defense Shield ", 16m, (byte)5 },
                    { 19, new DateTime(2020, 3, 15, 18, 9, 41, 0, DateTimeKind.Local), 12, null, true, false, null, 200, "Əla telefon qabıdı", 25, "Samsung Galaxy S10 Plus Protective Standing Cover ", 32m, (byte)3 },
                    { 20, new DateTime(2020, 3, 14, 2, 6, 21, 0, DateTimeKind.Local), 13, null, true, false, null, 100, "Elə bil diktokedadı", 0, "JBL Charge 3 Special Edition Portable Stereo Speaker ", 132m, (byte)5 },
                    { 21, new DateTime(2020, 3, 22, 5, 58, 26, 0, DateTimeKind.Local), 13, null, true, false, null, 100, "Toya apar, manıslıq elə", 0, "JBL Playlist 150 Wireless Speaker with Chromecast ", 172m, (byte)5 },
                    { 22, new DateTime(2020, 2, 29, 4, 31, 26, 0, DateTimeKind.Local), 14, null, true, false, null, 100, "Bahalı həyat", 0, "Samsung Galaxy Watch Active 2 44mm Bluetooth ", 335m, (byte)5 },
                    { 23, new DateTime(2020, 3, 12, 4, 37, 16, 0, DateTimeKind.Local), 14, null, true, false, null, 200, "Bahalı həyat", 0, "Apple Watch Series 5 GPS + Cellular 44mm Space Gray ", 568m, (byte)5 },
                    { 24, new DateTime(2020, 3, 2, 0, 35, 9, 0, DateTimeKind.Local), 15, null, true, false, null, 200, "Ucuz və keyfiyyətli", 0, "JBL TUNE 500BT Wireless On-Ear Headphones (Blue) ", 50m, (byte)4 },
                    { 25, new DateTime(2020, 3, 2, 15, 21, 31, 0, DateTimeKind.Local), 15, null, true, false, null, 200, "ayfonla əla gedir", 0, "Beats by Dr. Dre Beats Solo3 Wireless On-Ear Headphones ", 150m, (byte)5 },
                    { 26, new DateTime(2020, 3, 15, 20, 17, 10, 0, DateTimeKind.Local), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Samsung Wireless Charger Duo with Wall Charger White ", 56m, (byte)3 },
                    { 27, new DateTime(2020, 3, 13, 20, 23, 16, 0, DateTimeKind.Local), 16, null, true, false, null, 200, "ayfonla əla gedir", 0, "Apple 18W USB-C Power Adapter (MU7W2) ", 40m, (byte)5 },
                    { 28, new DateTime(2020, 2, 26, 16, 9, 52, 0, DateTimeKind.Local), 17, null, true, false, null, 200, "ayfonla əla gedir", 0, "Anker PowerCore II 20000mAh Universal Portable ", 50m, (byte)5 },
                    { 30, new DateTime(2020, 2, 26, 0, 18, 54, 0, DateTimeKind.Local), 18, null, true, false, null, 20, "televizorun da ayfon olsun", 0, "Apple TV 4K 32GB (MQD22) ", 200m, (byte)5 },
                    { 1, new DateTime(2020, 3, 24, 9, 46, 54, 0, DateTimeKind.Local), 5, null, true, false, null, 100, "Əla telefondu", 0, "Apple iPhone 11 128GB Black", 810m, (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BlogId", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "PhotoPath", "ProductId" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2020, 3, 3, 20, 7, 49, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-1.jpeg", 1 },
                    { 24, 0, new DateTime(2020, 3, 21, 21, 50, 49, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-24.jpeg", 24 },
                    { 25, 0, new DateTime(2020, 3, 21, 20, 56, 32, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-25.jpeg", 25 },
                    { 26, 0, new DateTime(2020, 2, 26, 11, 13, 10, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-26.jpeg", 26 },
                    { 27, 0, new DateTime(2020, 3, 13, 0, 35, 23, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-27.jpeg", 27 },
                    { 28, 0, new DateTime(2020, 3, 1, 17, 38, 34, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-28.jpeg", 28 },
                    { 29, 0, new DateTime(2020, 3, 16, 11, 13, 40, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-29.jpeg", 29 },
                    { 30, 0, new DateTime(2020, 3, 11, 21, 4, 49, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-30.jpeg", 30 },
                    { 31, 0, new DateTime(2020, 3, 12, 9, 8, 22, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-31.jpeg", 31 },
                    { 32, 0, new DateTime(2020, 2, 29, 13, 2, 31, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-32.jpeg", 32 },
                    { 33, 0, new DateTime(2020, 3, 12, 16, 53, 47, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-33.jpeg", 33 },
                    { 34, 0, new DateTime(2020, 3, 12, 22, 51, 29, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-34.jpeg", 34 },
                    { 47, 0, new DateTime(2020, 3, 22, 4, 43, 57, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-47.jpeg", 47 },
                    { 48, 0, new DateTime(2020, 3, 15, 6, 3, 43, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-48.jpeg", 48 },
                    { 49, 0, new DateTime(2020, 3, 21, 11, 29, 22, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-49.jpeg", 49 },
                    { 50, 0, new DateTime(2020, 2, 25, 18, 36, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-50.jpeg", 50 },
                    { 51, 0, new DateTime(2020, 2, 29, 4, 18, 32, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-51.jpeg", 51 },
                    { 52, 0, new DateTime(2020, 3, 1, 10, 39, 58, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-52.jpeg", 52 },
                    { 23, 0, new DateTime(2020, 2, 28, 12, 9, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-23.jpeg", 23 },
                    { 22, 0, new DateTime(2020, 2, 24, 8, 38, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-22.jpeg", 22 },
                    { 21, 0, new DateTime(2020, 3, 20, 1, 53, 20, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-21.jpeg", 21 },
                    { 20, 0, new DateTime(2020, 3, 9, 21, 59, 40, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-20.jpeg", 20 },
                    { 2, 0, new DateTime(2020, 2, 26, 9, 6, 12, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-2.jpeg", 2 },
                    { 3, 0, new DateTime(2020, 2, 26, 7, 1, 30, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-3.jpeg", 3 },
                    { 4, 0, new DateTime(2020, 3, 13, 22, 0, 59, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-4.jpeg", 4 },
                    { 5, 0, new DateTime(2020, 3, 17, 18, 12, 44, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-5.jpeg", 5 },
                    { 6, 0, new DateTime(2020, 3, 8, 16, 24, 3, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-6.jpeg", 6 },
                    { 7, 0, new DateTime(2020, 3, 20, 4, 55, 10, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-7.jpeg", 7 },
                    { 8, 0, new DateTime(2020, 3, 10, 23, 0, 25, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-8.jpeg", 8 },
                    { 9, 0, new DateTime(2020, 3, 10, 14, 23, 52, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-9.jpeg", 9 },
                    { 53, 0, new DateTime(2020, 3, 24, 10, 11, 1, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-53.jpeg", 53 },
                    { 10, 0, new DateTime(2020, 3, 6, 18, 17, 37, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-10.jpeg", 10 },
                    { 12, 0, new DateTime(2020, 3, 8, 10, 2, 17, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-12.jpeg", 12 },
                    { 15, 0, new DateTime(2020, 3, 8, 9, 17, 12, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-15.jpeg", 15 },
                    { 13, 0, new DateTime(2020, 2, 25, 2, 59, 32, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-13.jpeg", 13 },
                    { 14, 0, new DateTime(2020, 3, 24, 14, 39, 5, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-14.jpeg", 14 },
                    { 16, 0, new DateTime(2020, 2, 29, 12, 38, 48, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-16.jpeg", 16 },
                    { 17, 0, new DateTime(2020, 3, 5, 13, 44, 32, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-17.jpeg", 17 },
                    { 18, 0, new DateTime(2020, 3, 9, 10, 4, 30, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-18.jpeg", 18 },
                    { 19, 0, new DateTime(2020, 3, 10, 2, 31, 15, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-19.jpeg", 19 },
                    { 11, 0, new DateTime(2020, 3, 14, 2, 28, 30, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-11.jpeg", 11 },
                    { 54, 0, new DateTime(2020, 3, 24, 6, 32, 35, 0, DateTimeKind.Local), null, 0, null, false, 0, null, "images/products/product-id-54.jpeg", 54 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogId",
                table: "Comments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BlogId",
                table: "Photos",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
