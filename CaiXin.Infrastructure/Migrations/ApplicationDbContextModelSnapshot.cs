﻿// <auto-generated />
using System;
using CaiXin.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaiXin.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CaiXin.Domain.Entity.SysDictData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("主键ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("编码");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("DateTime")
                        .HasColumnName("CreateTime")
                        .HasComment("创建时间");

                    b.Property<Guid>("DictTypeId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("字典类型Id");

                    b.Property<string>("ExtData")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("拓展数据(保存业务功能的配置项)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("名称");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.Property<string>("Remark")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("备注");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar")
                        .HasColumnName("Status")
                        .HasComment("状态");

                    b.Property<string>("TagType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("显示样式-标签颜色");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("Value")
                        .HasComment("值");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsDescending();

                    b.HasIndex("DictTypeId");

                    b.ToTable("SysDictData", t =>
                        {
                            t.HasComment("系统字典值表");
                        });
                });

            modelBuilder.Entity("CaiXin.Domain.Entity.SysDictType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("主键ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("编码");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("名称");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int")
                        .HasComment("排序");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("备注");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment("状态");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsDescending();

                    b.ToTable("SysDictType", t =>
                        {
                            t.HasComment("系统字典分类表");
                        });
                });

            modelBuilder.Entity("CaiXin.Domain.Entity.SysUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("主键ID");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("用户登录账号");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("登录密码");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("用户名");

                    b.HasKey("Id");

                    b.HasIndex("Account")
                        .IsUnique()
                        .IsDescending();

                    b.ToTable("SysUser");
                });

            modelBuilder.Entity("CaiXin.Domain.Entity.SysDictData", b =>
                {
                    b.HasOne("CaiXin.Domain.Entity.SysDictType", null)
                        .WithMany("Children")
                        .HasForeignKey("DictTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CaiXin.Domain.Entity.SysDictType", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
