namespace DAS.Application.Model
{
    public class UserInfo
    {
        public long ID { get; set; }
        public string? Username { get; set; }
        public string? NameAr { get; set; }
        public string? NameEn { get; set; }
        public string? UserEmail { get; set; }
        public long? EmpId { get; set; }
        public string? EmpCode { get; set; }
        public long? FacilityId { get; set; }
        public long? GroupId { get; set; }
        public int Language { get; set; }
        public long PeriodId { get; set; }
        public string? Token { get; set; }
        public string? TokenExpires { get; set; }

    }
}
