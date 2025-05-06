using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Documentation_back_end.Migrations
{
    /// <inheritdoc />
    public partial class DBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessMethod_Hosts_HostId",
                table: "AccessMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_AccessMethod_User_UserId",
                table: "AccessMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_ApplicationCategory_ApplicationCategoryId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_Application_Licence_LicenceId",
                table: "Application");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationHost_Application_ApplicationId",
                table: "ApplicationHost");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationHost_Hosts_HostId",
                table: "ApplicationHost");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Category_CategoryId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Furnisher_FurnisherId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Localisation_LocalisationId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_IpAddress_IpSegment_IpSegmentId",
                table: "IpAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_IpAddress_Vlan_VlanId",
                table: "IpAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Localisation_Localisation_ParentId",
                table: "Localisation");

            migrationBuilder.DropForeignKey(
                name: "FK_Script_Hosts_HostId",
                table: "Script");

            migrationBuilder.DropForeignKey(
                name: "FK_Script_User_UserId",
                table: "Script");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Hosts_HostId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_IpAddress_IpAddressId",
                table: "Service");

            migrationBuilder.DropForeignKey(
                name: "FK_Vlan_IpSegment_IpSegmentId",
                table: "Vlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vlan",
                table: "Vlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Script",
                table: "Script");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localisation",
                table: "Localisation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Licence",
                table: "Licence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IpSegment",
                table: "IpSegment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IpAddress",
                table: "IpAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Furnisher",
                table: "Furnisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationHost",
                table: "ApplicationHost");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationCategory",
                table: "ApplicationCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Application",
                table: "Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessMethod",
                table: "AccessMethod");

            migrationBuilder.RenameTable(
                name: "Vlan",
                newName: "Vlans");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "Script",
                newName: "Scripts");

            migrationBuilder.RenameTable(
                name: "Localisation",
                newName: "Localisations");

            migrationBuilder.RenameTable(
                name: "Licence",
                newName: "Licences");

            migrationBuilder.RenameTable(
                name: "IpSegment",
                newName: "IpSegments");

            migrationBuilder.RenameTable(
                name: "IpAddress",
                newName: "IpAddresses");

            migrationBuilder.RenameTable(
                name: "Furnisher",
                newName: "Furnishers");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "ApplicationHost",
                newName: "ApplicationHosts");

            migrationBuilder.RenameTable(
                name: "ApplicationCategory",
                newName: "ApplicationCategories");

            migrationBuilder.RenameTable(
                name: "Application",
                newName: "Applications");

            migrationBuilder.RenameTable(
                name: "AccessMethod",
                newName: "AccessMethods");

            migrationBuilder.RenameIndex(
                name: "IX_Vlan_IpSegmentId",
                table: "Vlans",
                newName: "IX_Vlans_IpSegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_IpAddressId",
                table: "Services",
                newName: "IX_Services_IpAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Service_HostId",
                table: "Services",
                newName: "IX_Services_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Script_UserId",
                table: "Scripts",
                newName: "IX_Scripts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Script_HostId",
                table: "Scripts",
                newName: "IX_Scripts_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Localisation_ParentId",
                table: "Localisations",
                newName: "IX_Localisations_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddress_VlanId",
                table: "IpAddresses",
                newName: "IX_IpAddresses_VlanId");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddress_IpSegmentId",
                table: "IpAddresses",
                newName: "IX_IpAddresses_IpSegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationHost_HostId",
                table: "ApplicationHosts",
                newName: "IX_ApplicationHosts_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationHost_ApplicationId",
                table: "ApplicationHosts",
                newName: "IX_ApplicationHosts_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_LicenceId",
                table: "Applications",
                newName: "IX_Applications_LicenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Application_ApplicationCategoryId",
                table: "Applications",
                newName: "IX_Applications_ApplicationCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessMethod_UserId",
                table: "AccessMethods",
                newName: "IX_AccessMethods_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessMethod_HostId",
                table: "AccessMethods",
                newName: "IX_AccessMethods_HostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vlans",
                table: "Vlans",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Scripts",
                table: "Scripts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localisations",
                table: "Localisations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licences",
                table: "Licences",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IpSegments",
                table: "IpSegments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IpAddresses",
                table: "IpAddresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Furnishers",
                table: "Furnishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationHosts",
                table: "ApplicationHosts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationCategories",
                table: "ApplicationCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessMethods",
                table: "AccessMethods",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ChangeLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    EntityId = table.Column<int>(type: "int", nullable: false),
                    ChangeType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChangeDescription = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChangedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ChangedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLog", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Monitoring",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tool = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Frequency = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Details = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitoring", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitoring_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServicesPolice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocalisationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesPolice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicesPolice_Localisations_LocalisationId",
                        column: x => x.LocalisationId,
                        principalTable: "Localisations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Version = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Category = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tool", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ApplicationServicesPolice",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    ServicePoliceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationServicesPolice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationServicesPolice_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationServicesPolice_ServicesPolice_ServicePoliceId",
                        column: x => x.ServicePoliceId,
                        principalTable: "ServicesPolice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FileName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileType = table.Column<int>(type: "int", nullable: false),
                    url = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    HostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Documents_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HostTools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConfigPath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HostId = table.Column<int>(type: "int", nullable: false),
                    ToolId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostTools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HostTools_Hosts_HostId",
                        column: x => x.HostId,
                        principalTable: "Hosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HostTools_Tool_ToolId",
                        column: x => x.ToolId,
                        principalTable: "Tool",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationServicesPolice_ApplicationId",
                table: "ApplicationServicesPolice",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationServicesPolice_ServicePoliceId",
                table: "ApplicationServicesPolice",
                column: "ServicePoliceId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_HostId",
                table: "Documents",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TemplateId",
                table: "Documents",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_HostTools_HostId",
                table: "HostTools",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_HostTools_ToolId",
                table: "HostTools",
                column: "ToolId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitoring_HostId",
                table: "Monitoring",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesPolice_LocalisationId",
                table: "ServicesPolice",
                column: "LocalisationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessMethods_Hosts_HostId",
                table: "AccessMethods",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccessMethods_Users_UserId",
                table: "AccessMethods",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationHosts_Applications_ApplicationId",
                table: "ApplicationHosts",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationHosts_Hosts_HostId",
                table: "ApplicationHosts",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_ApplicationCategories_ApplicationCategoryId",
                table: "Applications",
                column: "ApplicationCategoryId",
                principalTable: "ApplicationCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Licences_LicenceId",
                table: "Applications",
                column: "LicenceId",
                principalTable: "Licences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Categories_CategoryId",
                table: "Hosts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts",
                column: "FurnisherId",
                principalTable: "Furnishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts",
                column: "LocalisationId",
                principalTable: "Localisations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddresses_IpSegments_IpSegmentId",
                table: "IpAddresses",
                column: "IpSegmentId",
                principalTable: "IpSegments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddresses_Vlans_VlanId",
                table: "IpAddresses",
                column: "VlanId",
                principalTable: "Vlans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Localisations_Localisations_ParentId",
                table: "Localisations",
                column: "ParentId",
                principalTable: "Localisations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scripts_Hosts_HostId",
                table: "Scripts",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scripts_Users_UserId",
                table: "Scripts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Hosts_HostId",
                table: "Services",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_IpAddresses_IpAddressId",
                table: "Services",
                column: "IpAddressId",
                principalTable: "IpAddresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vlans_IpSegments_IpSegmentId",
                table: "Vlans",
                column: "IpSegmentId",
                principalTable: "IpSegments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessMethods_Hosts_HostId",
                table: "AccessMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_AccessMethods_Users_UserId",
                table: "AccessMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationHosts_Applications_ApplicationId",
                table: "ApplicationHosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationHosts_Hosts_HostId",
                table: "ApplicationHosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_ApplicationCategories_ApplicationCategoryId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Licences_LicenceId",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Categories_CategoryId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Furnishers_FurnisherId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_Hosts_Localisations_LocalisationId",
                table: "Hosts");

            migrationBuilder.DropForeignKey(
                name: "FK_IpAddresses_IpSegments_IpSegmentId",
                table: "IpAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_IpAddresses_Vlans_VlanId",
                table: "IpAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Localisations_Localisations_ParentId",
                table: "Localisations");

            migrationBuilder.DropForeignKey(
                name: "FK_Scripts_Hosts_HostId",
                table: "Scripts");

            migrationBuilder.DropForeignKey(
                name: "FK_Scripts_Users_UserId",
                table: "Scripts");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Hosts_HostId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_IpAddresses_IpAddressId",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Vlans_IpSegments_IpSegmentId",
                table: "Vlans");

            migrationBuilder.DropTable(
                name: "ApplicationServicesPolice");

            migrationBuilder.DropTable(
                name: "ChangeLog");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "HostTools");

            migrationBuilder.DropTable(
                name: "Monitoring");

            migrationBuilder.DropTable(
                name: "ServicesPolice");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Tool");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vlans",
                table: "Vlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Scripts",
                table: "Scripts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Localisations",
                table: "Localisations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Licences",
                table: "Licences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IpSegments",
                table: "IpSegments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IpAddresses",
                table: "IpAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Furnishers",
                table: "Furnishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationHosts",
                table: "ApplicationHosts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationCategories",
                table: "ApplicationCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccessMethods",
                table: "AccessMethods");

            migrationBuilder.RenameTable(
                name: "Vlans",
                newName: "Vlan");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "Scripts",
                newName: "Script");

            migrationBuilder.RenameTable(
                name: "Localisations",
                newName: "Localisation");

            migrationBuilder.RenameTable(
                name: "Licences",
                newName: "Licence");

            migrationBuilder.RenameTable(
                name: "IpSegments",
                newName: "IpSegment");

            migrationBuilder.RenameTable(
                name: "IpAddresses",
                newName: "IpAddress");

            migrationBuilder.RenameTable(
                name: "Furnishers",
                newName: "Furnisher");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "Application");

            migrationBuilder.RenameTable(
                name: "ApplicationHosts",
                newName: "ApplicationHost");

            migrationBuilder.RenameTable(
                name: "ApplicationCategories",
                newName: "ApplicationCategory");

            migrationBuilder.RenameTable(
                name: "AccessMethods",
                newName: "AccessMethod");

            migrationBuilder.RenameIndex(
                name: "IX_Vlans_IpSegmentId",
                table: "Vlan",
                newName: "IX_Vlan_IpSegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_IpAddressId",
                table: "Service",
                newName: "IX_Service_IpAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_HostId",
                table: "Service",
                newName: "IX_Service_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Scripts_UserId",
                table: "Script",
                newName: "IX_Script_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Scripts_HostId",
                table: "Script",
                newName: "IX_Script_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_Localisations_ParentId",
                table: "Localisation",
                newName: "IX_Localisation_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddresses_VlanId",
                table: "IpAddress",
                newName: "IX_IpAddress_VlanId");

            migrationBuilder.RenameIndex(
                name: "IX_IpAddresses_IpSegmentId",
                table: "IpAddress",
                newName: "IX_IpAddress_IpSegmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_LicenceId",
                table: "Application",
                newName: "IX_Application_LicenceId");

            migrationBuilder.RenameIndex(
                name: "IX_Applications_ApplicationCategoryId",
                table: "Application",
                newName: "IX_Application_ApplicationCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationHosts_HostId",
                table: "ApplicationHost",
                newName: "IX_ApplicationHost_HostId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationHosts_ApplicationId",
                table: "ApplicationHost",
                newName: "IX_ApplicationHost_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessMethods_UserId",
                table: "AccessMethod",
                newName: "IX_AccessMethod_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AccessMethods_HostId",
                table: "AccessMethod",
                newName: "IX_AccessMethod_HostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vlan",
                table: "Vlan",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Script",
                table: "Script",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Localisation",
                table: "Localisation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licence",
                table: "Licence",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IpSegment",
                table: "IpSegment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IpAddress",
                table: "IpAddress",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Furnisher",
                table: "Furnisher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Application",
                table: "Application",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationHost",
                table: "ApplicationHost",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationCategory",
                table: "ApplicationCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccessMethod",
                table: "AccessMethod",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessMethod_Hosts_HostId",
                table: "AccessMethod",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AccessMethod_User_UserId",
                table: "AccessMethod",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Application_ApplicationCategory_ApplicationCategoryId",
                table: "Application",
                column: "ApplicationCategoryId",
                principalTable: "ApplicationCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Application_Licence_LicenceId",
                table: "Application",
                column: "LicenceId",
                principalTable: "Licence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationHost_Application_ApplicationId",
                table: "ApplicationHost",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationHost_Hosts_HostId",
                table: "ApplicationHost",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Category_CategoryId",
                table: "Hosts",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Furnisher_FurnisherId",
                table: "Hosts",
                column: "FurnisherId",
                principalTable: "Furnisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hosts_Localisation_LocalisationId",
                table: "Hosts",
                column: "LocalisationId",
                principalTable: "Localisation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddress_IpSegment_IpSegmentId",
                table: "IpAddress",
                column: "IpSegmentId",
                principalTable: "IpSegment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IpAddress_Vlan_VlanId",
                table: "IpAddress",
                column: "VlanId",
                principalTable: "Vlan",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Localisation_Localisation_ParentId",
                table: "Localisation",
                column: "ParentId",
                principalTable: "Localisation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Script_Hosts_HostId",
                table: "Script",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Script_User_UserId",
                table: "Script",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Hosts_HostId",
                table: "Service",
                column: "HostId",
                principalTable: "Hosts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_IpAddress_IpAddressId",
                table: "Service",
                column: "IpAddressId",
                principalTable: "IpAddress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vlan_IpSegment_IpSegmentId",
                table: "Vlan",
                column: "IpSegmentId",
                principalTable: "IpSegment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
