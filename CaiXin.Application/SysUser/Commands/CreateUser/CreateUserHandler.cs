using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiXin.Application.SysUser.Commands.CreateUser
{
    internal class CreateUserHandler : IRequestHandler<CreateUserCmd, bool>
    {

        public Task<bool> Handle(CreateUserCmd request, CancellationToken cancellationToken)
        {

           var entity= Domain.Entity.SysUser.Create(Guid.NewGuid(),request.nickname,request.Account,"123456","15580808032");

            throw new NotImplementedException();
        }
    }
}
