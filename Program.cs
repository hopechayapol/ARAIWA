using FinalProject.Areas.Identity.Data;
<<<<<<< HEAD
using FinalProject.Data;
using Microsoft.AspNetCore.Identity;
=======
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

<<<<<<< HEAD
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FinalProjectContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<FinalProjectUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<FinalProjectContext>();
=======
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
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
builder.Services.AddRazorPages();

var app = builder.Build();

<<<<<<< HEAD
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
=======
// กำหนด Middleware สำหรับโปรเจกต์
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
}
else
{
    app.UseExceptionHandler("/Error");
<<<<<<< HEAD
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
=======
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

<<<<<<< HEAD
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
=======
app.UseAuthentication(); // ใช้ Authentication Middleware
app.UseAuthorization();  // ใช้ Authorization Middleware

app.MapRazorPages();      // แมปเส้นทาง Razor Pages

app.Run();
>>>>>>> 4f74a9664c41ed36d7ae4fa9effc1d036e3655d9
