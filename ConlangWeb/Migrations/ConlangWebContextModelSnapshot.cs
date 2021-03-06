﻿// <auto-generated />
using ConlangWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ConlangWeb.Migrations
{
    [DbContext(typeof(ConlangWebContext))]
    partial class ConlangWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConlangWeb.Models.Word", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Con");

                    b.Property<string>("Dutch");

                    b.Property<string>("English");

                    b.Property<string>("Note");

                    b.HasKey("ID");

                    b.ToTable("Word");
                });
#pragma warning restore 612, 618
        }
    }
}
