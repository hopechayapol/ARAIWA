using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Identity.Data
{
    // ApplicationDbContext สืบทอดมาจาก IdentityDbContext เพื่อใช้ร่วมกับ Identity
    public class ApplicationDbContext : IdentityDbContext<FinalProjectUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ถ้าคุณต้องการเพิ่ม DbSet สำหรับ Entity อื่น ๆ สามารถเพิ่มได้ที่นี่
        // public DbSet<CustomEntity> CustomEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // ตัวอย่างการกำหนดชื่อของตารางใหม่
            builder.Entity<FinalProjectUser>(entity =>
            {
                entity.ToTable("Users"); // เปลี่ยนชื่อ AspNetUsers เป็น Users
            });

            builder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Roles"); // เปลี่ยนชื่อ AspNetRoles เป็น Roles
            });

            builder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles"); // เปลี่ยนชื่อ AspNetUserRoles เป็น UserRoles
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims"); // เปลี่ยนชื่อ AspNetUserClaims เป็น UserClaims
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins"); // เปลี่ยนชื่อ AspNetUserLogins เป็น UserLogins
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens"); // เปลี่ยนชื่อ AspNetUserTokens เป็น UserTokens
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims"); // เปลี่ยนชื่อ AspNetRoleClaims เป็น RoleClaims
            });
        }
    }
}
