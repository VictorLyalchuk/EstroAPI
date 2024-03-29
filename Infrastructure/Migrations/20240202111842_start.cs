﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BagId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageForHome",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageForHome", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Payment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Bag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bag_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Info_InfoId",
                        column: x => x.InfoId,
                        principalTable: "Info",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Article = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderUser",
                columns: table => new
                {
                    OrdersId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderUser", x => new { x.OrdersId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_OrderUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderUser_Orders_OrdersId",
                        column: x => x.OrdersId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    URLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(180)", maxLength: 180, nullable: false),
                    Article = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
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
                name: "BagItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    BagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BagItems_Bag_BagId",
                        column: x => x.BagId,
                        principalTable: "Bag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BagItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductQuantity = table.Column<int>(type: "int", nullable: true),
                    Size = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    inStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storage_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ImageForHome",
                columns: new[] { "Id", "ImagePath" },
                values: new object[,]
                {
                    { 1, "800_home_page_1.webp" },
                    { 2, "800_home_page_2.webp" },
                    { 3, "800_home_page_3.webp" },
                    { 4, "800_home_page_4.webp" }
                });

            migrationBuilder.InsertData(
                table: "Info",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Color" },
                    { 2, "Material" },
                    { 3, "Size" },
                    { 5, "Purpose" }
                });

            migrationBuilder.InsertData(
                table: "MainCategories",
                columns: new[] { "Id", "ImagePath", "Name", "URLName" },
                values: new object[,]
                {
                    { 1, null, "Woman", "woman" },
                    { 2, null, "Man", "man" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "InfoId", "Label", "Value" },
                values: new object[,]
                {
                    { 1, 1, "Black", "black" },
                    { 2, 1, "Brown", "brown" },
                    { 3, 1, "Gray", "gray" },
                    { 4, 1, "Light Gray", "lightgray" },
                    { 5, 1, "White", "white" },
                    { 6, 1, "Milk", "milk" },
                    { 7, 1, "Navi", "navi" },
                    { 8, 1, "Blue", "blue" },
                    { 9, 2, "Leather", "leather" },
                    { 10, 2, "Suede", "suede" },
                    { 11, 2, "Nubuck", "nubuck" },
                    { 12, 2, "Textile", "textile" },
                    { 13, 2, "Synthetic", "synthetic" },
                    { 14, 2, "Eco Leather", "ecoleather" },
                    { 15, 3, "35", "35" },
                    { 16, 3, "36", "36" },
                    { 17, 3, "37", "37" },
                    { 18, 3, "38", "38" },
                    { 19, 3, "39", "39" },
                    { 20, 3, "40", "40" },
                    { 21, 3, "41", "41" },
                    { 25, 3, "42", "42" },
                    { 26, 3, "43", "43" },
                    { 27, 3, "44", "44" },
                    { 28, 3, "45", "45" },
                    { 29, 3, "46", "46" },
                    { 30, 5, "Winter", "winter" },
                    { 31, 5, "Spring", "spring" },
                    { 32, 5, "Summer", "summer" },
                    { 33, 5, "Autumn", "autumn " }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "ImagePath", "MainCategoryId", "Name", "URLName" },
                values: new object[,]
                {
                    { 1, null, 1, "Woman Shoes", "woman_shoes" },
                    { 2, null, 2, "Man Shoes", "man_shoes" },
                    { 3, null, 1, "Woman Clothing", "woman_clothing" },
                    { 4, null, 2, "Man Clothing", "man_clothing" },
                    { 5, null, 1, "Woman Accessories", "woman_accessories" },
                    { 6, null, 2, "Man Accessories", "man_accessories" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ImagePath", "Name", "SubCategoryId", "URLName" },
                values: new object[,]
                {
                    { 1, null, null, "Open shoes", 1, "open_shoes" },
                    { 2, null, null, "Pumps and loafers", 1, "pumps_and_loafers" },
                    { 3, null, null, "Heeled shoes", 1, "heeled_shoes" },
                    { 4, null, null, "Women's athletic sneakers", 1, "women's_athletic_sneakers" },
                    { 5, null, null, "Women's sneakers", 1, "women_sneakers" },
                    { 6, null, null, "High boots and Chelsea", 1, "high_boots_&_chelsea" },
                    { 7, null, null, "Boots on heels", 1, "boots_on_heels" },
                    { 8, null, null, "Boots and high boots", 1, "boots_and_high_boots" },
                    { 9, null, null, "Cossacks boots", 1, "cossacks_boots" },
                    { 10, null, null, "Winter footwear", 1, "winter_footwear" },
                    { 11, null, null, "Perforated shoes", 1, "perforated_shoes" },
                    { 12, null, null, "Men's boots", 2, "men_boots" },
                    { 13, null, null, "Men's athletic sneakers", 2, "man_athletic_sneakers" },
                    { 14, null, null, "Men's sneakers", 2, "man_sneakers" },
                    { 15, null, null, "Men's pumps", 2, "man_pumps" },
                    { 16, null, null, "Men's moccasins", 2, "man_moccasins" },
                    { 17, null, null, "Men's summer shoes", 2, "man_summer_shoes" },
                    { 18, null, null, "Women's outerwear", 3, "woman_outerwear" },
                    { 19, null, null, "Women's sweaters and suits", 3, "woman_sweaters_and_suits" },
                    { 20, null, null, "Women's t-shirts and sweatshirts", 3, "woman_t_shirts_and_sweatshirts" },
                    { 21, null, null, "Women's shawl", 3, "woman_shawl" },
                    { 22, null, null, "Women's scarves and hats", 3, "woman_scarves_and_hats" },
                    { 23, null, null, "Women's gloves", 3, "woman_gloves" },
                    { 24, null, null, "Women's socks and tights", 3, "woman_socks_and_tights" },
                    { 25, null, null, "Men's outerwear", 4, "man_outerwear" },
                    { 26, null, null, "Men's sweaters and suits", 4, "man_sweaters_and_suits" },
                    { 27, null, null, "Men's t-shirts and sweatshirts", 4, "man_t_shirts_and_sweatshirts" },
                    { 28, null, null, "Men's scarves and hats", 4, "man_scarves_and_hats" },
                    { 29, null, null, "Men's gloves", 4, "man_gloves" },
                    { 30, null, null, "Men's socks", 4, "man_socks" },
                    { 31, null, null, "Women's glasses", 5, "woman_glasses" },
                    { 32, null, null, "Women's home shoes", 5, "woman_home_shoes" },
                    { 33, null, null, "Women's bags", 5, "woman_bags" },
                    { 34, null, null, "Women's backpacks", 5, "woman_backpacks" },
                    { 35, null, null, "Women's care products", 5, "woman_care_products" },
                    { 36, null, null, "Men's glasses", 6, "man_glasses" },
                    { 37, null, null, "Men's home shoes", 6, "man_home_shoes" },
                    { 38, null, null, "Men's bags", 6, "man_bags" },
                    { 39, null, null, "Men's backpacks", 6, "man_backpacks" },
                    { 40, null, null, "Men's care products", 6, "man_care_products" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "Color", "Description", "Material", "Name", "Price", "Purpose" },
                values: new object[,]
                {
                    { 1, "ER00113828", 8, "Black", "These stylish black leather boots-stockings are a perfect blend of fashion and comfort. Crafted with high-quality leather, they provide a sleek and sophisticated look. Ideal for various occasions, these boots-stockings are a must-have in your wardrobe.", "Leather", "Boots-stockings are black leather", 7399m, "Autumn" },
                    { 2, "ER00112019", 8, "Brown", "Step into the season with elegance in these Autumn brown leather stretch boots. Meticulously crafted from premium leather, these boots offer both style and comfort. The stretch feature ensures a snug fit, while the rich brown color adds a touch of warmth to your autumn wardrobe. Perfect for any occasion, these boots are a fashion statement that complements your unique style. Embrace the essence of autumn with each step.", "Leather", "Autumn brown leather stretch boots", 8899m, "Autumn" },
                    { 3, "ER00112018", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Autumn leather stretch boots", 8899m, "Autumn" },
                    { 4, "ER00112022", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots autumn leather black", 9899m, "Autumn" },
                    { 5, "ER00112011", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Black autumn leather stretch boots", 9899m, "Autumn" },
                    { 6, "ER00113851", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Black demi-season boots", 8799m, "Autumn" },
                    { 7, "ER00112023", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots-stockings leather black", 9989m, "Autumn" },
                    { 8, "ER00114318", 8, "Burgundy", "Estro ER00112018 Burgundy Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots-pipes with wide freebies are burgundy", 9989m, "Autumn" },
                    { 9, "ER00112298", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Black leather Cossack boots", 8799m, "Autumn" },
                    { 10, "ER00112123", 8, "Black", "Estro ER00112018 Black Leather Stretch Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 black leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots-stockings on a stiletto are black", 8699m, "Autumn" },
                    { 11, "ER00112122", 8, "Milk", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Milk stiletto stocking boots", 8699m, "Autumn" },
                    { 12, "ER00114239", 8, "Brown", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots-stockings on a stiletto are brown", 8399m, "Autumn" },
                    { 13, "ER00114240", 8, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Boots-stockings on a stiletto are black", 8399m, "Autumn" },
                    { 14, "ER00113949", 7, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Ankle boots are black", 2890m, "Autumn" },
                    { 15, "ER00111942", 12, "Black", "Estro ER00112018 Milk Leather Boots\r\n\r\nElevate your autumn style with the Estro ER00112018 Milk leather stretch boots. Crafted with a blend of high-quality leather and stretch material, these boots seamlessly marry fashion and comfort. The stretch element provides elasticity, ensuring a snug and flexible fit for easy wear. The sleek black color adds versatility, allowing for effortless pairing with various outfit styles.", "Leather", "Winter boots", 2290m, "Winter" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "ImagePath", "ProductId" },
                values: new object[,]
                {
                    { 1, "Product1_1.jpg", 1 },
                    { 2, "Product1_2.jpg", 1 },
                    { 3, "Product1_3.jpg", 1 },
                    { 4, "Product1_4.jpg", 1 },
                    { 5, "Product1_5.jpg", 1 },
                    { 6, "Product1_6.jpg", 1 },
                    { 7, "Product2_1.jpg", 2 },
                    { 8, "Product2_2.jpg", 2 },
                    { 9, "Product2_3.jpg", 2 },
                    { 10, "Product2_4.jpg", 2 },
                    { 11, "Product2_5.jpg", 2 },
                    { 12, "Product2_6.jpg", 2 },
                    { 13, "Product2_7.jpg", 2 },
                    { 14, "Product2_8.jpg", 2 },
                    { 15, "Product2_9.jpg", 2 },
                    { 16, "Product3_1.jpg", 3 },
                    { 17, "Product3_2.jpg", 3 },
                    { 18, "Product3_3.jpg", 3 },
                    { 19, "Product3_4.jpg", 3 },
                    { 20, "Product3_5.jpg", 3 },
                    { 21, "Product4_1.jpg", 4 },
                    { 22, "Product4_2.jpg", 4 },
                    { 23, "Product4_3.jpg", 4 },
                    { 24, "Product4_4.jpg", 4 },
                    { 25, "Product4_5.jpg", 4 },
                    { 26, "Product4_6.jpg", 4 },
                    { 27, "Product5_1.jpg", 5 },
                    { 28, "Product5_2.jpg", 5 },
                    { 29, "Product5_3.jpg", 5 },
                    { 30, "Product5_4.jpg", 5 },
                    { 31, "Product5_5.jpg", 5 },
                    { 32, "Product5_6.jpg", 5 },
                    { 33, "Product6_1.jpg", 6 },
                    { 34, "Product6_2.jpg", 6 },
                    { 35, "Product6_3.jpg", 6 },
                    { 36, "Product6_4.jpg", 6 },
                    { 37, "Product6_5.jpg", 6 },
                    { 38, "Product6_6.jpg", 6 },
                    { 39, "Product7_1.jpg", 7 },
                    { 40, "Product7_2.jpg", 7 },
                    { 41, "Product7_3.jpg", 7 },
                    { 42, "Product7_4.jpg", 7 },
                    { 43, "Product7_5.jpg", 7 },
                    { 44, "Product8_1.jpg", 8 },
                    { 45, "Product8_2.jpg", 8 },
                    { 46, "Product8_3.jpg", 8 },
                    { 47, "Product8_4.jpg", 8 },
                    { 48, "Product8_5.jpg", 8 },
                    { 49, "Product8_6.jpg", 8 },
                    { 50, "Product8_7.jpg", 8 },
                    { 51, "Product9_1.jpg", 9 },
                    { 52, "Product9_2.jpg", 9 },
                    { 53, "Product9_3.jpg", 9 },
                    { 54, "Product9_4.jpg", 9 },
                    { 55, "Product9_5.jpg", 9 },
                    { 56, "Product9_6.jpg", 9 },
                    { 57, "Product10_1.jpg", 10 },
                    { 58, "Product10_2.jpg", 10 },
                    { 59, "Product10_3.jpg", 10 },
                    { 60, "Product10_4.jpg", 10 },
                    { 61, "Product10_5.jpg", 10 },
                    { 62, "Product10_6.jpg", 10 },
                    { 63, "Product10_7.jpg", 10 },
                    { 64, "Product10_8.jpg", 10 },
                    { 65, "Product11_1.jpg", 11 },
                    { 66, "Product11_2.jpg", 11 },
                    { 67, "Product11_3.jpg", 11 },
                    { 68, "Product11_4.jpg", 11 },
                    { 69, "Product11_5.jpg", 11 },
                    { 70, "Product11_6.jpg", 11 },
                    { 71, "Product12_1.jpg", 12 },
                    { 72, "Product12_2.jpg", 12 },
                    { 73, "Product12_3.jpg", 12 },
                    { 74, "Product12_4.jpg", 12 },
                    { 75, "Product12_5.jpg", 12 },
                    { 76, "Product12_6.jpg", 12 },
                    { 77, "Product13_1.jpg", 13 },
                    { 78, "Product13_2.jpg", 13 },
                    { 79, "Product13_3.jpg", 13 },
                    { 80, "Product13_4.jpg", 13 },
                    { 81, "Product13_5.jpg", 13 },
                    { 82, "Product13_6.jpg", 13 },
                    { 83, "Product14_1.jpg", 14 },
                    { 84, "Product14_2.jpg", 14 },
                    { 85, "Product14_3.jpg", 14 },
                    { 86, "Product14_4.jpg", 14 },
                    { 87, "Product14_5.jpg", 14 },
                    { 88, "Product14_6.jpg", 14 },
                    { 89, "Product15_1.jpg", 15 },
                    { 90, "Product15_2.jpg", 15 },
                    { 91, "Product15_3.jpg", 15 },
                    { 92, "Product15_4.jpg", 15 },
                    { 93, "Product15_5.jpg", 15 },
                    { 94, "Product15_6.jpg", 15 }
                });

            migrationBuilder.InsertData(
                table: "Storage",
                columns: new[] { "Id", "ProductId", "ProductQuantity", "Size", "inStock" },
                values: new object[,]
                {
                    { 1, 1, 8, 36, true },
                    { 2, 1, 20, 37, true },
                    { 3, 1, 40, 38, true },
                    { 4, 1, 10, 39, true },
                    { 5, 1, 10, 40, true },
                    { 6, 1, 10, 41, true },
                    { 7, 2, 12, 36, true },
                    { 8, 2, 10, 37, true },
                    { 9, 2, 40, 38, true },
                    { 10, 2, 30, 39, true },
                    { 11, 2, 40, 40, true },
                    { 12, 2, 20, 41, true },
                    { 13, 3, 0, 36, false },
                    { 14, 3, 1, 37, true },
                    { 15, 3, 1, 38, true },
                    { 16, 3, 1, 39, true },
                    { 17, 3, 0, 40, false },
                    { 18, 3, 0, 41, false },
                    { 19, 4, 9, 36, true },
                    { 20, 4, 8, 37, true },
                    { 21, 4, 8, 38, true },
                    { 22, 4, 0, 39, false },
                    { 23, 4, 0, 40, false },
                    { 24, 4, 0, 41, false },
                    { 25, 5, 7, 36, true },
                    { 26, 5, 0, 37, false },
                    { 27, 5, 8, 38, true },
                    { 28, 5, 9, 39, true },
                    { 29, 5, 0, 40, false },
                    { 30, 5, 0, 41, false },
                    { 31, 6, 9, 36, true },
                    { 32, 6, 8, 37, true },
                    { 33, 6, 0, 38, false },
                    { 34, 6, 0, 39, false },
                    { 35, 6, 0, 40, false },
                    { 36, 6, 0, 41, false },
                    { 37, 7, 0, 36, false },
                    { 38, 7, 8, 37, true },
                    { 39, 7, 0, 38, false },
                    { 40, 7, 9, 39, true },
                    { 41, 7, 8, 40, false },
                    { 42, 7, 0, 41, false },
                    { 43, 8, 0, 36, false },
                    { 44, 8, 4, 37, true },
                    { 45, 8, 0, 38, false },
                    { 46, 8, 8, 39, true },
                    { 47, 8, 0, 40, false },
                    { 48, 8, 0, 41, false },
                    { 49, 9, 5, 36, true },
                    { 50, 9, 0, 37, false },
                    { 51, 9, 0, 38, false },
                    { 52, 9, 0, 39, false },
                    { 53, 9, 7, 40, true },
                    { 54, 9, 0, 41, false },
                    { 55, 10, 0, 36, false },
                    { 56, 10, 0, 37, false },
                    { 57, 10, 10, 38, true },
                    { 58, 10, 10, 39, true },
                    { 59, 10, 0, 40, false },
                    { 60, 10, 0, 41, false },
                    { 61, 11, 0, 36, false },
                    { 62, 11, 10, 37, true },
                    { 63, 11, 10, 38, true },
                    { 64, 11, 10, 39, true },
                    { 65, 11, 0, 40, false },
                    { 66, 11, 0, 41, false },
                    { 67, 12, 0, 36, false },
                    { 68, 12, 10, 37, true },
                    { 69, 12, 50, 38, true },
                    { 70, 12, 10, 39, true },
                    { 71, 12, 0, 40, false },
                    { 72, 12, 0, 41, false },
                    { 73, 13, 0, 36, false },
                    { 74, 13, 0, 37, false },
                    { 75, 13, 10, 38, true },
                    { 76, 13, 0, 39, false },
                    { 77, 13, 10, 40, true },
                    { 78, 13, 0, 41, false },
                    { 79, 14, 0, 36, false },
                    { 80, 14, 15, 37, true },
                    { 81, 14, 10, 38, true },
                    { 82, 14, 10, 39, true },
                    { 83, 14, 10, 40, true },
                    { 84, 14, 0, 41, false },
                    { 85, 15, 0, 39, false },
                    { 86, 15, 15, 40, true },
                    { 87, 15, 10, 41, true },
                    { 88, 15, 10, 42, true },
                    { 89, 15, 10, 43, true },
                    { 90, 15, 0, 44, false },
                    { 91, 15, 0, 45, false },
                    { 92, 15, 0, 46, false }
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
                name: "IX_Bag_UserId",
                table: "Bag",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BagItems_BagId",
                table: "BagItems",
                column: "BagId");

            migrationBuilder.CreateIndex(
                name: "IX_BagItems_ProductId",
                table: "BagItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubCategoryId",
                table: "Categories",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_InfoId",
                table: "Options",
                column: "InfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderUser_UsersId",
                table: "OrderUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ProductId",
                table: "Storage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_MainCategoryId",
                table: "SubCategories",
                column: "MainCategoryId");
        }

        /// <inheritdoc />
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
                name: "BagItems");

            migrationBuilder.DropTable(
                name: "ImageForHome");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "OrderUser");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bag");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}
