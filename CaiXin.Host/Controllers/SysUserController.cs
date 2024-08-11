using CaiXin.Application.SysUser.Commands.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CaiXin.Host.Controllers
{
    /// <summary>
    /// 系统用户
    /// </summary>
    [Route("api/sysuser")]
    public class SysUserController: ControllerBase
    {

        private readonly IMediator _mediator;

        public SysUserController(IMediator mediator)=>_mediator = mediator;


      /// <summary>
      /// 创建系统用户
      /// </summary>
      /// <param name="cmd"></param>
      /// <returns></returns>
        [HttpPost,Route("/create")]
        public async Task<ObjectResult> CreateSysUser([FromBody] CreateUserCmd cmd) =>Ok(await _mediator.Send(cmd));
    }
}
