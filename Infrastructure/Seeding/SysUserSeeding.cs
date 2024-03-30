using DAS.Domain.Main.User;
using Microsoft.EntityFrameworkCore;

namespace DAS.Infrastructure.Seeding
{
    public static class SysUserSeeding
    {
        public static void Seeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUser>().HasData(
                                      new SysUser
                                      {
                                          ID = 1,
                                          NameAr = "مدير النظام",
                                          NameEn = "Administrator",
                                          UserName = "admin",
                                          UserPassword = "123",
                                          BranchID = 1,
                                          GroupID = 1,
                                          FacilityID = 1,
                                          EmpID = 1,
                                          Enable = true,
                                          IsUpdate = true,
                                          IsAgree = true,
                                          Email = "Admin@admin.com",
                                      });
        }
    }
}
