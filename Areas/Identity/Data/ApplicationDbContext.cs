using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<FinalProjectUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // กำหนดการตั้งค่าชื่อตาราง (ถ้าจำเป็น)
            builder.Entity<FinalProjectUser>().ToTable("Users"); // เปลี่ยนชื่อ AspNetUsers เป็น Users
        }
    }
}