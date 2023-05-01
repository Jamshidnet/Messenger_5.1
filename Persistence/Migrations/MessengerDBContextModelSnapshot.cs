﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(MessengerDBContext))]
    partial class MessengerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domein.Entities.Account", b =>
                {
                    b.Property<Guid>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("account_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<int?>("Password")
                        .HasColumnType("integer")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user_name");

                    b.HasKey("AccountId");

                    b.ToTable("account");
                });

            modelBuilder.Entity("Domein.Entities.BunchOfAccount", b =>
                {
                    b.Property<Guid>("BunchOfAccountsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("bunch_of_accounts_id");

                    b.Property<Guid>("InnerAccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("inner_account_id");

                    b.HasKey("BunchOfAccountsId");

                    b.ToTable("BunchOfAccounts");
                });

            modelBuilder.Entity("Domein.Entities.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("contact_id");

                    b.Property<Guid>("InContactId")
                        .HasColumnType("uuid")
                        .HasColumnName("in_contact_id");

                    b.Property<Guid>("OwnerAccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("owner_account_id");

                    b.HasKey("ContactId");

                    b.ToTable("contact");
                });

            modelBuilder.Entity("Domein.Entities.Message", b =>
                {
                    b.Property<Guid>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("message_id");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("message_text");

                    b.Property<Guid>("RecieverAccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("reciever_account_id");

                    b.Property<Guid>("SenderAccountId")
                        .HasColumnType("uuid")
                        .HasColumnName("sender_account_id");

                    b.Property<DateTime>("SentTime")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("sent_time");

                    b.HasKey("MessageId");

                    b.ToTable("message");
                });
#pragma warning restore 612, 618
        }
    }
}