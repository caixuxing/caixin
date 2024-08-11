namespace CaiXin.Domain.Entity;

/// <summary>
/// 系统字典值表
/// </summary>
[Table(nameof(SysDictData)), Comment("系统字典值表")]
[Index(nameof(Code), IsDescending = [true])]
public partial class SysDictData
{
    [Key, Comment("主键ID")]
    public Guid Id { get; set; }

    /// <summary>
    /// 字典类型Id
    /// </summary>
    [Comment("字典类型Id")]
    public Guid DictTypeId { get; set; }

    /// <summary>
    /// 字典类型
    /// </summary>
    [NotMapped]
    public virtual SysDictType DictType { get; set; } = default!;

    /// <summary>
    /// 值
    /// </summary>
    [Column(nameof(Value), TypeName = "varchar")]
    [StringLength(50)]
    [Comment("值")]
    public virtual string Value { get; set; } = default!;

    /// <summary>
    /// 编码
    /// </summary>
    [StringLength(50)]
    [Comment("编码")]
    public virtual string Code { get; set; } = default!;

    /// <summary>
    /// 名称
    /// </summary>
    [StringLength(50)]
    [Comment("名称")]
    public virtual string? Name { get; set; }

    /// <summary>
    /// 显示样式-标签颜色
    /// </summary>
    [StringLength(50)]
    [Comment("显示样式-标签颜色")]
    public string? TagType { get; set; }

    /// <summary>
    /// 排序
    /// </summary>
    [Comment("排序")]
    public int OrderNo { get; set; } = 100;

    /// <summary>
    /// 备注
    /// </summary>
    [Comment("备注")]
    [StringLength(50)]
    public string? Remark { get; set; }

    /// <summary>
    /// 拓展数据(保存业务功能的配置项)
    /// </summary>
    [Comment("拓展数据(保存业务功能的配置项)")]
    [StringLength(50)]
    public string? ExtData { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [Column(nameof(Status), TypeName = "varchar")]
    [StringLength(20)]
    [Comment("状态")]
    public StatusEnum Status { get; set; } = StatusEnum.Enable;

    /// <summary>
    /// 创建时间
    /// </summary>
    [Column("CreateTime", TypeName = "DateTime")]
    [Comment("创建时间")]
    public DateTime CreateTime { get; set; }
}