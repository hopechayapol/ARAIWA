using FinalProject.Areas.Identity.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// อ่านค่า Configuration จาก appsettings.json
var configuration = builder.Configuration;

// เพิ่มบริการสำหรับ DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

// เพิ่มบริการ Identity
builder.Services.AddDefaultIdentity<FinalProjectUser>(options =>
    {
        options.Password.RequireDigit = true;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = true;
        options.Password.RequireUppercase = true;
        options.Password.RequireLowercase = true;
    })
    .AddEntityFrameworkStores<ApplicationDbContext>();

// เพิ่มบริการ Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// กำหนด Middleware สำหรับโปรเจกต์
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // ใช้ Authentication Middleware
app.UseAuthorization();  // ใช้ Authorization Middleware

app.MapRazorPages();      // แมปเส้นทาง Razor Pages

app.Run();