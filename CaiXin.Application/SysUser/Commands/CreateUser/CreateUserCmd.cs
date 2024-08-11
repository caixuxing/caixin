using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiXin.Application.SysUser.Commands.CreateUser
{
    public record CreateUserCmd:IRequest<bool>
    {
        /// <summary>
        /// 用户昵称名
        /// </summary>
        public string nickname { get; set; } = default!;

        /// <summary>
        /// 用户账号
        /// </summary>
        public string Account { get; set; } = default!;
    }
}
