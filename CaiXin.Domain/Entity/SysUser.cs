namespace CaiXin.Domain.Entity;

[Table(nameof(SysUser)), Comment("系统用户表")]
[Index(nameof(Account), IsDescending = [true], IsUnique = true)]
public partial class SysUser
{
    /// <summary>
    /// 主键ID
    /// </summary>
    [Key]
    [Comment("主键ID")]
    public Guid Id { get; private set; }

    /// <summary>
    /// 用户名
    /// </summary>
    [Comment("用户名")]
    public string UserName { get; private set; } = default!;

    /// <summary>
    /// 用户登录账号
    /// </summary>
    [Comment("用户登录账号")]
    public string Account { get; private set; } = default!;

    /// <summary>
    /// 登录密码
    /// </summary>
    [Comment("登录密码")]
    public string PassWord { get; private set; } = default!;

    /// <summary>
    /// 联系人电话
    /// </summary>
    [Comment("联系人电话")]
    [NotMapped]
    public string? Phone { get; private set; }

    /// <summary>
    /// 版本号
    /// </summary>
    [Timestamp]
    public Byte[] TimeStamp { get; set; } = default!;

    /// <summary>
    /// 电子邮箱
    /// </summary>
    [NotMapped]
    public string? Email { get; private set; }

    /// <summary>
    /// 当前用户下的用户列表集合
    /// </summary>

    [NotMapped]
    public ICollection<string> UserList { get; private set; } = new HashSet<string>();
}

public partial class SysUser
{
    private SysUser()
    { }

    private SysUser(Guid id, string userName, string account, string passWord, string? phone)
    {
        Id = id;
        UserName = userName;
        Account = account;
        PassWord = passWord;
        Phone = phone;
    }

    /// <summary>
    /// 创建系统用户
    /// </summary>
    /// <param name="id">主键ID</param>
    /// <param name="userName">用户名</param>
    /// <param name="account">账号</param>
    /// <param name="passWord">密码</param>
    /// <param name="phone">电话</param>
    /// <returns>rturn SysUser系统用户</returns>
    public static SysUser Create(Guid id, string userName, string account, string passWord, string? phone)
    {
        return new SysUser(id, userName, account, passWord, phone);
    }
}