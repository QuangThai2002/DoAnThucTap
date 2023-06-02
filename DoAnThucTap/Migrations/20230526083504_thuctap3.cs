using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoAnThucTap.Migrations
{
    /// <inheritdoc />
    public partial class thuctap3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Daughihinh",
                table: "Daughihinh");

            migrationBuilder.RenameTable(
                name: "Daughihinh",
                newName: "daughihinhs");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "phukiens",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "daughihinhs",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_daughihinhs",
                table: "daughihinhs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_daughihinhs",
                table: "daughihinhs");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "phukiens");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "daughihinhs");

            migrationBuilder.RenameTable(
                name: "daughihinhs",
                newName: "Daughihinh");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Daughihinh",
                table: "Daughihinh",
                column: "Id");
        }
    }
}
