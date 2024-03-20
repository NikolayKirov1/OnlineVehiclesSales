using OnlineVehiclesSales.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace OnlineVehiclesSales.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser SellerUser { get; set; } = null!;

        public IdentityUser GuestUser { get; set; } = null!;

        public Seller Seller { get; set; } = null!;

        public TypeSeller FirstTypeSeller { get; set; } = null!;

        public TypeSeller SecondTypeSeller { get; set; } = null!;

        public CarCategory FirstCarCategory { get; set; } = null!;

        public CarCategory SecondCarCategory { get; set; } = null!;

        public CarCategory ThirdCarCategory { get; set; } = null!;

        public CarCategory FourthCarCategory { get; set; } = null!;

        public CarCategory FifthCarCategory { get; set; } = null!;

        public CarCategory SixthCarCategory { get; set; } = null!;

        public CarCategory SeventhCarCategory { get; set; } = null!;

        public CarCategory EighthCarCategory { get; set; } = null!;

        public VanCategory FirstVanCategory { get; set; } = null!;

        public VanCategory SecondVanCategory { get; set; } = null!;

        public VanCategory ThirdVanCategory { get; set; } = null!;

        public VanCategory FourthVanCategory { get; set; } = null!;

        public VanCategory FifthVanCategory { get; set; } = null!;

        public MotorcycleCategory FirstMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory SecondMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory ThirdMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory FourthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory FifthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory SixthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory SeventhMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory EighthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory NinthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory TenthMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory EleventhMotorcycleCategory { get; set; } = null!;

        public MotorcycleCategory TwelfthMotorcycleCategory { get; set; } = null!;

        public TruckCategory FirstTruckCategory { get; set; } = null!;

        public TruckCategory SecondTruckCategory { get; set; } = null!;

        public TruckCategory ThirdTruckCategory { get; set; } = null!;

        public TruckCategory FourthTruckCategory { get; set; } = null!;

        public TruckCategory FifthTruckCategory { get; set; } = null!;

        public TruckCategory SixthTruckCategory { get; set; } = null!;

        public TruckCategory SeventhTruckCategory { get; set; } = null!;

        public TruckCategory EighthTruckCategory { get; set; } = null!;

        public TruckCategory NinthTruckCategory { get; set; } = null!;

        public TruckCategory TenthTruckCategory { get; set; } = null!;

        public TruckCategory EleventhTruckCategory { get; set; } = null!;

        public TruckCategory TwelfthTruckCategory { get; set; } = null!;

        public Car FirstCar { get; set; } = null!;

        public Car SecondCar { get; set; } = null!;

        public Car ThirdCar { get; set; } = null!;

        public Van FirstVan { get; set; } = null!;

        public Van SecondVan { get; set; } = null!;

        public Van ThirdVan { get; set; } = null!;

        public Motorcycle FirstMotorcycle { get; set; } = null!;

        public Motorcycle SecondMotorcycle { get; set; } = null!;

        public Motorcycle ThirdMotorcycle { get; set; } = null!;

        public Truck FirstTruck { get; set; } = null!;

        public Truck SecondTruck { get; set; } = null!;

        public Truck ThirdTruck { get; set; } = null!;

        public Fuel FirstFuel { get; set; } = null!;

        public Fuel SecondFuel { get; set; } = null!;

        public Fuel ThirdFuel { get; set; } = null!;

        public Fuel FourthFuel { get; set; } = null!;

        public Fuel FifthFuel { get; set; } = null!;

        public Fuel SixthFuel { get; set; } = null!;

        public GearsType FirstGearsType { get; set; } = null!;

        public GearsType SecondGearsType { get; set; } = null!;

        public SeedData()
        {
            SeedUsers();
            SeedTypeSellers();
            SeedSellers();
            SeedCarCategories();
            SeedVanCategories();
            SeedMotorcycleCategories();
            SeedTruckCategories();
            SeedFuels();
            SeedGearsTypes();
            SeedCars();
            SeedVans();
            SeedMotorcycles();
            SeedTrucks();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            SellerUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "seller@mail.com",
                NormalizedUserName = "seller@mail.com",
                Email = "seller@mail.com",
                NormalizedEmail = "seller@mail.com"
            };

            SellerUser.PasswordHash =
                 hasher.HashPassword(SellerUser, "seller123");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(SellerUser, "guest123");
        }

        private void SeedTypeSellers()
        {
            FirstTypeSeller = new TypeSeller()
            {
                Id = 1,
                Name = "Private person"
            };

            SecondTypeSeller = new TypeSeller()
            {
                Id = 2,
                Name = "Company"
            };
        }

        private void SeedSellers()
        {
            Seller = new Seller()
            {
                Id = 1,
                PhoneNumber = "+359888888888",
                TypeSellerId = FirstTypeSeller.Id,
                UserId = SellerUser.Id
            };
        }

        private void SeedCarCategories()
        {
            FirstCarCategory = new CarCategory()
            {
                Id = 1,
                Name = "Sedan"
            };

            SecondCarCategory = new CarCategory()
            {
                Id = 2,
                Name = "Hatchback"
            };

            ThirdCarCategory = new CarCategory()
            {
                Id = 3,
                Name = "Station wagon"
            };

            FourthCarCategory = new CarCategory()
            {
                Id = 4,
                Name = "Coupe"
            };

            FifthCarCategory = new CarCategory()
            {
                Id = 5,
                Name = "Convertible"
            };

            SixthCarCategory = new CarCategory()
            {
                Id = 6,
                Name = "Jeep"
            };

            SeventhCarCategory = new CarCategory()
            {
                Id = 7,
                Name = "Pickup"
            };

            EighthCarCategory = new CarCategory()
            {
                Id = 8,
                Name = "Van"
            };
        }

        private void SeedVanCategories()
        {
            FirstVanCategory = new VanCategory()
            {
                Id = 1,
                Name = "Passenger"
            };

            SecondVanCategory = new VanCategory()
            {
                Id = 2,
                Name = "Cargo"
            };

            ThirdVanCategory = new VanCategory()
            {
                Id = 3,
                Name = "Passenger-Cargo"
            };

            FourthVanCategory = new VanCategory()
            {
                Id = 4,
                Name = "Bus"
            };

            FifthVanCategory = new VanCategory()
            {
                Id = 5,
                Name = "Car transporter"
            };
        }

        private void SeedMotorcycleCategories()
        {
            FirstMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 1,
                Name = "ATV"
            };

            SecondMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 2,
                Name = "Buggy"
            };

            ThirdMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 3,
                Name = "Enduro"
            };

            FourthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 4,
                Name = "Snowmobile"
            };

            FifthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 5,
                Name = "Dirt bike"
            };

            SixthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 6,
                Name = "Track bike"
            };

            SeventhMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 7,
                Name = "Scooter"
            };

            EighthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 8,
                Name = "Tourer"
            };

            NinthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 9,
                Name = "Chopper"
            };

            TenthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 10,
                Name = "Super motto"
            };

            EleventhMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 11,
                Name = "Karting"
            };

            TwelfthMotorcycleCategory = new MotorcycleCategory()
            {
                Id = 12,
                Name = "Tricycle"
            };
        }

        private void SeedTruckCategories()
        {
            FirstTruckCategory = new TruckCategory()
            {
                Id = 1,
                Name = "Car transporter"
            };

            SecondTruckCategory = new TruckCategory()
            {
                Id = 2,
                Name = "Fatbed truck"
            };

            ThirdTruckCategory = new TruckCategory()
            {
                Id = 3,
                Name = "Tugboat"
            };

            FourthTruckCategory = new TruckCategory()
            {
                Id = 4,
                Name = "Crane"
            };

            FifthTruckCategory = new TruckCategory()
            {
                Id = 5,
                Name = "Multilift"
            };

            SixthTruckCategory = new TruckCategory()
            {
                Id = 6,
                Name = "Dump truck"
            };

            SeventhTruckCategory = new TruckCategory()
            {
                Id = 7,
                Name = "Wagon"
            };

            EighthTruckCategory = new TruckCategory()
            {
                Id = 8,
                Name = "Cistern"
            };

            NinthTruckCategory = new TruckCategory()
            {
                Id = 9,
                Name = "Trailer"
            };

            TenthTruckCategory = new TruckCategory()
            {
                Id = 10,
                Name = "Garbage truck"
            };

            EleventhTruckCategory = new TruckCategory()
            {
                Id = 11,
                Name = "Hanger truck"
            };

            TwelfthTruckCategory = new TruckCategory()
            {
                Id = 12,
                Name = "Refrigerator truck"
            };
        }

        private void SeedFuels()
        {
            FirstFuel = new Fuel()
            {
                Id = 1,
                Name = "Gasoline"
            };

            SecondFuel = new Fuel()
            {
                Id = 2,
                Name = "Diesel"
            };

            ThirdFuel = new Fuel()
            {
                Id = 3,
                Name = "Gas/Gasoline"
            };

            FourthFuel = new Fuel()
            {
                Id = 4,
                Name = "Methane/Gasoline"
            };

            FifthFuel = new Fuel()
            {
                Id = 5,
                Name = "Hybrid"
            };

            SixthFuel = new Fuel()
            {
                Id = 6,
                Name = "Electricity"
            };
        }

        private void SeedGearsTypes()
        {
            FirstGearsType = new GearsType()
            {
                Id = 1,
                Name = "Manual"
            };

            SecondGearsType = new GearsType()
            {
                Id = 2,
                Name = "Automatic"
            };
        }

        private void SeedCars()
        {
            FirstCar = new Car()
            {
                Id = 1,
                Brand = "Opel",
                Model = "Zafira 1.9cdti",
                Color = "Black metallic",
                Mileage = 208260,
                Horsepower = 136,
                Description = "The car is in very good condition.",
                ImageUrl = "http://localhost:5001/images/cars/OpelZafira.jpg",
                Year = 2016,
                Price = 13999,
                DateAd = DateTime.Now,
                CarCategoryId = EighthCarCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };

            SecondCar = new Car()
            {
                Id = 2,
                Brand = "Audi",
                Model = "A4 2.0TDI",
                Color = "Gray metallic",
                Mileage = 192000,
                Horsepower = 150,
                Description = "The car is in good condition and has tons of extras.",
                ImageUrl = "http://localhost:5001/images/cars/AudiA4.jpg",
                Year = 2013,
                Price = 18900,
                DateAd = DateTime.Now,
                CarCategoryId = ThirdCarCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
            };

            ThirdCar = new Car()
            {
                Id = 3,
                Brand = "BMW",
                Model = "318 1.8i",
                Color = "Blue",
                Mileage = 330000,
                Horsepower = 118,
                Description = "The car is in good condition.",
                ImageUrl = "http://localhost:5001/images/cars/BMW318.jpg",
                Year = 1998,
                Price = 4000,
                DateAd = DateTime.Now,
                CarCategoryId = FirstCarCategory.Id,
                FuelId = ThirdFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
            };
        }

        private void SeedVans()
        {
            FirstVan = new Van()
            {
                Id = 1,
                Brand = "Mercedes-Benz",
                Model = "Sprinter",
                Color = "Yellow metallic",
                Mileage = 437634,
                Horsepower = 190,
                Description = "New importation!!! No rust or corrosion on the body.",
                ImageUrl = "http://localhost:5001/images/vans/Mercedes-BenzSprinter.jpg",
                Year = 2015,
                Price = 33300,
                DateAd = DateTime.Now,
                VanCategoryId = FifthVanCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };

            SecondVan = new Van()
            {
                Id = 2,
                Brand = "Ford",
                Model = "Transit 2.2TDCI",
                Color = "White",
                Mileage = 186000,
                Horsepower = 125,
                Description = "Excellent condition. Brought to one's own motion.",
                ImageUrl = "http://localhost:5001/images/vans/FordTransit.jpg",
                Year = 2016,
                Price = 18800,
                DateAd = DateTime.Now,
                VanCategoryId = SecondVanCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id
            };

            ThirdVan = new Van()
            {
                Id = 3,
                Brand = "VW",
                Model = "Multivan 2.5TDI",
                Color = "Black",
                Mileage = 223000,
                Horsepower = 131,
                Description = "The van was imported from Germany in good technical and visual condition.",
                ImageUrl = "http://localhost:5001/images/vans/VWMultivan.jpg",
                Year = 2005,
                Price = 18999,
                DateAd = DateTime.Now,
                VanCategoryId = FifthVanCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id
            };
        }


        private void SeedMotorcycles()
        {
            FirstMotorcycle = new Motorcycle()
            {
                Id = 1,
                Brand = "Harley Davidson",
                Model = "Road King 128",
                Color = "Black",
                Mileage = 30000,
                Horsepower = 121,
                Description = "Import USA. Immaculate condition. All paid with registration.",
                ImageUrl = "http://localhost:5001/images/motorcycles/HarleyDavidson.jpg",
                Year = 2019,
                Price = 25000,
                DateAd = DateTime.Now,
                MotorcycleCategoryId = NinthMotorcycleCategory.Id,
                FuelId = FirstFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };

            SecondMotorcycle = new Motorcycle()
            {
                Id = 2,
                Brand = "BMW",
                Model = "F650 ST",
                Color = "White",
                Mileage = 51000,
                Horsepower = 48,
                Description = "The bike is in good general condition. Needs service.",
                ImageUrl = "http://localhost:5001/images/motorcycles/BmwF650ST.jpg",
                Year = 1996,
                Price = 2099,
                DateAd = DateTime.Now,
                MotorcycleCategoryId = EighthMotorcycleCategory.Id,
                FuelId = FirstFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
            };

            ThirdMotorcycle = new Motorcycle()
            {
                Id = 3,
                Brand = "Honda",
                Model = "CBR 600",
                Color = "Blue/Red",
                Mileage = 76600,
                Horsepower = 106,
                Description = "New import with all registration documents available, sale with contract without notary fees!",
                ImageUrl = "http://localhost:5001/images/motorcycles/HondaCBR600.jpg",
                Year = 2002,
                Price = 3699,
                DateAd = DateTime.Now,
                MotorcycleCategoryId = SixthMotorcycleCategory.Id,
                FuelId = FirstFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
            };
        }

        private void SeedTrucks()
        {
            FirstTruck = new Truck()
            {
                Id = 1,
                Brand = "Man",
                Model = "TGA 18.530",
                Color = "White",
                Mileage = 759519,
                Horsepower = 530,
                Description = "At 50,000 km after overhaul. The truck has exterior marks.",
                ImageUrl = "http://localhost:5001/images/trucks/ManTGA18.530.jpg",
                Year = 1998,
                Price = 50000,
                DateAd = DateTime.Now,
                TruckCategoryId = ThirdTruckCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id,
                BuyerId = GuestUser.Id
            };

            SecondTruck = new Truck()
            {
                Id = 2,
                Brand = "Scania",
                Model = "R410 Highline Mega",
                Color = "Red",
                Mileage = 982941,
                Horsepower = 410,
                Description = "Full service history, excellent technical condition, new fuel pump, serviced 30,000 km ago.",
                ImageUrl = "http://localhost:5001/images/trucks/ScaniaR410HighlineMega.jpg",
                Year = 2015,
                Price = 43750,
                DateAd = DateTime.Now,
                TruckCategoryId = ThirdTruckCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = SecondGearsType.Id,
                SellerId = Seller.Id
            };

            ThirdTruck = new Truck()
            {
                Id = 3,
                Brand = "Iveco",
                Model = "80e15 4.0 TD",
                Color = "White",
                Mileage = 362500,
                Horsepower = 150,
                Description = "Newly imported, the truck has a 2-meter crane, lifts 1.5 tons of 6,500 kilos and a 10-ton hydraulic winch.",
                ImageUrl = "http://localhost:5001/images/trucks/Iveco80e154.0TD.jpg",
                Year = 1995,
                Price = 12999,
                DateAd = DateTime.Now,
                TruckCategoryId = FourthTruckCategory.Id,
                FuelId = SecondFuel.Id,
                GearsTypeId = FirstGearsType.Id,
                SellerId = Seller.Id
            };
        }
    }
}
