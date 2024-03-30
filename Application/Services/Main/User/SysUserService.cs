
using AutoMapper;
using DAS.Application.Model;
using DAS.Application.Wrapper;
using DAS.Application.Dtos.Main.User;
using DAS.Application.DTOs.Main.User;
using DAS.Application.Helpers.Model;
using DAS.Application.Interfaces.IRepositories.Main.User;
using DAS.Application.Interfaces.IServices.Main.User;
using DAS.Domain.Main.User;
using System.Linq.Expressions;

namespace DAS.Application.Services.Main.User
{
    public class SysUserService : ISysUserService
    {
        private readonly ISysUserRepository _ISysUserRepository;
        private readonly IMapper _mapper;

        // Constructor Dependemcy Injection
        public SysUserService(ISysUserRepository sysUserRepository,IMapper mapper) 
        {
            _ISysUserRepository= sysUserRepository;
            _mapper=mapper;
        }

        public async Task<Result<BaseListModel<SysUserDTO>>> GetAll(RequestModel<SysUserSearchDto> model)
        {
            //The Search Filter the columns that is used in Searching
            Expression<Func<SysUser, bool>> FilterExpression = U => U.IsDeleted == false && U.FacilityID == model.UserInfo.FacilityId
                               && (U.ID == model.Model.ID || !model.Model.ID.HasValue || model.Model.ID == 0)
                               && (U.BranchID == model.Model.BranchID || !model.Model.BranchID.HasValue || model.Model.BranchID == 0)
                               && (U.GroupID == model.Model.GroupID || !model.Model.GroupID.HasValue || model.Model.GroupID == 0)
                               && (U.EmpID == model.Model.EmpID || !model.Model.EmpID.HasValue || model.Model.EmpID == 0)
                               && (string.IsNullOrEmpty(model.Model.NameAr) || U.NameAr.Contains(model.Model.NameAr))
                               && (U.NameEn.Contains(model.Model.NameEn) || string.IsNullOrEmpty(model.Model.NameEn))
                               && (U.UserName.Contains(model.Model.UserName) || string.IsNullOrEmpty(model.Model.UserName))
                               && (U.Email.Contains(model.Model.Email) || string.IsNullOrEmpty(model.Model.Email));

            string[] includes = { /*nameof(SysUser.Branch), nameof(SysUser.Employee), nameof(SysUser.Group)*/ }; 

            (var SysUsers, var count) = await _ISysUserRepository.GetAllWithPagination(FilterExpression, includes, (model.Model.PageIndex - 1) * model.Model.PageSize, model.Model.PageSize);
            var res = new BaseListModel<SysUserDTO>();

            res.List = _mapper.Map<List<SysUserDTO>>(SysUsers);

            res.PageIndex = model.Model.PageIndex;
            res.PageSize = model.Model.PageSize;
            res.RowsCount = count;
            return await Result<BaseListModel<SysUserDTO>>.SuccessAsync(res, "");
        }
    }
}
