// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalAssesmentLaBestia.Data;

#nullable disable

namespace finalAssesmentLaBestia.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221118112643_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Claim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("claimType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("vehicle_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("vehicle_id");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Owner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id")
                        .HasName("PrimaryKey_Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("owner_id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Claim", b =>
                {
                    b.HasOne("finalAssesmentLaBestia.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("vehicle_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("finalAssesmentLaBestia.Models.Vehicle", b =>
                {
                    b.HasOne("finalAssesmentLaBestia.Models.Owner", null)
                        .WithMany()
                        .HasForeignKey("owner_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
