﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopReactCore.Data;

namespace WebShopReactCore.Migrations
{
    [DbContext(typeof(AppStoreDbContext))]
    [Migration("20210809192041_newDBLayout")]
    partial class newDBLayout
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsId")
                        .HasColumnType("int");

                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsId", "BooksId");

                    b.HasIndex("BooksId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("WebShopReactCore.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Leena",
                            LastName = "Lehtolainen"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Caroline",
                            LastName = "Säfstrand"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Patrick",
                            LastName = "Modiano"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Maj",
                            LastName = "Sjöwall"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Per",
                            LastName = "Wahlöö"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "Arnaldur",
                            LastName = "Indriðason"
                        });
                });

            modelBuilder.Entity("WebShopReactCore.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Falska förespeglingar är en spännande och aktuell deckare där Maria Kallio tvingas att ompröva en hel del av det hon tidigare tagit för givet.",
                            ISBN = "91-0-011026-4",
                            PictureRef = "/Images/falska-förespeglingar.jpg",
                            Price = 50.00m,
                            Title = "Falska förespeglingar"
                        },
                        new
                        {
                            Id = 2,
                            Description = "När Elin en dag hittar en förlovningsring i pojkvännen Zacks ficka får hon panik. Hon packar en väska och beger sig brådstörtat till Hallands Väderö - en plats som hon svurit på att aldrig någonsin återvända till. Här får hon dela bostad med Anja, en äldre dam som kommit till ön för att måla. Anja släpper inte gärna någon för nära inpå livet, men när hon ser vilken av hennes tavlor som Elin uppslukas av förstår hon att Elin inte är som alla andra.",
                            ISBN = "978-91-7475-228-1",
                            PictureRef = "/Images/om-du-bara-visste.jpg",
                            Price = 68.90m,
                            Title = "Om du bara visste"
                        },
                        new
                        {
                            Id = 3,
                            Description = "I Nätternas gräs vandrar berättaren Jean genom Paris på spaning efter Dannie, den gåtfulla kvinna han älskade fyrtio år tidigare och som försvann under mystiska omständigheter utan att lämna några spår efter sig. En svart anteckningsbok fullklottrad med namn på personer och platser, med adresser, telefonnummer och tidningsnotiser blir hans hjälp mot glömskan, hans vägvisare till det förgångna.",
                            ISBN = "978-91-86497-30-9",
                            PictureRef = "/Images/nätternas-gräs.jpg",
                            Price = 175.00m,
                            Title = "Nätternas gräs"
                        },
                        new
                        {
                            Id = 5,
                            Description = "En roman om ett brott",
                            ISBN = "9118220614",
                            PictureRef = "/Images/den-vedervärdige-mannen-från-säffle",
                            Price = 30.00m,
                            Title = "Den vedervärdige mannen från Säffle"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Kriminalkommissarie Maria Kallio ser på en direktsänd talk-show om prostitution i teve. Kalabalik utbryter i studion och kamerorna slocknar. Strax därefter ringer Marias mobil: en kvinna har hittats död i tevehuset.     Kvinnan, Lulu Nightingale, är en känd prostituerad med en rad högt uppsatta personer i sin kundkrets. Lulu har dött av cyanidförgiftning strax före sändning och allt tyder på mord. Raden av misstänkta är begränsad eftersom programmet bygger på överraskningsprincipen och bara några få kände till att hon skulle medverka.     Men pusslet blir svårare att lägga än så och Maria Kallio tvingas gång på gång byta spår i utredningen. Finns det någon koppling mellan den mördade Lulu och den svårt sargade och sannolikt prostituerade kvinna som nyligen försvunnit från ett sjukhus? Kan den ryska maffian vara inblandad? Eller finns motivet att hämta i Lulus kundkrets? När en av de misstänkta hittas död  efter vad som ser ut som ett självmord  och tar på sig skulden för mordet på Lulu, blir fallet ännu mer komplicerat. Är det sanningen som vederbörande efterlämnat eller finns det en mördare som inte låter sig stoppas av någon? Maria Kallio, som brottas med ett trängt privatliv och en oförstående chef, står återigen i ett vägskäl i utredningen men blir allt mer övertygad om i vilken riktning hon ska gå  något hon tvingas betala ett högt, personligt pris för.     Liksom i sina tidigare böcker berättar Leena Lehtolainen i Studio Näktergalen om laddade och samtidsrelaterade frågor.",
                            ISBN = "978-91-0011315-5",
                            PictureRef = "/Images/studio-näktergalen.jpg",
                            Price = 90.00m,
                            Title = "Studio Näktergalen"
                        });
                });

            modelBuilder.Entity("WebShopReactCore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebShopReactCore.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("WebShopReactCore.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShopReactCore.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebShopReactCore.Models.OrderItem", b =>
                {
                    b.HasOne("WebShopReactCore.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebShopReactCore.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WebShopReactCore.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
