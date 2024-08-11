using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SysDictType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "主键ID"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "名称"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "编码"),
                    OrderNo = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "备注"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDictType", x => x.Id);
                },
                comment: "系统字典分类表");

            migrationBuilder.CreateTable(
                name: "SysUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysDictData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "主键ID"),
                    DictTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "字典类型Id"),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "值"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "编码"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "名称"),
                    TagType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNo = table.Column<int>(type: "int", nullable: false, comment: "排序"),
                    Remark = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: true, comment: "备注"),
                    ExtData = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "拓展数据(保存业务功能的配置项)"),
                    Status = table.Column<int>(type: "int", nullable: false, comment: "状态"),
                    CreateTime = table.Column<DateTime>(type: "DateTime", nullable: false, comment: "创建时间")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysDictData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysDictData_SysDictType_DictTypeId",
                        column: x => x.DictTypeId,
                        principalTable: "SysDictType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SysDictData_Code",
                table: "SysDictData",
                column: "Code",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_SysDictData_DictTypeId",
                table: "SysDictData",
                column: "DictTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SysDictType_Name",
                table: "SysDictType",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_SysUser_Account",
                table: "SysUser",
                column: "Account",
                unique: true,
                descending: new bool[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SysDictData");

            migrationBuilder.DropTable(
                name: "SysUser");

            migrationBuilder.DropTable(
                name: "SysDictType");
        }
    }
}
