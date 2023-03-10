// <auto-generated />
using System;
using CalorieCountingApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalorieCountingApplication.Migrations
{
    [DbContext(typeof(CalorieCountingApplicationContext))]
    [Migration("20230221024503_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalorieCountingApplication.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("CalorieCountingApplication.Models.ExerciseEntry", b =>
                {
                    b.Property<int>("ExerciseEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExerciseEntryId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseEntryId");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseEntries");
                });

            modelBuilder.Entity("CalorieCountingApplication.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<int?>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UnitOfMeasurement")
                        .HasColumnType("int");

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("CalorieCountingApplication.Models.FoodEntry", b =>
                {
                    b.Property<int>("FoodEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodEntryId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CalorieCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("FoodEntryId");

                    b.HasIndex("FoodId");

                    b.ToTable("FoodEntries");
                });

            modelBuilder.Entity("CalorieCountingApplication.Models.ExerciseEntry", b =>
                {
                    b.HasOne("CalorieCountingApplication.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("CalorieCountingApplication.Models.FoodEntry", b =>
                {
                    b.HasOne("CalorieCountingApplication.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });
#pragma warning restore 612, 618
        }
    }
}
