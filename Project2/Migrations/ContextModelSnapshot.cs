﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

namespace Project2.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("Project2.Models.Group", b =>
                {
                    b.Property<long>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupSize")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeSlotId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupId");

                    b.HasIndex("TimeSlotId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1L,
                            Email = "test@test.com",
                            GroupName = "Test Group",
                            GroupSize = "10",
                            Phone = "8011234567",
                            TimeSlotId = 1
                        },
                        new
                        {
                            GroupId = 2L,
                            Email = "test@test.com",
                            GroupName = "Test Group",
                            GroupSize = "10",
                            Phone = "8011234567",
                            TimeSlotId = 2
                        });
                });

            modelBuilder.Entity("Project2.Models.TimeSlot", b =>
                {
                    b.Property<int>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotId");

                    b.ToTable("Times");

                    b.HasData(
                        new
                        {
                            TimeSlotId = 1,
                            Available = true,
                            Date = "04/01/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 2,
                            Available = true,
                            Date = "04/01/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 3,
                            Available = true,
                            Date = "04/01/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 4,
                            Available = true,
                            Date = "04/01/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 5,
                            Available = true,
                            Date = "04/01/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 6,
                            Available = true,
                            Date = "04/01/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 7,
                            Available = true,
                            Date = "04/01/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 8,
                            Available = true,
                            Date = "04/01/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 9,
                            Available = true,
                            Date = "04/01/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 10,
                            Available = true,
                            Date = "04/01/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 11,
                            Available = true,
                            Date = "04/01/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 12,
                            Available = true,
                            Date = "04/01/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 13,
                            Available = true,
                            Date = "04/01/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 14,
                            Available = true,
                            Date = "04/02/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 15,
                            Available = true,
                            Date = "04/02/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 16,
                            Available = true,
                            Date = "04/02/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 17,
                            Available = true,
                            Date = "04/02/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 18,
                            Available = true,
                            Date = "04/02/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 19,
                            Available = true,
                            Date = "04/02/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 20,
                            Available = true,
                            Date = "04/02/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 21,
                            Available = true,
                            Date = "04/02/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 22,
                            Available = true,
                            Date = "04/02/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 23,
                            Available = true,
                            Date = "04/02/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 24,
                            Available = true,
                            Date = "04/02/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 25,
                            Available = true,
                            Date = "04/02/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 26,
                            Available = true,
                            Date = "04/02/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 27,
                            Available = true,
                            Date = "04/03/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 28,
                            Available = true,
                            Date = "04/03/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 29,
                            Available = true,
                            Date = "04/03/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 30,
                            Available = true,
                            Date = "04/03/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 31,
                            Available = true,
                            Date = "04/03/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 32,
                            Available = true,
                            Date = "04/03/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 33,
                            Available = true,
                            Date = "04/03/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 34,
                            Available = true,
                            Date = "04/03/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 35,
                            Available = true,
                            Date = "04/03/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 36,
                            Available = true,
                            Date = "04/03/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 37,
                            Available = true,
                            Date = "04/03/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 38,
                            Available = true,
                            Date = "04/03/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 39,
                            Available = true,
                            Date = "04/03/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 40,
                            Available = true,
                            Date = "04/04/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 41,
                            Available = true,
                            Date = "04/04/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 42,
                            Available = true,
                            Date = "04/04/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 43,
                            Available = true,
                            Date = "04/04/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 44,
                            Available = true,
                            Date = "04/04/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 45,
                            Available = true,
                            Date = "04/04/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 46,
                            Available = true,
                            Date = "04/04/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 47,
                            Available = true,
                            Date = "04/04/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 48,
                            Available = true,
                            Date = "04/04/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 49,
                            Available = true,
                            Date = "04/04/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 50,
                            Available = true,
                            Date = "04/04/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 51,
                            Available = true,
                            Date = "04/04/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 52,
                            Available = true,
                            Date = "04/04/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 53,
                            Available = true,
                            Date = "04/05/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 54,
                            Available = true,
                            Date = "04/05/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 55,
                            Available = true,
                            Date = "04/05/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 56,
                            Available = true,
                            Date = "04/05/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 57,
                            Available = true,
                            Date = "04/05/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 58,
                            Available = true,
                            Date = "04/05/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 59,
                            Available = true,
                            Date = "04/05/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 60,
                            Available = true,
                            Date = "04/05/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 61,
                            Available = true,
                            Date = "04/05/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 62,
                            Available = true,
                            Date = "04/05/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 63,
                            Available = true,
                            Date = "04/05/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 64,
                            Available = true,
                            Date = "04/05/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 65,
                            Available = true,
                            Date = "04/05/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 66,
                            Available = true,
                            Date = "04/06/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 67,
                            Available = true,
                            Date = "04/06/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 68,
                            Available = true,
                            Date = "04/06/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 69,
                            Available = true,
                            Date = "04/06/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 70,
                            Available = true,
                            Date = "04/06/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 71,
                            Available = true,
                            Date = "04/06/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 72,
                            Available = true,
                            Date = "04/06/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 73,
                            Available = true,
                            Date = "04/06/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 74,
                            Available = true,
                            Date = "04/06/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 75,
                            Available = true,
                            Date = "04/06/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 76,
                            Available = true,
                            Date = "04/06/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 77,
                            Available = true,
                            Date = "04/06/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 78,
                            Available = true,
                            Date = "04/06/22",
                            Time = "8 PM"
                        },
                        new
                        {
                            TimeSlotId = 79,
                            Available = true,
                            Date = "04/07/22",
                            Time = "8 AM"
                        },
                        new
                        {
                            TimeSlotId = 80,
                            Available = true,
                            Date = "04/07/22",
                            Time = "9 AM"
                        },
                        new
                        {
                            TimeSlotId = 81,
                            Available = true,
                            Date = "04/07/22",
                            Time = "10 AM"
                        },
                        new
                        {
                            TimeSlotId = 82,
                            Available = true,
                            Date = "04/07/22",
                            Time = "11 AM"
                        },
                        new
                        {
                            TimeSlotId = 83,
                            Available = true,
                            Date = "04/07/22",
                            Time = "12 PM"
                        },
                        new
                        {
                            TimeSlotId = 84,
                            Available = true,
                            Date = "04/07/22",
                            Time = "1 PM"
                        },
                        new
                        {
                            TimeSlotId = 85,
                            Available = true,
                            Date = "04/07/22",
                            Time = "2 PM"
                        },
                        new
                        {
                            TimeSlotId = 86,
                            Available = true,
                            Date = "04/07/22",
                            Time = "3 PM"
                        },
                        new
                        {
                            TimeSlotId = 87,
                            Available = true,
                            Date = "04/07/22",
                            Time = "4 PM"
                        },
                        new
                        {
                            TimeSlotId = 88,
                            Available = true,
                            Date = "04/07/22",
                            Time = "5 PM"
                        },
                        new
                        {
                            TimeSlotId = 89,
                            Available = true,
                            Date = "04/07/22",
                            Time = "6 PM"
                        },
                        new
                        {
                            TimeSlotId = 90,
                            Available = true,
                            Date = "04/07/22",
                            Time = "7 PM"
                        },
                        new
                        {
                            TimeSlotId = 91,
                            Available = true,
                            Date = "04/07/22",
                            Time = "8 PM"
                        });
                });

            modelBuilder.Entity("Project2.Models.Group", b =>
                {
                    b.HasOne("Project2.Models.TimeSlot", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
