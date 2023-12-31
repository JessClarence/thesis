﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace thesis.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "checklists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    operatorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estserved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plateno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inspectorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inspectdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inspecttime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_checklists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverFname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverMname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverLname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseFront = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HighlySatisfied = table.Column<int>(type: "int", nullable: false),
                    Satisfied = table.Column<int>(type: "int", nullable: false),
                    Neutral = table.Column<int>(type: "int", nullable: false),
                    Dissatisfied = table.Column<int>(type: "int", nullable: false),
                    HighlyDissatisfied = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Helpers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelperFname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelperMname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelperLname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helpers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeatEstablishment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseToOperateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseStatus = table.Column<int>(type: "int", nullable: true),
                    Long = table.Column<double>(type: "float", nullable: false),
                    Lat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatEstablishment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MTVDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlNo = table.Column<int>(type: "int", nullable: false),
                    ApplicantType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredOwner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<int>(type: "int", nullable: false),
                    VehicleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNo = table.Column<int>(type: "int", nullable: false),
                    LTOOR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LTOCR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTVDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostArticle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Label = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Introduction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    References = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostArticle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QrCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QrCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Species = table.Column<int>(type: "int", nullable: true),
                    LiveWeight = table.Column<int>(type: "int", nullable: true),
                    MeatDealer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Issue = table.Column<int>(type: "int", nullable: false),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Cause = table.Column<int>(type: "int", nullable: false),
                    NoOfHeadsPassed = table.Column<int>(type: "int", nullable: false),
                    WeightPassed = table.Column<double>(type: "float", nullable: false),
                    AnimalPart = table.Column<int>(type: "int", nullable: false),
                    PostmortemCause = table.Column<int>(type: "int", nullable: false),
                    PostmortemWeight = table.Column<int>(type: "int", nullable: false),
                    PostmortemNoOfHeads = table.Column<int>(type: "int", nullable: false),
                    FitforConSpecies = table.Column<int>(type: "int", nullable: false),
                    FitforConNoOfHeads = table.Column<int>(type: "int", nullable: false),
                    DressedWeight = table.Column<int>(type: "int", nullable: false),
                    DestinationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CertificateStatus = table.Column<int>(type: "int", nullable: false),
                    uid = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VehicleInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleMaker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlateNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EngineNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LTOCR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LTOOR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Est = table.Column<int>(type: "int", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Roles = table.Column<int>(type: "int", nullable: false),
                    MeatEstablishmentId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_MeatEstablishment_MeatEstablishmentId",
                        column: x => x.MeatEstablishmentId,
                        principalTable: "MeatEstablishment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MeatDealers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeatEstablishmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatDealers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeatDealers_MeatEstablishment_MeatEstablishmentId",
                        column: x => x.MeatEstablishmentId,
                        principalTable: "MeatEstablishment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MTVApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationtype = table.Column<int>(type: "int", nullable: false),
                    AccreditionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerFname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerMname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerLname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: true),
                    HelperId = table.Column<int>(type: "int", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTVApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MTVApplications_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MTVApplications_Helpers_HelperId",
                        column: x => x.HelperId,
                        principalTable: "Helpers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MTVApplications_VehicleInfos_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "VehicleInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receivings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivings_AspNetUsers_AccountDetailsId",
                        column: x => x.AccountDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BatchCode = table.Column<int>(type: "int", nullable: false),
                    Species = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    LiveWeight = table.Column<double>(type: "float", nullable: false),
                    MeatDealersId = table.Column<int>(type: "int", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingDoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoldingPenNo = table.Column<int>(type: "int", nullable: false),
                    ReceivingBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    InspectionStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceivingReports_AspNetUsers_AccountDetailsId",
                        column: x => x.AccountDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReceivingReports_MeatDealers_MeatDealersId",
                        column: x => x.MeatDealersId,
                        principalTable: "MeatDealers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MTVInspection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MTVApplicationId = table.Column<int>(type: "int", nullable: false),
                    Enclosed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Insulated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempControlled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlasticCurtains = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectlyInstalled = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTVInspection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MTVInspection_MTVApplications_MTVApplicationId",
                        column: x => x.MTVApplicationId,
                        principalTable: "MTVApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MTVquizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MTVApplicationId = table.Column<int>(type: "int", nullable: false),
                    passorfail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTVquizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MTVquizzes_MTVApplications_MTVApplicationId",
                        column: x => x.MTVApplicationId,
                        principalTable: "MTVApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentReceipt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SOA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MTVApplicationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_MTVApplications_MTVApplicationId",
                        column: x => x.MTVApplicationId,
                        principalTable: "MTVApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeatInspectionReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VerifiedByPOSMSHead = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivingReportId = table.Column<int>(type: "int", nullable: true),
                    AccountDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeatInspectionReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeatInspectionReports_AspNetUsers_AccountDetailsId",
                        column: x => x.AccountDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MeatInspectionReports_ReceivingReports_ReceivingReportId",
                        column: x => x.ReceivingReportId,
                        principalTable: "ReceivingReports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DisapprovedApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MTVInspectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisapprovedApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisapprovedApplications_MTVInspection_MTVInspectionId",
                        column: x => x.MTVInspectionId,
                        principalTable: "MTVInspection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MTVApplicationResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MTVInspectionId = table.Column<int>(type: "int", nullable: false),
                    Received = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Processed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTVApplicationResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MTVApplicationResults_MTVInspection_MTVInspectionId",
                        column: x => x.MTVInspectionId,
                        principalTable: "MTVInspection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConductOfInspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Issue = table.Column<int>(type: "int", nullable: false),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Cause = table.Column<int>(type: "int", nullable: false),
                    MeatInspectionReportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConductOfInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConductOfInspections_MeatInspectionReports_MeatInspectionReportId",
                        column: x => x.MeatInspectionReportId,
                        principalTable: "MeatInspectionReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PassedForSlaughters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    ConductOfInspectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassedForSlaughters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PassedForSlaughters_ConductOfInspections_ConductOfInspectionId",
                        column: x => x.ConductOfInspectionId,
                        principalTable: "ConductOfInspections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postmortems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassedForSlaughterId = table.Column<int>(type: "int", nullable: false),
                    AnimalPart = table.Column<int>(type: "int", nullable: false),
                    Cause = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postmortems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postmortems_PassedForSlaughters_PassedForSlaughterId",
                        column: x => x.PassedForSlaughterId,
                        principalTable: "PassedForSlaughters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "totalNoFitForHumanConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Species = table.Column<int>(type: "int", nullable: false),
                    NoOfHeads = table.Column<int>(type: "int", nullable: false),
                    DressedWeight = table.Column<double>(type: "float", nullable: false),
                    PostmortemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_totalNoFitForHumanConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_totalNoFitForHumanConsumptions_Postmortems_PostmortemId",
                        column: x => x.PostmortemId,
                        principalTable: "Postmortems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SummaryAndDistributionOfMICs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalNoFitForHumanConsumptionId = table.Column<int>(type: "int", nullable: false),
                    DestinationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MICIssued = table.Column<int>(type: "int", nullable: false),
                    MICCancelled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SummaryAndDistributionOfMICs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SummaryAndDistributionOfMICs_totalNoFitForHumanConsumptions_TotalNoFitForHumanConsumptionId",
                        column: x => x.TotalNoFitForHumanConsumptionId,
                        principalTable: "totalNoFitForHumanConsumptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MeatEstablishmentId",
                table: "AspNetUsers",
                column: "MeatEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConductOfInspections_MeatInspectionReportId",
                table: "ConductOfInspections",
                column: "MeatInspectionReportId");

            migrationBuilder.CreateIndex(
                name: "IX_DisapprovedApplications_MTVInspectionId",
                table: "DisapprovedApplications",
                column: "MTVInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MeatDealers_MeatEstablishmentId",
                table: "MeatDealers",
                column: "MeatEstablishmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MeatInspectionReports_AccountDetailsId",
                table: "MeatInspectionReports",
                column: "AccountDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_MeatInspectionReports_ReceivingReportId",
                table: "MeatInspectionReports",
                column: "ReceivingReportId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVApplicationResults_MTVInspectionId",
                table: "MTVApplicationResults",
                column: "MTVInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVApplications_DriverId",
                table: "MTVApplications",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVApplications_HelperId",
                table: "MTVApplications",
                column: "HelperId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVApplications_VehicleId",
                table: "MTVApplications",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVInspection_MTVApplicationId",
                table: "MTVInspection",
                column: "MTVApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MTVquizzes_MTVApplicationId",
                table: "MTVquizzes",
                column: "MTVApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PassedForSlaughters_ConductOfInspectionId",
                table: "PassedForSlaughters",
                column: "ConductOfInspectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_MTVApplicationId",
                table: "Payments",
                column: "MTVApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Postmortems_PassedForSlaughterId",
                table: "Postmortems",
                column: "PassedForSlaughterId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingReports_AccountDetailsId",
                table: "ReceivingReports",
                column: "AccountDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingReports_MeatDealersId",
                table: "ReceivingReports",
                column: "MeatDealersId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_AccountDetailsId",
                table: "Receivings",
                column: "AccountDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_SummaryAndDistributionOfMICs_TotalNoFitForHumanConsumptionId",
                table: "SummaryAndDistributionOfMICs",
                column: "TotalNoFitForHumanConsumptionId");

            migrationBuilder.CreateIndex(
                name: "IX_totalNoFitForHumanConsumptions_PostmortemId",
                table: "totalNoFitForHumanConsumptions",
                column: "PostmortemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "checklists");

            migrationBuilder.DropTable(
                name: "DisapprovedApplications");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "LogTransactions");

            migrationBuilder.DropTable(
                name: "MTVApplicationResults");

            migrationBuilder.DropTable(
                name: "MTVDetails");

            migrationBuilder.DropTable(
                name: "MTVquizzes");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PostArticle");

            migrationBuilder.DropTable(
                name: "QrCodes");

            migrationBuilder.DropTable(
                name: "Receivings");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "SummaryAndDistributionOfMICs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MTVInspection");

            migrationBuilder.DropTable(
                name: "totalNoFitForHumanConsumptions");

            migrationBuilder.DropTable(
                name: "MTVApplications");

            migrationBuilder.DropTable(
                name: "Postmortems");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Helpers");

            migrationBuilder.DropTable(
                name: "VehicleInfos");

            migrationBuilder.DropTable(
                name: "PassedForSlaughters");

            migrationBuilder.DropTable(
                name: "ConductOfInspections");

            migrationBuilder.DropTable(
                name: "MeatInspectionReports");

            migrationBuilder.DropTable(
                name: "ReceivingReports");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MeatDealers");

            migrationBuilder.DropTable(
                name: "MeatEstablishment");
        }
    }
}
