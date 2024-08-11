using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "盐值");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "SysUser");
        }
    }
}
