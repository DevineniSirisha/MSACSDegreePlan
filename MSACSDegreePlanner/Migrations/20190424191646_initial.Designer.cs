﻿// <auto-generated />
using System;
using MSACSDegreePlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MSACSDegreePlanner.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190424191646_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MSACSDegreePlanner.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreeAbbrev")
                        .HasMaxLength(50);

                    b.Property<string>("DegreePlanName")
                        .HasMaxLength(50);

                    b.HasKey("DegreeId");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreePlan", b =>
                {
                    b.Property<int>("DegreePlanId");

                    b.Property<bool>("Check");

                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreePlanAbrev")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("DegreePlanName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("StudentId");

                    b.HasKey("DegreePlanId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("StudentId");

                    b.ToTable("DegreePlan");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreePlanTermRequirement", b =>
                {
                    b.Property<int>("DegreePlanTermRequirementId");

                    b.Property<int>("DegreePlanId");

                    b.Property<bool>("Done");

                    b.Property<int>("RequirementId");

                    b.Property<int>("StudentTermId");

                    b.HasKey("DegreePlanTermRequirementId");

                    b.HasIndex("RequirementId");

                    b.HasIndex("StudentTermId");

                    b.ToTable("DegreePlanTermRequirement");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreeRequirement", b =>
                {
                    b.Property<int>("DegreeRequirementId");

                    b.Property<int>("DegreeId");

                    b.Property<bool>("Done");

                    b.Property<int>("RequirementId");

                    b.HasKey("DegreeRequirementId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("RequirementId");

                    b.ToTable("DegreeRequirement");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.Requirement", b =>
                {
                    b.Property<int>("RequirementId");

                    b.Property<int>("DegreeId");

                    b.Property<string>("RequirementAbbrev")
                        .HasMaxLength(50);

                    b.Property<string>("RequirementName")
                        .HasMaxLength(50);

                    b.HasKey("RequirementId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Requirement");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.Student", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<bool>("Check");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("Snumber")
                        .HasMaxLength(50);

                    b.Property<int>("_919number");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.StudentTerm", b =>
                {
                    b.Property<int>("StudentTermId");

                    b.Property<int>("DegreePlanId");

                    b.Property<bool>("Done");

                    b.Property<int>("StudentId");

                    b.Property<int>("Term");

                    b.Property<string>("TermLabel");

                    b.HasKey("StudentTermId");

                    b.HasIndex("DegreePlanId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentTerm");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreePlan", b =>
                {
                    b.HasOne("MSACSDegreePlanner.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSACSDegreePlanner.Models.Student", "Student")
                        .WithMany("DegreePlans")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreePlanTermRequirement", b =>
                {
                    b.HasOne("MSACSDegreePlanner.Models.Requirement", "Requirement")
                        .WithMany()
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSACSDegreePlanner.Models.StudentTerm", "StudentTerm")
                        .WithMany("DegreePlanTermRequirements")
                        .HasForeignKey("StudentTermId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.DegreeRequirement", b =>
                {
                    b.HasOne("MSACSDegreePlanner.Models.Degree", "Degree")
                        .WithMany("DegreeRequirements")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSACSDegreePlanner.Models.Requirement", "Requirement")
                        .WithMany()
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.Requirement", b =>
                {
                    b.HasOne("MSACSDegreePlanner.Models.Degree", "degree")
                        .WithMany("Requirements")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSACSDegreePlanner.Models.StudentTerm", b =>
                {
                    b.HasOne("MSACSDegreePlanner.Models.DegreePlan", "DegreePlan")
                        .WithMany("StudentTerms")
                        .HasForeignKey("DegreePlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSACSDegreePlanner.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
