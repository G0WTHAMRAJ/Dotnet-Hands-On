using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoreApiEFProject.Migrations
{
    /// <inheritdoc />
    public partial class initialserve1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetAnimals",
                columns: table => new
                {
                    petId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    petName = table.Column<string>(type: "text", nullable: false),
                    petType = table.Column<string>(type: "text", nullable: true),
                    petDob = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    petIsVeg = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetAnimals", x => x.petId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetAnimals");
        }
    }
}
