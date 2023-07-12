﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIBLEYBLAYOPERA.Data;

#nullable disable

namespace SIBLEYBLAYOPERA.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230530152459_TaxExpendituresLog")]
    partial class TaxExpendituresLog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SIBLEYBLAYOPERA.Models.DepartmentalProcurements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AbsentQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfPlacementOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middlename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyPlacementOrderQuantity")
                        .HasColumnType("int");

                    b.Property<int>("OrderQuantity")
                        .HasColumnType("int");

                    b.Property<int>("PresentQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProcurementCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StaffIDNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("TargetedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<int>("YearlyPlacementOrderQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DepartmentalProcurements");
                });

            modelBuilder.Entity("SIBLEYBLAYOPERA.Models.Procurements", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AmountOfFirstPayment")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfSecondPayment")
                        .HasColumnType("int");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ArrivalLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfPlacementOrder")
                        .HasColumnType("datetime2");

                    b.Property<int>("DomesticQuantity")
                        .HasColumnType("int");

                    b.Property<int>("EProcurementPaymentAccountNumber")
                        .HasColumnType("int");

                    b.Property<int>("FixedPrice")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MonthlyPlacementOrderQuantity")
                        .HasColumnType("int");

                    b.Property<string>("ProcurementCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProcurementPaymentAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReceivedDateOfFirstPayment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReceivedDateOfSecondPayment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TargetedDeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<int>("TotalMonthlyEXpenditure")
                        .HasColumnType("int");

                    b.Property<int>("TotalYearlyEXpenditure")
                        .HasColumnType("int");

                    b.Property<int>("YearlyPlacementOrderQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Procurements");
                });

            modelBuilder.Entity("SIBLEYBLAYOPERA.Models.StaffLog1", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractAgreement")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractAgreementExpiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EWageAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrossWage")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NetWage")
                        .HasColumnType("int");

                    b.Property<DateTime>("NetWageAccounting")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfExhaustedVacationDays")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfUnExhaustedVacationDays")
                        .HasColumnType("int");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialSecurityEWageAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("SocialSecurityModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialSecurityWage")
                        .HasColumnType("int");

                    b.Property<DateTime>("SocialSecurityWageAccounting")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffIDNumber")
                        .HasColumnType("int");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<int>("VacationDays")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("StaffLog1");
                });

            modelBuilder.Entity("SIBLEYBLAYOPERA.Models.StaffLog2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ContractAgreement")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ContractAgreementExpiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EWageAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GrossWage")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NetWage")
                        .HasColumnType("int");

                    b.Property<DateTime>("NetWageAccounting")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberOfExhaustedVacationDays")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfUnExhaustedVacationDays")
                        .HasColumnType("int");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialSecurityEWageAccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("SocialSecurityModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SocialSecurityWage")
                        .HasColumnType("int");

                    b.Property<DateTime>("SocialSecurityWageAccounting")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffIDNumber")
                        .HasColumnType("int");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.Property<int>("VacationDays")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("StaffLog2");
                });

            modelBuilder.Entity("SIBLEYBLAYOPERA.Models.TaxExpendituresLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountOfFirstPayment")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfSecondPayment")
                        .HasColumnType("int");

                    b.Property<int>("ClearedAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("FirstPayment")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModeOfPayment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SecondPayment")
                        .HasColumnType("datetime2");

                    b.Property<string>("TaxPaymentLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxReceiptIDNumber")
                        .HasColumnType("int");

                    b.Property<int>("TotalYearlyExpenditure")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfTax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnClearedAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Year")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TaxExpendituresLog");
                });
#pragma warning restore 612, 618
        }
    }
}