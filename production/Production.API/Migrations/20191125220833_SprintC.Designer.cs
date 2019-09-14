﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Production.Infrastructure.Persistence;

namespace moc_production_service.Migrations
{
    [DbContext(typeof(ProductionContext))]
    [Migration("20191125220833_SprintC")]
    partial class SprintC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Production.Domain.AggregatesModel.ManufacturingPlanAggregate.ManufacturingPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ManufacturingPlan");
                });

            modelBuilder.Entity("Production.Domain.AggregatesModel.OperationAggregate.Operation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OperationName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("OperationName")
                        .IsUnique();

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("Production.Domain.AggregatesModel.OperationManufacturingPlanAggregate.OperationManufacturingPlan", b =>
                {
                    b.Property<int>("OperationId");

                    b.Property<int>("ManufacturingPlanId");

                    b.HasKey("OperationId", "ManufacturingPlanId");

                    b.HasAlternateKey("ManufacturingPlanId", "OperationId");

                    b.ToTable("OperationManufacturingPlan");
                });

            modelBuilder.Entity("Production.Domain.AggregatesModel.ProductAggregate.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ManufacturingPlanId");

                    b.Property<string>("ProductDescription")
                        .IsRequired();

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.Property<long>("ProductPrice");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturingPlanId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Production.Domain.AggregatesModel.OperationManufacturingPlanAggregate.OperationManufacturingPlan", b =>
                {
                    b.HasOne("Production.Domain.AggregatesModel.ManufacturingPlanAggregate.ManufacturingPlan", "manufacturingPlan")
                        .WithMany("LstOperations")
                        .HasForeignKey("ManufacturingPlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Production.Domain.AggregatesModel.OperationAggregate.Operation", "operation")
                        .WithMany("operationManufacturingPlans")
                        .HasForeignKey("OperationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Production.Domain.AggregatesModel.ProductAggregate.Product", b =>
                {
                    b.HasOne("Production.Domain.AggregatesModel.ManufacturingPlanAggregate.ManufacturingPlan", "ManufacturingPlan")
                        .WithMany()
                        .HasForeignKey("ManufacturingPlanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
