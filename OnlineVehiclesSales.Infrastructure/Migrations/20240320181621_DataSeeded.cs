using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVehiclesSales.Infrastructure.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_GearsTypes_GearsTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_Fuels_FuelId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_GearsTypes_GearsTypeId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_MotorcycleCategories_MotorcycleCategoryId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_Sellers_SellerId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Fuels_FuelId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_GearsTypes_GearsTypeId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Sellers_SellerId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_TruckCategories_TruckCategoryId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_Fuels_FuelId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_GearsTypes_GearsTypeId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_Sellers_SellerId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_VanCategories_VanCategoryId",
                table: "Vans");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "eba48d96-9f93-4288-9c42-1931e7401953", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEAMguUfkcvKq8ssRR1aMlqZyEm6O8gSiYzrjG0BNAAqjpJZ2uM7pqOmtr1HKYW1hWw==", null, false, "442cbe7b-3256-49a0-9b25-8ceaaa0cd5d4", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "4ff2a8cd-fbbd-417b-91ce-18291b88e482", "seller@mail.com", false, false, null, "seller@mail.com", "seller@mail.com", "AQAAAAEAACcQAAAAELNy//kFw24/BiWKPiaxD9A0Vamb/d6lkKNUTDZog3pakudxOnEs2LKmVdkEVwR0rg==", null, false, "dc17bb10-3ccd-4e13-8128-d4550d12f91c", false, "seller@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Hatchback" },
                    { 3, "Station wagon" },
                    { 4, "Coupe" },
                    { 5, "Convertible" },
                    { 6, "Jeep" },
                    { 7, "Pickup" },
                    { 8, "Van" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gasoline" },
                    { 2, "Diesel" },
                    { 3, "Gas/Gasoline" },
                    { 4, "Methane/Gasoline" },
                    { 5, "Hybrid" },
                    { 6, "Electricity" }
                });

            migrationBuilder.InsertData(
                table: "GearsTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manual" },
                    { 2, "Automatic" }
                });

            migrationBuilder.InsertData(
                table: "MotorcycleCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ATV" },
                    { 2, "Buggy" },
                    { 3, "Enduro" },
                    { 4, "Snowmobile" },
                    { 5, "Dirt bike" },
                    { 6, "Track bike" },
                    { 7, "Scooter" },
                    { 8, "Tourer" },
                    { 9, "Chopper" },
                    { 10, "Super motto" },
                    { 11, "Karting" },
                    { 12, "Tricycle" }
                });

            migrationBuilder.InsertData(
                table: "TruckCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Car transporter" },
                    { 2, "Fatbed truck" },
                    { 3, "Tugboat" },
                    { 4, "Crane" },
                    { 5, "Multilift" },
                    { 6, "Dump truck" },
                    { 7, "Wagon" },
                    { 8, "Cistern" },
                    { 9, "Trailer" },
                    { 10, "Garbage truck" },
                    { 11, "Hanger truck" },
                    { 12, "Refrigerator truck" }
                });

            migrationBuilder.InsertData(
                table: "TypeSellers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Private person" },
                    { 2, "Company" }
                });

            migrationBuilder.InsertData(
                table: "VanCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Passenger" },
                    { 2, "Cargo" },
                    { 3, "Passenger-Cargo" },
                    { 4, "Bus" },
                    { 5, "Car transporter" }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "PhoneNumber", "TypeSellerId", "UserId" },
                values: new object[] { 1, "+359888888888", 1, "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "BuyerId", "CarCategoryId", "Color", "DateAd", "Description", "FuelId", "GearsTypeId", "Horsepower", "ImageUrl", "Mileage", "Model", "Price", "SellerId", "Year" },
                values: new object[,]
                {
                    { 1, "Opel", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 8, "Black metallic", new DateTime(2024, 3, 20, 20, 16, 18, 567, DateTimeKind.Local).AddTicks(6763), "The car is in very good condition.", 2, 1, 136, "http://localhost:5001/images/cars/OpelZafira.jpg", 208260, "Zafira 1.9cdti", 13999, 1, 2016 },
                    { 2, "Audi", null, 3, "Gray metallic", new DateTime(2024, 3, 20, 20, 16, 18, 567, DateTimeKind.Local).AddTicks(6826), "The car is in good condition and has tons of extras.", 2, 1, 150, "http://localhost:5001/images/cars/AudiA4.jpg", 192000, "A4 2.0TDI", 18900, 1, 2013 },
                    { 3, "BMW", null, 1, "Blue", new DateTime(2024, 3, 20, 20, 16, 18, 567, DateTimeKind.Local).AddTicks(6836), "The car is in good condition.", 3, 1, 118, "http://localhost:5001/images/cars/BMW318.jpg", 330000, "318 1.8i", 4000, 1, 1998 }
                });

            migrationBuilder.InsertData(
                table: "Motorcycles",
                columns: new[] { "Id", "Brand", "BuyerId", "Color", "DateAd", "Description", "FuelId", "GearsTypeId", "Horsepower", "ImageUrl", "Mileage", "Model", "MotorcycleCategoryId", "Price", "SellerId", "Year" },
                values: new object[,]
                {
                    { 1, "Harley Davidson", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Black", new DateTime(2024, 3, 20, 20, 16, 18, 782, DateTimeKind.Local).AddTicks(4719), "Import USA. Immaculate condition. All paid with registration.", 1, 1, 121, "http://localhost:5001/images/motorcycles/HarleyDavidson.jpg", 30000, "Road King 128", 9, 25000, 1, 2019 },
                    { 2, "BMW", null, "White", new DateTime(2024, 3, 20, 20, 16, 18, 782, DateTimeKind.Local).AddTicks(4738), "The bike is in good general condition. Needs service.", 1, 1, 48, "http://localhost:5001/images/motorcycles/BmwF650ST.jpg", 51000, "F650 ST", 8, 2099, 1, 1996 },
                    { 3, "Honda", null, "Blue/Red", new DateTime(2024, 3, 20, 20, 16, 18, 782, DateTimeKind.Local).AddTicks(4747), "New import with all registration documents available, sale with contract without notary fees!", 1, 1, 106, "http://localhost:5001/images/motorcycles/HondaCBR600.jpg", 76600, "CBR 600", 6, 3699, 1, 2002 }
                });

            migrationBuilder.InsertData(
                table: "Trucks",
                columns: new[] { "Id", "Brand", "BuyerId", "Color", "DateAd", "Description", "FuelId", "GearsTypeId", "Horsepower", "ImageUrl", "Mileage", "Model", "Price", "SellerId", "TruckCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, "Man", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "White", new DateTime(2024, 3, 20, 20, 16, 18, 939, DateTimeKind.Local).AddTicks(1161), "At 50,000 km after overhaul. The truck has exterior marks.", 2, 1, 530, "http://localhost:5001/images/trucks/ManTGA18.530.jpg", 759519, "TGA 18.530", 50000, 1, 3, 1998 },
                    { 2, "Scania", null, "Red", new DateTime(2024, 3, 20, 20, 16, 18, 939, DateTimeKind.Local).AddTicks(1172), "Full service history, excellent technical condition, new fuel pump, serviced 30,000 km ago.", 2, 2, 410, "http://localhost:5001/images/trucks/ScaniaR410HighlineMega.jpg", 982941, "R410 Highline Mega", 43750, 1, 3, 2015 },
                    { 3, "Iveco", null, "White", new DateTime(2024, 3, 20, 20, 16, 18, 939, DateTimeKind.Local).AddTicks(1181), "Newly imported, the truck has a 2-meter crane, lifts 1.5 tons of 6,500 kilos and a 10-ton hydraulic winch.", 2, 1, 150, "http://localhost:5001/images/trucks/Iveco80e154.0TD.jpg", 362500, "80e15 4.0 TD", 12999, 1, 4, 1995 }
                });

            migrationBuilder.InsertData(
                table: "Vans",
                columns: new[] { "Id", "Brand", "BuyerId", "Color", "DateAd", "Description", "FuelId", "GearsTypeId", "Horsepower", "ImageUrl", "Mileage", "Model", "Price", "SellerId", "VanCategoryId", "Year" },
                values: new object[,]
                {
                    { 1, "Mercedes-Benz", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Yellow metallic", new DateTime(2024, 3, 20, 20, 16, 19, 165, DateTimeKind.Local).AddTicks(8833), "New importation!!! No rust or corrosion on the body.", 2, 1, 190, "http://localhost:5001/images/vans/Mercedes-BenzSprinter.jpg", 437634, "Sprinter", 33300, 1, 5, 2015 },
                    { 2, "Ford", null, "White", new DateTime(2024, 3, 20, 20, 16, 19, 165, DateTimeKind.Local).AddTicks(8848), "Excellent condition. Brought to one's own motion.", 2, 1, 125, "http://localhost:5001/images/vans/FordTransit.jpg", 186000, "Transit 2.2TDCI", 18800, 1, 2, 2016 },
                    { 3, "VW", null, "Black", new DateTime(2024, 3, 20, 20, 16, 19, 165, DateTimeKind.Local).AddTicks(8859), "The van was imported from Germany in good technical and visual condition.", 2, 1, 131, "http://localhost:5001/images/vans/VWMultivan.jpg", 223000, "Multivan 2.5TDI", 18999, 1, 5, 2005 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId",
                principalTable: "CarCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_GearsTypes_GearsTypeId",
                table: "Cars",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_Fuels_FuelId",
                table: "Motorcycles",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_GearsTypes_GearsTypeId",
                table: "Motorcycles",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_MotorcycleCategories_MotorcycleCategoryId",
                table: "Motorcycles",
                column: "MotorcycleCategoryId",
                principalTable: "MotorcycleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_Sellers_SellerId",
                table: "Motorcycles",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Fuels_FuelId",
                table: "Trucks",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_GearsTypes_GearsTypeId",
                table: "Trucks",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Sellers_SellerId",
                table: "Trucks",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_TruckCategories_TruckCategoryId",
                table: "Trucks",
                column: "TruckCategoryId",
                principalTable: "TruckCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_Fuels_FuelId",
                table: "Vans",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_GearsTypes_GearsTypeId",
                table: "Vans",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_Sellers_SellerId",
                table: "Vans",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_VanCategories_VanCategoryId",
                table: "Vans",
                column: "VanCategoryId",
                principalTable: "VanCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_GearsTypes_GearsTypeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_Fuels_FuelId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_GearsTypes_GearsTypeId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_MotorcycleCategories_MotorcycleCategoryId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorcycles_Sellers_SellerId",
                table: "Motorcycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Fuels_FuelId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_GearsTypes_GearsTypeId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Sellers_SellerId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_TruckCategories_TruckCategoryId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_Fuels_FuelId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_GearsTypes_GearsTypeId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_Sellers_SellerId",
                table: "Vans");

            migrationBuilder.DropForeignKey(
                name: "FK_Vans_VanCategories_VanCategoryId",
                table: "Vans");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Motorcycles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trucks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypeSellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VanCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VanCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VanCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Fuels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GearsTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GearsTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MotorcycleCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TruckCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "VanCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VanCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.DeleteData(
                table: "TypeSellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarCategories_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId",
                principalTable: "CarCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Fuels_FuelId",
                table: "Cars",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_GearsTypes_GearsTypeId",
                table: "Cars",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Sellers_SellerId",
                table: "Cars",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_Fuels_FuelId",
                table: "Motorcycles",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_GearsTypes_GearsTypeId",
                table: "Motorcycles",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_MotorcycleCategories_MotorcycleCategoryId",
                table: "Motorcycles",
                column: "MotorcycleCategoryId",
                principalTable: "MotorcycleCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorcycles_Sellers_SellerId",
                table: "Motorcycles",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Fuels_FuelId",
                table: "Trucks",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_GearsTypes_GearsTypeId",
                table: "Trucks",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Sellers_SellerId",
                table: "Trucks",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_TruckCategories_TruckCategoryId",
                table: "Trucks",
                column: "TruckCategoryId",
                principalTable: "TruckCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_Fuels_FuelId",
                table: "Vans",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_GearsTypes_GearsTypeId",
                table: "Vans",
                column: "GearsTypeId",
                principalTable: "GearsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_Sellers_SellerId",
                table: "Vans",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vans_VanCategories_VanCategoryId",
                table: "Vans",
                column: "VanCategoryId",
                principalTable: "VanCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
