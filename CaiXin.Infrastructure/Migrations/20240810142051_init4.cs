using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KeyVal",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "密值Key");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyVal",
                table: "SysUser");
        }
    }
}
