using DAS.Application.Model;
using DAS.Application.Wrapper;
using DAS.Application.Dtos.Main.User;
using DAS.Domain.Main.User;
using DAS.Application.Helpers.Model;
using DAS.Application.DTOs.Main.User;

namespace DAS.Application.Interfaces.IServices.Main.User
{
    public interface ISysUserService
    {
        Task<Result<BaseListModel<SysUserDTO>>> GetAll(RequestModel<SysUserSearchDto> model);
    }
}
