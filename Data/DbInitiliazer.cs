using Microsoft.EntityFrameworkCore;

namespace finalAssesmentLaBestia.Data
{
    public class DbInitiliazer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitiliazer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void seed()
        {
            modelBuilder.Entity<Owner>().HasData(
                    new Owner() { id = 1, FirstName = "Pascual",LastName="Vera",DriverLicense = "123456F"},
                    new Owner() { id = 2, FirstName = "David", LastName = "Dec", DriverLicense = "983473H" },
                    new Owner() { id = 3, FirstName = "Antonio", LastName = "Ortiz", DriverLicense = "429384D" }

                );

            modelBuilder.Entity<Vehicle>().HasData(
                    new Vehicle() { id = 1,Brand = "Ferrari Horse",Vin = "48790538475F",Color = "Red",Year = 2009, Owner_id = 1 },
                    new Vehicle() { id = 2,Brand = "Ferrari Testarosa",Vin = "58475983G", Color = "Black",Year = 2010, Owner_id = 2 },
                    new Vehicle() { id = 3,Brand = "Ferrari Purosangue",Vin = "45450934850K", Color = "Blue",Year = 2012, Owner_id = 3 }
                );

            modelBuilder.Entity<Claim>().HasData(
                    new Claim() { id = 1,Description = "the car will not start",Status = "In progress",Date = new DateTime(2022,11,17), Vehicle_id = 1},
                    new Claim() { id = 2, Description = "broken window", Status = "In progress", Date = new DateTime(2022, 11, 15), Vehicle_id = 2},
                    new Claim() { id = 3, Description = "oil leakage", Status = "In progress", Date = new DateTime(2022, 11, 16), Vehicle_id = 3}
                );
        }
    }
}
