using DAS.Application.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.Helpers.Model
{
    public static class RequestModelExtension
    {
        public static RequestModel<T> ToRequestModel<T>(this T entity, HttpRequest request)
        {
            UserInfo UserInfo = new UserInfo();
            if (request?.Headers?.Any(x => x.Key == "Authorization") ?? false)
            {
                string jwtToken = request.Headers["Authorization"].ToString().Replace("bearer ", "").Replace("Bearer ", "");
                var tokenHandler = new JwtSecurityTokenHandler();
                var jsonToken = tokenHandler.ReadToken(jwtToken) as JwtSecurityToken;
                if (jsonToken != null)
                {
                    foreach (var claim in jsonToken.Claims)
                    {
                        switch (claim.Type)
                        {
                            case "Username":
                                UserInfo.Username = claim.Value;
                                break;
                            case "User_Id":
                                int.TryParse(claim.Value, out int userId);
                                UserInfo.ID = userId;
                                break;
                            case "Group_Id":
                                int.TryParse(claim.Value, out int Group_Id);
                                UserInfo.ID = Group_Id;
                                break;
                            case "Emp_Id":
                                int.TryParse(claim.Value, out int Emp_Id);
                                UserInfo.EmpId = Emp_Id;
                                break;
                            case "EmpCode":
                                UserInfo.EmpCode = claim.Value;
                                break;
                            case "FacilityId":
                                int.TryParse(claim.Value, out int Facility_Id);
                                UserInfo.FacilityId = Facility_Id;
                                break;
                            case "NameAr":
                                UserInfo.NameAr = claim.Value;
                                break;
                            case "NameEn":
                                UserInfo.NameEn = claim.Value;
                                break;
                        }
                    }
                }
                return new RequestModel<T>() { Model = entity, UserInfo = UserInfo };
            }
            else
                return new RequestModel<T> { UserInfo = new UserInfo(), Model = entity };
        }

    }
}
