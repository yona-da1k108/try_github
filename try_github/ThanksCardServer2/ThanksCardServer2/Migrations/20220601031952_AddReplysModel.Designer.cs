﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ThanksCardServer2.Models;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220601031952_AddReplysModel")]
    partial class AddReplysModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ThanksCardServer2.Models.Belong", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("Parent_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("sonzai_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Belongs");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("BelongsId")
                        .HasColumnType("bigint");

                    b.Property<long>("Belongs_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Cd")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<long>("Sonzai_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BelongsId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Midle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("Reply_Id")
                        .HasColumnType("bigint");

                    b.Property<long?>("ThanksCardId")
                        .HasColumnType("bigint");

                    b.Property<long>("ThanksCard_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ThanksCardId");

                    b.ToTable("Midles");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Reply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<long>("EmployeeId")
                        .HasColumnType("bigint");

                    b.Property<int>("Sonzai_Id")
                        .HasColumnType("integer");

                    b.Property<long>("ThanksCardId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ThanksCardId");

                    b.ToTable("Replys");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Template", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Template_Content")
                        .HasColumnType("text");

                    b.Property<string>("Template_Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.ThanksCard", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alreadtread")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("DestinationId")
                        .HasColumnType("bigint");

                    b.Property<long>("Good_Number")
                        .HasColumnType("bigint");

                    b.Property<long>("SenderId")
                        .HasColumnType("bigint");

                    b.Property<long?>("TemplateId")
                        .HasColumnType("bigint");

                    b.Property<long>("Template_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("ThanksCard_Content")
                        .HasColumnType("text");

                    b.Property<long?>("TitleId")
                        .HasColumnType("bigint");

                    b.Property<long>("Title_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("sonzai_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.HasIndex("SenderId");

                    b.HasIndex("TemplateId");

                    b.HasIndex("TitleId");

                    b.ToTable("ThanksCards");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Title", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Title_Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Employee", b =>
                {
                    b.HasOne("ThanksCardServer2.Models.Belong", "Belongs")
                        .WithMany()
                        .HasForeignKey("BelongsId");

                    b.Navigation("Belongs");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Midle", b =>
                {
                    b.HasOne("ThanksCardServer2.Models.ThanksCard", "ThanksCard")
                        .WithMany()
                        .HasForeignKey("ThanksCardId");

                    b.Navigation("ThanksCard");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Reply", b =>
                {
                    b.HasOne("ThanksCardServer2.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanksCardServer2.Models.ThanksCard", "ThanksCard")
                        .WithMany()
                        .HasForeignKey("ThanksCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("ThanksCard");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.ThanksCard", b =>
                {
                    b.HasOne("ThanksCardServer2.Models.Employee", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanksCardServer2.Models.Employee", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ThanksCardServer2.Models.Template", "Template")
                        .WithMany()
                        .HasForeignKey("TemplateId");

                    b.HasOne("ThanksCardServer2.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId");

                    b.Navigation("Destination");

                    b.Navigation("Sender");

                    b.Navigation("Template");

                    b.Navigation("Title");
                });
#pragma warning restore 612, 618
        }
    }
}
