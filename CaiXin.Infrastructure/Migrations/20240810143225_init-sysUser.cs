using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initsysUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyVal",
                table: "SysUser");

            migrationBuilder.DropColumn(
                name: "Salt",
                table: "SysUser");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                comment: "用户名",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                comment: "登录密码",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "SysUser",
                type: "nvarchar(450)",
                nullable: false,
                comment: "用户登录账号",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SysUser",
                type: "uniqueidentifier",
                nullable: false,
                comment: "主键ID",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "用户名");

            migrationBuilder.AlterColumn<string>(
                name: "PassWord",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "登录密码");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "SysUser",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "用户登录账号");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "SysUser",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldComment: "主键ID");

            migrationBuilder.AddColumn<string>(
                name: "KeyVal",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "密值Key");

            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "SysUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "盐值");
        }
    }
}
