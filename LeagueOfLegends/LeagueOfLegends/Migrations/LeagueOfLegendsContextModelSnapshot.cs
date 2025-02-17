﻿// <auto-generated />
using LeagueOfLegends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueOfLegends.Migrations
{
    [DbContext(typeof(LeagueOfLegendsContext))]
    partial class LeagueOfLegendsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueOfLegends.Models.Heroes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Armor");

                    b.Property<int>("AttackDamage");

                    b.Property<int>("Health");

                    b.Property<int>("HealthRegen");

                    b.Property<bool>("IsDelete")
                        .HasColumnName("isDelete");

                    b.Property<int>("MagicResist");

                    b.Property<int>("MovementSpeed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Heroes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Armor = 30,
                            AttackDamage = 57,
                            Health = 575,
                            HealthRegen = 6,
                            IsDelete = false,
                            MagicResist = 31,
                            MovementSpeed = 330,
                            Name = "Lux"
                        });
                });

            modelBuilder.Entity("LeagueOfLegends.Models.HeroesTypes", b =>
                {
                    b.Property<int>("TypesId");

                    b.Property<int>("HeroesId");

                    b.HasKey("TypesId", "HeroesId");

                    b.HasIndex("HeroesId");

                    b.ToTable("HeroesTypes");

                    b.HasData(
                        new
                        {
                            TypesId = 3,
                            HeroesId = 1
                        },
                        new
                        {
                            TypesId = 4,
                            HeroesId = 1
                        },
                        new
                        {
                            TypesId = 7,
                            HeroesId = 1
                        });
                });

            modelBuilder.Entity("LeagueOfLegends.Models.Types", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDelete")
                        .HasColumnName("isDelete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Name = "Sát thủ"
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            Name = "Xạ thủ"
                        },
                        new
                        {
                            Id = 3,
                            IsDelete = false,
                            Name = "Pháp sư"
                        },
                        new
                        {
                            Id = 4,
                            IsDelete = false,
                            Name = "Hỗ trợ"
                        },
                        new
                        {
                            Id = 5,
                            IsDelete = false,
                            Name = "Đỡ đòn"
                        },
                        new
                        {
                            Id = 6,
                            IsDelete = false,
                            Name = "Đấu sĩ"
                        },
                        new
                        {
                            Id = 7,
                            IsDelete = false,
                            Name = "Đánh xa"
                        },
                        new
                        {
                            Id = 8,
                            IsDelete = false,
                            Name = "Cận chiến"
                        });
                });

            modelBuilder.Entity("LeagueOfLegends.Models.HeroesTypes", b =>
                {
                    b.HasOne("LeagueOfLegends.Models.Heroes", "Heroes")
                        .WithMany("HeroesTypes")
                        .HasForeignKey("HeroesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LeagueOfLegends.Models.Types", "Types")
                        .WithMany("HeroesTypes")
                        .HasForeignKey("TypesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
