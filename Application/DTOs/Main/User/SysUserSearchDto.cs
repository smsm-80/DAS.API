using DAS.Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS.Application.DTOs.Main.User
{
    public class SysUserSearchDto : BaseSearchRequestVM
    {
        public long? ID { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public int? TypeID { get; set; }
        public int? BranchID { get; set; }
        public int? EmpID { get; set; }
        public int? Enable { get; set; }
        public long? GroupID { get; set; }
    }
}
