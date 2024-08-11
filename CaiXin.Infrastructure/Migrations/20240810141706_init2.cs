using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "SysUser");

            migrationBuilder.AlterTable(
                name: "SysDictData",
                comment: "系统字典值表");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SysDictData",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "值",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "值");

            migrationBuilder.AlterColumn<string>(
                name: "TagType",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "显示样式-标签颜色",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "SysDictData",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "状态",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "状态");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "备注",
                oldClrType: typeof(string),
                oldType: "nvarchar(2048)",
                oldMaxLength: 2048,
                oldNullable: true,
                oldComment: "备注");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "名称");

            migrationBuilder.AlterColumn<string>(
                name: "ExtData",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                comment: "拓展数据(保存业务功能的配置项)",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "拓展数据(保存业务功能的配置项)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "编码",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "编码");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "SysDictData",
                oldComment: "系统字典值表");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SysDictData",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "值",
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldComment: "值");

            migrationBuilder.AlterColumn<string>(
                name: "TagType",
                table: "SysDictData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "显示样式-标签颜色");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "SysDictData",
                type: "int",
                nullable: false,
                comment: "状态",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldComment: "状态");

            migrationBuilder.AlterColumn<string>(
                name: "Remark",
                table: "SysDictData",
                type: "nvarchar(2048)",
                maxLength: 2048,
                nullable: true,
                comment: "备注",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "备注");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SysDictData",
                type: "nvarchar(max)",
                nullable: true,
                comment: "名称",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "名称");

            migrationBuilder.AlterColumn<string>(
                name: "ExtData",
                table: "SysDictData",
                type: "nvarchar(max)",
                nullable: true,
                comment: "拓展数据(保存业务功能的配置项)",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldComment: "拓展数据(保存业务功能的配置项)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "SysDictData",
                type: "nvarchar(450)",
                nullable: false,
                comment: "编码",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "编码");
        }
    }
}
