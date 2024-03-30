using DAS.Application.Interfaces.IRepositories.Main.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.Interfaces.IRepositories.RepositoryManager
{
    public interface IMainRepositoryManager
    {
        ISysUserRepository sysUserRepository { get; }
    }
}
