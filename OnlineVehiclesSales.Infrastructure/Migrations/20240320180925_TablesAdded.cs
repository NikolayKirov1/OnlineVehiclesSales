using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVehiclesSales.Infrastructure.Migrations
{
    public partial class TablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Car category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Car category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                },
                comment: "Car category");

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Fuel identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Fuel name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                },
                comment: "Type of fuel");

            migrationBuilder.CreateTable(
                name: "GearsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Type identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Name of type of gears")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearsTypes", x => x.Id);
                },
                comment: "Type of gears");

            migrationBuilder.CreateTable(
                name: "MotorcycleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Motorcycle category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Motorcycle category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorcycleCategories", x => x.Id);
                },
                comment: "Motorcycle category");

            migrationBuilder.CreateTable(
                name: "TruckCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Truck category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckCategories", x => x.Id);
                },
                comment: "Truck category");

            migrationBuilder.CreateTable(
                name: "TypeSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Tipe seller identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, comment: "Type seller name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeSellers", x => x.Id);
                },
                comment: "Type seller");

            migrationBuilder.CreateTable(
                name: "VanCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Van category identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Van category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VanCategories", x => x.Id);
                },
                comment: "Van category");

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Seller identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeSellerId = table.Column<int>(type: "int", nullable: false, comment: "Type identifier of the seller"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Seller's phone"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sellers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sellers_TypeSellers_TypeSellerId",
                        column: x => x.TypeSellerId,
                        principalTable: "TypeSellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Vehicle seller");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Car identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Brand of the car"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Model of the car"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Color of the car"),
                    Mileage = table.Column<int>(type: "int", nullable: false, comment: "Mileage of the car"),
                    Horsepower = table.Column<int>(type: "int", nullable: false, comment: "Horsepower of the car"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Car description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Car image url"),
                    Year = table.Column<int>(type: "int", nullable: false, comment: "Year of manufacture of the car"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "Price of the car"),
                    DateAd = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the ad"),
                    CarCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier of the car"),
                    FuelId = table.Column<int>(type: "int", nullable: false, comment: "Fuel identifier of the car"),
                    GearsTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of gears identifier of the car"),
                    SellerId = table.Column<int>(type: "int", nullable: false, comment: "Seller identifier of the car"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "User id of the buyer of the car")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_GearsTypes_GearsTypeId",
                        column: x => x.GearsTypeId,
                        principalTable: "GearsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Car to sell");

            migrationBuilder.CreateTable(
                name: "Motorcycles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Motorcycle identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Brand of the motorcycle"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Model of the motorcycle"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Color of the motorcycle"),
                    Mileage = table.Column<int>(type: "int", nullable: false, comment: "Mileage of the motorcycle"),
                    Horsepower = table.Column<int>(type: "int", nullable: false, comment: "Horsepower of the motorcycle"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Motorcycle description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Motorcycle image url"),
                    Year = table.Column<int>(type: "int", nullable: false, comment: "Year of manufacture of the motorcycle"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "Price of the motorcycle"),
                    DateAd = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the ad"),
                    MotorcycleCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier of the motorcycle"),
                    FuelId = table.Column<int>(type: "int", nullable: false, comment: "Fuel identifier of the motorcycle"),
                    GearsTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of gears identifier of the motorcycle"),
                    SellerId = table.Column<int>(type: "int", nullable: false, comment: "Seller identifier of the motorcycle"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "User id of the buyer of the motorcycle")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motorcycles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motorcycles_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycles_GearsTypes_GearsTypeId",
                        column: x => x.GearsTypeId,
                        principalTable: "GearsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycles_MotorcycleCategories_MotorcycleCategoryId",
                        column: x => x.MotorcycleCategoryId,
                        principalTable: "MotorcycleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motorcycles_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Motorcycle to sell");

            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Truck identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Brand of the truck"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Model of the truck"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Color of the truck"),
                    Mileage = table.Column<int>(type: "int", nullable: false, comment: "Mileage of the truck"),
                    Horsepower = table.Column<int>(type: "int", nullable: false, comment: "Horsepower of the truck"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Truck description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Truck image url"),
                    Year = table.Column<int>(type: "int", nullable: false, comment: "Year of manufacture of the truck"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "Price of the truck"),
                    DateAd = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the ad"),
                    TruckCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier of the truck"),
                    FuelId = table.Column<int>(type: "int", nullable: false, comment: "Fuel identifier of the truck"),
                    GearsTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of gears identifier of the truck"),
                    SellerId = table.Column<int>(type: "int", nullable: false, comment: "Seller identifier of the truck"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "User id of the buyer of the truck")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trucks_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_GearsTypes_GearsTypeId",
                        column: x => x.GearsTypeId,
                        principalTable: "GearsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trucks_TruckCategories_TruckCategoryId",
                        column: x => x.TruckCategoryId,
                        principalTable: "TruckCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Truck to sell");

            migrationBuilder.CreateTable(
                name: "Vans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Van identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Brand of the van"),
                    Model = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Model of the van"),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Color of the van"),
                    Mileage = table.Column<int>(type: "int", nullable: false, comment: "Mileage of the van"),
                    Horsepower = table.Column<int>(type: "int", nullable: false, comment: "Horsepower of the van"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Van description"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Van image url"),
                    Year = table.Column<int>(type: "int", nullable: false, comment: "Year of manufacture of the van"),
                    Price = table.Column<int>(type: "int", nullable: false, comment: "Price of the van"),
                    DateAd = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of the ad"),
                    VanCategoryId = table.Column<int>(type: "int", nullable: false, comment: "Category identifier of the van"),
                    FuelId = table.Column<int>(type: "int", nullable: false, comment: "Fuel identifier of the van"),
                    GearsTypeId = table.Column<int>(type: "int", nullable: false, comment: "Type of gears identifier of the van"),
                    SellerId = table.Column<int>(type: "int", nullable: false, comment: "Seller identifier of the van"),
                    BuyerId = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "User id of the buyer of the van")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vans_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vans_GearsTypes_GearsTypeId",
                        column: x => x.GearsTypeId,
                        principalTable: "GearsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vans_Sellers_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Sellers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vans_VanCategories_VanCategoryId",
                        column: x => x.VanCategoryId,
                        principalTable: "VanCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Van to sell");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelId",
                table: "Cars",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GearsTypeId",
                table: "Cars",
                column: "GearsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SellerId",
                table: "Cars",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_FuelId",
                table: "Motorcycles",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_GearsTypeId",
                table: "Motorcycles",
                column: "GearsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_MotorcycleCategoryId",
                table: "Motorcycles",
                column: "MotorcycleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorcycles_SellerId",
                table: "Motorcycles",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_TypeSellerId",
                table: "Sellers",
                column: "TypeSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sellers_UserId",
                table: "Sellers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_FuelId",
                table: "Trucks",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_GearsTypeId",
                table: "Trucks",
                column: "GearsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_SellerId",
                table: "Trucks",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trucks_TruckCategoryId",
                table: "Trucks",
                column: "TruckCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vans_FuelId",
                table: "Vans",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Vans_GearsTypeId",
                table: "Vans",
                column: "GearsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vans_SellerId",
                table: "Vans",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Vans_VanCategoryId",
                table: "Vans",
                column: "VanCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Motorcycles");

            migrationBuilder.DropTable(
                name: "Trucks");

            migrationBuilder.DropTable(
                name: "Vans");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropTable(
                name: "MotorcycleCategories");

            migrationBuilder.DropTable(
                name: "TruckCategories");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "GearsTypes");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "VanCategories");

            migrationBuilder.DropTable(
                name: "TypeSellers");
        }
    }
}
