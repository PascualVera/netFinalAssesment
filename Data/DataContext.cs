
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace finalAssesmentLaBestia.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Claim> Claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitiliazer(modelBuilder).seed();

            modelBuilder.Entity<Owner>()
                .HasKey(b => b.id)
                .HasName("PrimaryKey_Id");

            modelBuilder.Entity<Vehicle>()
               .HasOne<Owner>()
               .WithMany()
               .HasForeignKey(p => p.Owner_id);

            modelBuilder.Entity<Claim>()
                .HasOne<Vehicle>()
                .WithMany()
                .HasForeignKey(p => p.Vehicle_id);
        }
    }
    
}
