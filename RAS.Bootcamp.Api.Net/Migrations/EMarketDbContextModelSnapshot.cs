﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RAS.Bootcamp.Api.Net.Datas;

#nullable disable

namespace RAS.Bootcamp.Api.Net.Migrations
{
    [DbContext(typeof(EMarketDbContext))]
    partial class EMarketDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Barang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Harga")
                        .HasColumnType("numeric");

                    b.Property<int>("IdPenjual")
                        .HasColumnType("integer");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Stok")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdPenjual" }, "IX_Barangs_IdPenjual");

                    b.ToTable("Barangs");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Pembely", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<string>("NoHp")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdUser" }, "IX_Pembelies_IdUser");

                    b.ToTable("Pembelies");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Penjual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<string>("NamaToko")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "IdUser" }, "IX_Penjuals_IdUser");

                    b.ToTable("Penjuals");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Barang", b =>
                {
                    b.HasOne("RAS.Bootcamp.Api.Net.Datas.Entities.Penjual", "IdPenjualNavigation")
                        .WithMany("Barangs")
                        .HasForeignKey("IdPenjual")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdPenjualNavigation");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Pembely", b =>
                {
                    b.HasOne("RAS.Bootcamp.Api.Net.Datas.Entities.User", "IdUserNavigation")
                        .WithMany("Pembelies")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Penjual", b =>
                {
                    b.HasOne("RAS.Bootcamp.Api.Net.Datas.Entities.User", "IdUserNavigation")
                        .WithMany("Penjuals")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.Penjual", b =>
                {
                    b.Navigation("Barangs");
                });

            modelBuilder.Entity("RAS.Bootcamp.Api.Net.Datas.Entities.User", b =>
                {
                    b.Navigation("Pembelies");

                    b.Navigation("Penjuals");
                });
#pragma warning restore 612, 618
        }
    }
}
