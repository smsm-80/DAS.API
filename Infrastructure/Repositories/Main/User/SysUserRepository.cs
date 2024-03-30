using DAS.Application.Interfaces.IRepositories.Main.User;
using DAS.Domain.Main.User;
using DAS.Infrastructure.DbContexts;
using DAS.Infrastructure.Repositories.Generale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Infrastructure.Repositories.Main.User
{
    public class SysUserRepository : GenericRepository<SysUser> ,ISysUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public SysUserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
    }
}
