using CaiXin.Domain.Entity;

namespace CaiXin.Infrastructure.Data.SeedData
{
    internal class InitData
    {
        /// <summary>
        /// 用户种子数据
        /// </summary>
        public static IEnumerable<SysUser> SysUsers =>  new List<SysUser>
                     {
                            SysUser.Create(new Guid("58c49479-ec65-4de2-86e7-033c546291aa"),"ccx", "mehmet", "mehmet@gmail.com","15580808032"),
                            SysUser.Create(new Guid("189dc8dc-990f-48e0-a37b-e6f2b60b9d7d"), "苍蝇哥", "john@gmail.com","123123","19119206668")
                     };
    }
}