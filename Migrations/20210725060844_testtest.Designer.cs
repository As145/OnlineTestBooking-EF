// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTestBooking_EF.Data;

namespace OnlineTestBooking_EF.Migrations
{
    [DbContext(typeof(OnlineTestBooking_EFContext))]
    [Migration("20210725060844_testtest")]
    partial class testtest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Booking", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fee")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RegistrationID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Registration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Contact")
                        .HasColumnType("int");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("RegistrationID")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RegistrationID");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Booking", b =>
                {
                    b.HasOne("OnlineTestBooking_EF.Models.Registration", "Registration")
                        .WithMany("Bookings")
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Result", b =>
                {
                    b.HasOne("OnlineTestBooking_EF.Models.Registration", "Registration")
                        .WithMany("Results")
                        .HasForeignKey("RegistrationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registration");
                });

            modelBuilder.Entity("OnlineTestBooking_EF.Models.Registration", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
