using DAS.Application.Model;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DAS.Application.Interfaces.IServices.General
{
    public interface ITokenService
    {
        UserInfo GenerateToken(UserInfo AuthUser);
        ClaimsPrincipal GetPrincipalFromToken(string token);
        UserInfo GetUserInfo(HttpRequest Reques);
    }
}
