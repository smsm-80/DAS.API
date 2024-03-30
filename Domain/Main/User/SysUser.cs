using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Domain.General;

namespace DAS.Domain.Main.User
{
    public class SysUser : BaseEntity
    {

        [Column("ID")]
        public long ID { get; set; }

        [Column("NameAr")]
        [StringLength(50)]
        public string? NameAr { get; set; }

        [Column("NameEn")]
        [StringLength(50)]
        public string? NameEn { get; set; }

        [Column("Email")]
        [StringLength(50)]
        public string? Email { get; set; }

        [Column("UserName")]
        [StringLength(50)]
        public string? UserName { get; set; }

        [Column("UserPassword")]
        public string? UserPassword { get; set; }

        [Column("TypeID")]
        public int? TypeID { get; set; }

        [Column("BranchID")]
        public int? BranchID { get; set; }

        [ForeignKey("BranchID")]
        //public Branch Branch { get; set; }

        [Column("BranchesID")]
        [StringLength(2500)]
        public string? BranchesID { get; set; }

        [Column("EmpID")]
        public long? EmpID { get; set; }
        [ForeignKey("EmpID")]
        //public Employee? Employee { get; set; }

        [Column("Enable")]
        [DefaultValue(1)]
        public bool? Enable { get; set; }

        [Column("GroupID")]
        public int? GroupID { get; set; }
        [ForeignKey("GroupID")]
        //public Group? Group { get; set; }

        [Column("IsUpdate")]
        [DefaultValue(false)]
        public bool? IsUpdate { get; set; }

        [Column("FacilityID")]
        public long? FacilityID { get; set; }

        public string? User_Photo { get; set; }

        [Column("IsAgree")]
        [DefaultValue(false)]
        public bool? IsAgree { get; set; }

        [Column("EnableTwoFactor")]
        public bool? EnableTwoFactor { get; set; }

        [Column("TwoFactorType")]
        public int? TwoFactorType { get; set; }

        [Column("OTP")]
        [StringLength(10)]
        public string? OTP { get; set; }

        [Column("OTPExpiry", TypeName = "Datetime")]
        public DateTime? OTPExpiry { get; set; }
    }
}
