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
    [Migration("20220531080602_AddTemplatesModel")]
    partial class AddTemplatesModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ThanksCardServer2.Models.Belongs", b =>
                {
                    b.Property<long>("Belongs_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Belongs_Id"));

                    b.Property<string>("Belongs_Name")
                        .HasColumnType("text");

                    b.Property<long>("Belongssonzai_id")
                        .HasColumnType("bigint");

                    b.Property<long>("Parent_Id")
                        .HasColumnType("bigint");

                    b.HasKey("Belongs_Id");

                    b.ToTable("belongs");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Employee_Id"));

                    b.Property<int>("Cd")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<long>("Receive_Number")
                        .HasColumnType("bigint");

                    b.Property<long>("Send_Number")
                        .HasColumnType("bigint");

                    b.Property<int>("Sonzai_id")
                        .HasColumnType("integer");

                    b.HasKey("Employee_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Template", b =>
                {
                    b.Property<long>("Template_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Template_Id"));

                    b.Property<string>("Template_Content")
                        .HasColumnType("text");

                    b.Property<string>("Template_Name")
                        .HasColumnType("text");

                    b.HasKey("Template_Id");

                    b.ToTable("Templates");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.ThanksCard", b =>
                {
                    b.Property<long>("ThanksCard_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ThanksCard_Id"));

                    b.Property<string>("Alreadtread")
                        .HasColumnType("text");

                    b.Property<long>("Destination_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Good_Number")
                        .HasColumnType("bigint");

                    b.Property<long>("Sender_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Template_Id")
                        .HasColumnType("bigint");

                    b.Property<string>("ThanksCard_Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("ThanksCard_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("Thankscardsonzai_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Title_Id")
                        .HasColumnType("bigint");

                    b.HasKey("ThanksCard_Id");

                    b.ToTable("ThanksCards");
                });

            modelBuilder.Entity("ThanksCardServer2.Models.Title", b =>
                {
                    b.Property<long>("Title_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Title_Id"));

                    b.Property<string>("Title_Name")
                        .HasColumnType("text");

                    b.HasKey("Title_Id");

                    b.ToTable("Titles");
                });
#pragma warning restore 612, 618
        }
    }
}
