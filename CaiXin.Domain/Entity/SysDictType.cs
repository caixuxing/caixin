namespace CaiXin.Domain.Entity;

[Table(nameof(SysDictType)), Comment("系统字典分类表")]
[Index(nameof(Name), IsDescending = [true] )]
public partial class SysDictType
{
    [Key, Comment("主键ID")]
    public Guid Id { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [Comment("名称")]
    public virtual string Name { get; set; } = default!;

    /// <summary>
    /// 编码
    /// </summary>
    [Comment("编码")]
    public virtual string Code { get; set; } = default!;

    /// <summary>
    /// 排序
    /// </summary>
    [Comment("排序")]
    public int OrderNo { get; set; } = 100;

    /// <summary>
    /// 备注
    /// </summary>
    [Comment("备注")]
    public string? Remark { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [Comment("状态")]
    public StatusEnum Status { get; set; } = StatusEnum.Enable;

    /// <summary>
    /// 字典值集合
    /// </summary>
    [ForeignKey(nameof(SysDictData.DictTypeId))]
    public virtual List<SysDictData>? Children { get; set; }
}