using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DMSEntityFrameWork.Migrations
{
    /// <inheritdoc />
    public partial class Initial9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Patients",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_id",
                table: "Patients",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_id",
                table: "Patients",
                column: "id",
                principalTable: "Doctors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_id",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_id",
                table: "Patients");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Patients",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");
        }
    }
}
