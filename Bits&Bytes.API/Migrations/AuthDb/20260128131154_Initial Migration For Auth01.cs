using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bits_Bytes.API.Migrations.AuthDb
{
    /// <inheritdoc />
    public partial class InitialMigrationForAuth01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28d65a5b-a7db-4850-b380-83591f7d7531", "edc267ec-d43c-4e3b-8108-a1a1f819906d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9740f16c-24a1-4224-a7be-1bb00b7c6892", "edc267ec-d43c-4e3b-8108-a1a1f819906d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edc267ec-d43c-4e3b-8108-a1a1f819906d");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "edc267ec-d43c-4e3b-8108-a1a1f819906d", 0, "0de1b8db-c720-4a3d-823b-b1e583025d83", "admin@bitsnbytes.com", false, false, null, "ADMIN@BITSNBYTES.COM", "ADMIN@BITSNBYTES.COM", "AQAAAAIAAYagAAAAELQ1gX29oEj21rTTROix89dXFh9a67TnamSu+0SRHidncJC65VSRLlI4wm21zU7vTQ==", null, false, "af595bb7-e920-447f-9913-670c9b820da2", false, "admin@bitsnbytes.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28d65a5b-a7db-4850-b380-83591f7d7531", "edc267ec-d43c-4e3b-8108-a1a1f819906d" },
                    { "9740f16c-24a1-4224-a7be-1bb00b7c6892", "edc267ec-d43c-4e3b-8108-a1a1f819906d" }
                });
        }
    }
}
