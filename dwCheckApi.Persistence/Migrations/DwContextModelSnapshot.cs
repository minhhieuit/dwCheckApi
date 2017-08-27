﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace dwCheckApi.Persistence.Migrations
{
    [DbContext(typeof(DwContext))]
    partial class DwContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("dwCheckApi.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("BookCoverImage");

                    b.Property<string>("BookCoverImageUrl");

                    b.Property<string>("BookDescription");

                    b.Property<string>("BookIsbn10");

                    b.Property<string>("BookIsbn13");

                    b.Property<string>("BookName");

                    b.Property<int>("BookOrdinal");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("dwCheckApi.Entities.BookCharacter", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("CharacterId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.HasKey("BookId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("BookCharacters");
                });

            modelBuilder.Entity("dwCheckApi.Entities.BookSeries", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("SeriesId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Ordinal");

                    b.HasKey("BookId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("BookSeries");
                });

            modelBuilder.Entity("dwCheckApi.Entities.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CharacterName");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.HasKey("CharacterId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("dwCheckApi.Entities.Series", b =>
                {
                    b.Property<int>("SeriesId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("SeriesName");

                    b.HasKey("SeriesId");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("dwCheckApi.Entities.BookCharacter", b =>
                {
                    b.HasOne("dwCheckApi.Entities.Book", "Book")
                        .WithMany("BookCharacter")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dwCheckApi.Entities.Character", "Character")
                        .WithMany("BookCharacter")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dwCheckApi.Entities.BookSeries", b =>
                {
                    b.HasOne("dwCheckApi.Entities.Book", "Book")
                        .WithMany("BookSeries")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("dwCheckApi.Entities.Series", "Series")
                        .WithMany("BookSeries")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
