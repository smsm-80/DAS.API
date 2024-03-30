using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.Dtos.Main.User
{
    public class SysUserDTO
    {
        public long ID { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string? UserPassword { get; set; }
        public int? TypeID { get; set; }
        public int? BranchID { get; set; }
        public string? BranchesID { get; set; }
        public long? Emp_ID { get; set; }
        public bool? Enable { get; set; }
        public int? GroupID { get; set; }
        public bool? IsUpdate { get; set; }
        public long? FacilityID { get; set; }
        public string? User_Photo { get; set; }
        public bool? IsAgree { get; set; }
        public bool? EnableTwoFactor { get; set; }
        public int? TwoFactorType { get; set; }
        public string? OTP { get; set; }
        public DateTime? OTPExpiry { get; set; }
    }
}
